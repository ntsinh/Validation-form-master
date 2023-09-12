using BLL;
using CallAPI;
using DTO;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl2;

namespace GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            subMenu();
        }
        private void subMenu()
        {
            pnlSubMenuKho.Visible = false;
            pnlSubMenuDssp.Visible = false;
            pnlSubmenuDonHang.Visible = false;
            pnlDstk.Visible = false;
        }
        private void hideSubmenu()
        {
            if (pnlSubMenuKho.Visible == true)
            {
                pnlSubMenuKho.Visible = false;
                pbArrowDsKho.Image = Properties.Resources.DownArrow;
            }
            if (pnlSubMenuDssp.Visible == true)
            {
                pnlSubMenuDssp.Visible = false;
                pbArrowDssp.Image = Properties.Resources.DownArrow;
            }
            if (pnlSubmenuDonHang.Visible == true)
            {
                pnlSubmenuDonHang.Visible = false;
                pbArrowVitri.Image = Properties.Resources.DownArrow;
            }
            if (pnlDstk.Visible == true)
            {
                pnlDstk.Visible = false;
                pbUser.Image = Properties.Resources.DownArrow;
            }
        }
        private void showSubmenu(Panel subMenu, PictureBox pb)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
                pb.Image = Properties.Resources.UpArrow;
            }
            else
            {
                subMenu.Visible = false;
                pb.Image = Properties.Resources.DownArrow;
            }
        }

        private void btnDsKho_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubMenuKho, pbArrowDsKho);
        }

        private void btnDssp_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubMenuDssp, pbArrowDssp);
        }
        public void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            tblShowForm.Controls.Add(childForm);
            tblShowForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else { Environment.Exit(0); }
        }


        private void btnDonHang_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubmenuDonHang, pbArrowVitri);
        }

        private void pbArrowDsKho_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubMenuKho, pbArrowDsKho);
        }

        private void pbArrowDssp_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubMenuDssp, pbArrowDssp);
        }

        private void pbArrowVitri_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubmenuDonHang, pbArrowVitri);
        }

        private void btnSpkd_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSPKD());
        }

        private void btnDsUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlDstk, pbUser);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            string hour = DateTime.Now.ToString("HH");
            string LoginUser = Program.userName;
            if (int.Parse(hour) < 11)
            {
                lbUser.Text = "Chào buổi sáng " + LoginUser;
            }
            else if (int.Parse(hour) < 15)
            {
                lbUser.Text = "Chào buổi trưa " + LoginUser;
            }
            else if (int.Parse(hour) < 18)
            {
                lbUser.Text = "Chào buổi chiều " + LoginUser;
            }
            else
            {
                lbUser.Text = "Chào buổi tối " + LoginUser;
            }
            lbUser.TextAlign = ContentAlignment.MiddleCenter;

            ApiBLL apiBLL = new ApiBLL();
            List<User> u = (List<User>)apiBLL.getJsonForGUI();
            bool access = false;
            foreach (User user in u)
            {
                if (user.Rule.Equals("Quản trị viên") && user.Username.Equals(LoginUser))
                {
                    Program.rule = "Quản trị viên";
                }
                if (user.Rule.Equals("Kiểm duyệt viên") && user.Username.Equals(LoginUser))
                {
                    Program.rule = "Kiểm duyệt viên";
                }
                if (user.Rule.Equals("Khách") && user.Username.Equals(LoginUser))
                {
                    pnlDsUser.Visible = false;
                    Program.rule = "Khách";
                }

            }
        }
    }
}
