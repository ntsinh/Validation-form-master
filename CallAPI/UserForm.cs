using BLL;
using CallAPI;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl2;
using User = DTO.User;

namespace GUI
{
    public partial class UserForm : Form
    {
        List<User> listUsers;
        public UserForm()
        {
            InitializeComponent();
            dgvUser.AutoGenerateColumns = false;
        }

        //string salt = BCrypt.Net.BCrypt.GenerateSalt(13);
        #region them user
        private async void btnThem_Click(object sender, EventArgs e)
        {

            //if (check())
            //{
            //    tbUser.Error = "User Name đã tồn tại";
            //}
            //else
            //{
            //    User user = new User();
            //    user.Username = tbUser.Text;
            //    user.Password = tbPw.Text;
            //    user.Email = tbEmail.Text;
            //    listUsers.Add(user);
            //    saveJson();
            //    resetDgvUser();
            //    dgvUser.DataSource = listUsers;
            //}
            tbUser.ErrorLable(true);
            if (tbPw.Text == "")
            {
                //nếu tbPw rỗng => bật cảnh báo
                tbPw.AllowNull = false;
                tbPw.ErrorLable(true);

            }
            var user = listUsers.FirstOrDefault(u => u.Username == tbUser.Text);
            if (user != null)
            {
                tbUser.Error = "User Name đã tồn tại";
            }
            else
            {
                //mã hóa pw
                //string hash = BCrypt.Net.BCrypt.HashPassword(tbPw.Text, salt);
                string hash = Program.EncryptSHA512Managed(tbPw.Text);
                User us = new User();
                us.Username = tbUser.Text;
                us.Password = hash;
                string email = tbEmail.Text;
                us.Email = email;
                //nếu ccbRule trống => cảnh báo
                if (cbbRule.Text != "")
                {
                    lbError.Text = "";
                    lbError.Visible = false;
                    us.Rule = cbbRule.SelectedItem.ToString();
                }
                else
                {
                    lbError.Visible = true;
                    lbError.Text = "Chưa set quyền";
                }
                //trong textboxcustom đã validation sẵn,thay vì phải validate lại chỉ cần kiểm tra label error của nó, nếu trống => không có lỗi => cho phép thực thi
                if (tbUser.Error == "" && tbPw.Error == "" && tbEmail.Error == "" && lbError.Text == "")
                {
                    listUsers.Add(us);
                    saveJson();
                    resetDgvUser();
                    dgvUser.DataSource = listUsers;
                    MessageBox.Show("Thêm thành công");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng các trường");
                }

            }
        }
        #endregion
        //public bool IsValidEmail(string email)
        //{
        //    string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
        //    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
        //    return regex.IsMatch(email);
        //}
        private void resetDgvUser()
        {
            dgvUser.DataSource = null;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            //User user = new User();
            //user.Username = "admin";
            //user.Password = "12345678";
            //user.Email = "abc";
            //listUsers.Add(user);
            HienThi();
            if (Program.rule.Equals("Khách"))
            {
                // kiểm tra nếu rule của user đăng nhập là khách => chỉ được xem, không cho phép thêm, xóa, sửa
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            if (Program.rule.Equals("Kiểm duyệt viên"))
            {
                //nếu user đang đang đăng nhập có rule = kiểm duyệt viên thì không được phép xóa
                btnXoa.Enabled = false;
            }
        }
        public void HienThi()
        {
            ApiBLL apiBLL = new ApiBLL();
            var data = apiBLL.getJsonForGUI();
            listUsers = (List<User>)data;
            dgvUser.DataSource = listUsers;
        }
        //lưu listUser vào file Json
        private void saveJson()
        {
            var UserlistJson = JsonConvert.SerializeObject(listUsers);
            string fileName = @"D:\WinForm\Validation-form-master\UserList.json";
            if (File.Exists(fileName) == false)
            {
                File.WriteAllText(fileName, UserlistJson);
            }
            else
            {
                File.Delete(fileName);
                File.WriteAllText(fileName, UserlistJson);
            }
        }
        #region sua user
        private async void btnSua_Click(object sender, EventArgs e)
        {
            //mã hóa textbox pw
            string hash = Program.EncryptSHA512Managed(tbPw.Text);
            //string hash = BCrypt.Net.BCrypt.HashPassword(tbPw.Text, salt);
            var user = listUsers.FirstOrDefault(u => u.Username == tbUser.Text);
            if (user != null)
            {
                //hàm sửa cho phép các textbox được để trống, chỉ những textbox có value mới sửa đổi
                if (tbPw.Text == "")
                {
                    //nếu texboxPw trống thì cho phép null để không hiện cảnh báo, 
                    tbPw.AllowNull = true;
                }
                else
                {
                    tbPw.ErrorLable(true);
                    user.Password = hash;
                }
                if (tbEmail.Text != "")
                {
                    user.Email = tbEmail.Text;
                }
                if (cbbRule.Text != "")
                {
                    //kiểm tra nếu value của ccb đang nhập không phải qtv => checkRule
                    if (cbbRule.Text != "Quản trị viên")
                    {
                        if (CheckRule("Sua"))
                        {
                            user.Rule = cbbRule.SelectedItem.ToString();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        user.Rule = cbbRule.SelectedItem.ToString();
                    }

                }
                else
                {
                    lbError.Text = "";
                    lbError.Visible = false;
                }
                //trong textboxcustom đã validation sẵn,thay vì phải validate lại chỉ cần kiểm tra label error của nó, nếu trống => không có lỗi => cho phép thực thi
                if (tbUser.Error == "" && tbPw.Error == "" && tbEmail.Error == "" && lbError.Text == "")
                {
                    saveJson();
                    resetDgvUser();
                    dgvUser.DataSource = listUsers;
                    tbPw.AllowNull = false;
                    MessageBox.Show("Sửa thành công");
                    //nếu user bị xóa quyền qtv là user đang đăng nhập => thông báo và ẩn form quản lý user
                    if (Program.rule != "Quản trị viên")
                    {
                        MessageBox.Show("Bạn không còn là quản trị viên nữa");
                        this.Hide();
                    }
                    Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng các trường");
                    await Task.Delay(3000);
                    lbError.Text = "";
                    lbError.Visible = false;
                }

            }
            else
            {
                tbUser.ErrorLable(true);
                tbUser.Error = "User Name không tồn tại";
            }
        }
        #endregion
        #region xoa user
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var user = listUsers.FirstOrDefault(u => u.Username == tbUser.Text);
            if (user != null)
            {
                bool check = false;
                //kiểm tra xem rule của user muốn xóa có phải là qtv không
                // nếu đúng => gọi hàm checkRule kiểm tra
                foreach (User us in listUsers)
                {
                    if (us.Rule=="Quản trị viên")
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    if (CheckRule("Xoa"))
                    {
                        listUsers.Remove(user);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    listUsers.Remove(user);
                }
                saveJson();
                resetDgvUser();
                dgvUser.DataSource = listUsers;
                Clear();
            }
            else
            {
                tbUser.Error = "User Name không tồn tại";
            }
        }
        #endregion
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvUser.Rows[e.RowIndex];
            //kiểm tra nếu textboxUser trống hoặc có value khác với value của cellClick => fill value từ cellClick vào textbox
            //nếu khác thì làm trống textbox => mục đích khi ngươi dùng nhấn vào cùng 1 cell lần đầu thì fill value, lần 2 sẽ clear value
            if (!tbUser.Text.Equals(row.Cells[0].Value.ToString())||tbUser.Text=="")
            {
                tbUser.Text = row.Cells[0].Value.ToString();
                if (row.Cells[2].Value != null)
                {
                    tbEmail.Text = row.Cells[2].Value.ToString();
                }
                else
                {
                    tbEmail.Text = "";
                }
                cbbRule.Text = row.Cells[3].Value.ToString();
            }
            else
            {
                dgvUser.FirstDisplayedCell = null;
                dgvUser.ClearSelection();
                Clear();
            }
            
        }
        public bool CheckRule(String btnClick)
        {
            int count = 0;
            string userRule = "";
            foreach (User us in listUsers)
            {
                if (us.Rule.Equals("Quản trị viên") && us.Username.Equals(tbUser.Text))
                {
                    //kiểm tra xem rule của textbox UserName có phải quản trị viên không
                    userRule = us.Rule;
                }
                if (us.Rule.Equals("Quản trị viên"))
                {
                    //đếm số user có rule là quản trị viên
                    count++;
                }
            }
            //nếu rule của user muốn thay đổi là qtv và số lượng lớn hơn 1 => cho phép thực thi
            //đảm bảo luôn có ít nhất 1 qtv để quản lý user
            if (userRule == "Quản trị viên")
            {
                if (count > 1)
                {
                    //kiểm tra xem user muốn thay đổi quyền qtv có phải user đang đăng nhập không
                    // nếu đúng => cảnh báo & xác nhận
                    if (Program.userName.Equals(tbUser.Text))
                    {
                        //kiểm tra nguồn event button_click
                        //nếu từ btnSua thì cho phép thực thi
                        //nếu từ btnXoa thì hủy => không cho phép xóa user đang đăng nhập
                        if (btnClick=="Sua")
                        {
                            DialogResult dr = MessageBox.Show("Sau khi thay đổi bạn sẽ không còn quyền quản lý user nữa ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa tài khoản đang đăng nhập");
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }

                }
                else
                {
                    lbError.Visible = true;
                    lbError.Text = "Phải có ít nhất 1 quản trị viên";
                    return false;
                }
            }
            else
            {
                lbError.Text = "";
                lbError.Visible = false;
                return true;
            }
        }
        //hàm làm trống textbox mỗi khi hoàn tất 1 thao tác
        public void Clear()
        {
            tbUser.Text = null;
            tbUser.ErrorLable(false);
            tbPw.Text = null;
            tbPw.ErrorLable(false);
            tbEmail.Text = null;
            cbbRule.SelectedIndex = -1;

        }
    }
}
