using BLL;
using CallAPI;
using DTO;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl2;

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

        private void btnThem_Click(object sender, EventArgs e)
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
            if (tbPw.Text == "")
            {
                tbPw.ErrorLable(true);
            }
            var user = listUsers.FirstOrDefault(u => u.Username == tbUser.Text);
            if (user != null)
            {
                tbUser.Error = "User Name đã tồn tại";
            }
            else
            {
                //string hash = BCrypt.Net.BCrypt.HashPassword(tbPw.Text, salt);
                string hash = Program.EncryptSHA512Managed(tbPw.Text);
                User us = new User();
                us.Username = tbUser.Text;
                us.Password = hash;
                string email = tbEmail.Text;
                us.Email = email;
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
                if (tbUser.Error == "" && tbPw.Error == "" && tbEmail.Error == "" && lbError.Text == "")
                {
                    listUsers.Add(us);
                    saveJson();
                    resetDgvUser();
                    dgvUser.DataSource = listUsers;
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng các trường");
                }

            }
        }
        //public bool IsValidEmail(string email)
        //{
        //    string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
        //    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
        //    return regex.IsMatch(email);
        //}
        private bool check()
        {
            ApiBLL apiBLL = new ApiBLL();
            List<User> data = (List<User>)apiBLL.getJsonForGUI();
            bool exist = false;
            foreach (User us in data)
            {
                if (us.Username.Equals(tbUser.Text))
                {
                    exist = true;
                }
            }
            return exist;
        }
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
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            if (Program.rule.Equals("Kiểm duyệt viên"))
            {
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string hash = Program.EncryptSHA512Managed(tbPw.Text);
            //string hash = BCrypt.Net.BCrypt.HashPassword(tbPw.Text, salt);
            var user = listUsers.FirstOrDefault(u => u.Username == tbUser.Text);
            if (user != null)
            {

                string email = tbEmail.Text;
                if (tbPw.Text == "")
                {
                    tbPw.ErrorLable(false);
                }
                else
                {
                    user.Password = hash;
                }
                if (tbEmail.Text != "")
                {
                    user.Email = email;
                }
                if (cbbRule.Text != "")
                {
                    user.Rule = cbbRule.SelectedItem.ToString();
                }
                if (tbUser.Error == "" && (tbPw.Error == "" || tbPw.Error == "Không được để trống!") && tbEmail.Error == "")
                {
                    tbPw.ErrorLable(false);
                    saveJson();
                    resetDgvUser();
                    dgvUser.DataSource = listUsers;
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng các trường");
                }

            }
            else
            {
                tbUser.Error = "User Name không tồn tại";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var user = listUsers.FirstOrDefault(u => u.Username == tbUser.Text);
            if (user != null)
            {
                listUsers.Remove(user);
                saveJson();
                resetDgvUser();
                dgvUser.DataSource = listUsers;
            }
            else
            {
                tbUser.Error = "User Name không tồn tại";
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvUser.Rows[e.RowIndex];
            tbUser.Text = row.Cells[0].Value.ToString();
            tbPw.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null)
            {
                tbEmail.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                tbEmail.Text = "";
            }
        }
        public void Clear()
        {
            tbUser.Text = null;
            tbPw.Text = null;
            tbEmail.Text = null;

        }
    }
}
