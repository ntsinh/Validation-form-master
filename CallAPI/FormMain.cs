using BLL;
using CallAPI;
using DTO;
using GUI.Properties;
using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //ẩn các subMenu
        private void subMenu()
        {
            pnlSubMenuKho.Visible = false;
            pnlSubMenuDssp.Visible = false;
            pnlSubmenuDonHang.Visible = false;
            pnlDstk.Visible = false;
        }
        private void unFocus()
        {
            btnThemKho.BackColor = Color.Gray;
            btnSpkd.BackColor = Color.Gray;
            btnDsUser.BackColor = Color.Gray;
        }
        //nếu có subMenu đang bật => tắt
        private void hideSubmenu()
        {
            if (pnlSubMenuKho.Visible == true)
            {
                pnlSubMenuKho.Visible = false;
                pbArrowDsKho.Image = Resources.DownArrow;
            }
            if (pnlSubMenuDssp.Visible == true)
            {
                pnlSubMenuDssp.Visible = false;
                pbArrowDssp.Image = Resources.DownArrow;
            }
            if (pnlSubmenuDonHang.Visible == true)
            {
                pnlSubmenuDonHang.Visible = false;
                pbArrowVitri.Image = Resources.DownArrow;
            }
            if (pnlDstk.Visible == true)
            {
                pnlDstk.Visible = false;
                pbUser.Image = Resources.DownArrow;
            }
        }
        //nếu subMenu cần mở đang tắt => bật
        private void showSubmenu(Panel subMenu, PictureBox pb)
        {
            colapse = true;
            CollapseTimer.Start();
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
                pb.Image = Resources.UpArrow;
            }
            else
            {
                subMenu.Visible = false;
                pb.Image = Resources.DownArrow;
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
        //mở childform
        public void openChildForm(Form childForm, object sender)
        {
            unFocus();
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(89, 206, 143);
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == childForm.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
                else
                {
                    isOpen = false;
                }
            }
            if (isOpen == false)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlShowForm.Controls.Add(childForm);
                pnlShowForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1(), sender);
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
            openChildForm(new frmSPKD(), sender);
        }

        private void btnDsUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm(), sender);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlDstk, pbUser);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
        private void pbUser_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlDstk, pbUser);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //kiểm tra thời gian hiện tại để gửi lời chào phù hợp
            int hour = DateTime.Now.Hour;
            string LoginUser = Program.userName;
            if (hour < 11)
            {
                lbUser.Text = "Chào buổi sáng " + LoginUser;
            }
            else if (hour < 13)
            {
                lbUser.Text = "Chào buổi trưa " + LoginUser;
            }
            else if (hour < 19)
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
            foreach (User user in u)
            {
                //kiểm tra rule của user đang đăng nhập
                if (user.Rule.Equals("Quản trị viên") && user.Username.Equals(LoginUser))
                {
                    //nếu là qtv thì được phép mở dsUser
                    pnlDsUser.Visible = true;
                    Program.rule = "Quản trị viên";
                }
                if (user.Rule.Equals("Kiểm duyệt viên") && user.Username.Equals(LoginUser))
                {
                    //nếu là kdt thì ẩn dsUser
                    pnlDsUser.Visible = false;
                    pnlDstk.Visible = false;
                    Program.rule = "Kiểm duyệt viên";
                }
                if (user.Rule.Equals("Khách") && user.Username.Equals(LoginUser))
                {
                    //nếu là khách thì ẩn dsUser
                    pnlDsUser.Visible = false;
                    pnlDstk.Visible = false;
                    Program.rule = "Khách";
                }

            }
        }
        #region Title bar event
        //sự kiện của các button trên tittle bar
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = Resources.maximize;
                WindowState = FormWindowState.Normal;
                this.SetDesktopLocation(xForm, yForm);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Resources.restore_down;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.FromArgb(89, 206, 143);
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.Transparent;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(89, 206, 143);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
        }

        private void pnlTitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //khi doubleclick chuột vào tittlebar nếu form ở trạng thái maximize thì set form thành normal và đưa form về vị trí trước khi maximize
            if (WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = Resources.maximize;
                WindowState = FormWindowState.Normal;
                top = false;
                this.SetDesktopLocation(xForm, yForm);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Resources.restore_down;
            }
        }
        bool click = false;
        bool top = false;
        int xLast, yLast, xForm, yForm, formWidth, formHeight;
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            //di chuyển form khi nhấn giữ và kéo thả chuột trên tittle bar
            xLast = e.X;
            yLast = e.Y;
            click = true;
            formWidth = this.Width;
            formHeight = this.Height;
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
            // sau khi kéo thả chuột nếu form ở trạng thái normal và tittle bar có vị trí bằng với cạnh trên màn hình thì chuyển trạng thái của form thàng maximize
            if (top == true && WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Resources.restore_down;
            }

        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                //di chuyển form đến vị trí kéo thả của chuột
                this.SetDesktopLocation(MousePosition.X - xLast, MousePosition.Y - yLast);
                //nếu top của form lớn hơn hoặc bằng cạnh trên của màn hình => set vị trí form bằng cạnh trên màn hình => tránh thanh tittle bar bị che
                //đồng thời set form = maximize
                if (this.Top <= Screen.PrimaryScreen.Bounds.Top)
                {
                    this.Top = Screen.PrimaryScreen.Bounds.Top;
                    top = true;
                }
                else
                {
                    top = false;
                }
                //nếu form trong trạng thái maximize và được kéo xuống 1 khoảng y = 1 thì chuyển trạng thái của form thành normal
                if (MousePosition.Y - yLast > 1)
                {
                    if (WindowState == FormWindowState.Maximized)
                    {
                        WindowState = FormWindowState.Normal;
                        btnMaximize.Image = Resources.maximize;
                    }
                }
            }

        }
        private void FormMain_Move(object sender, EventArgs e)
        {
            //lấy vị trí cuối của form trước khi bị di chuyển
            if (WindowState == FormWindowState.Normal && click == false)
            {
                xForm = this.DesktopLocation.X;
                yForm = this.DesktopLocation.Y;
            }
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            //lấy vị trí cuối của form trước khi maximize
            if (WindowState == FormWindowState.Normal && this.Top > Screen.PrimaryScreen.Bounds.Top)
            {
                xForm = this.DesktopLocation.X;
                yForm = this.DesktopLocation.Y;
            }
        }

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {

        }
        #endregion
        // cho phép resize form
        #region Resize form
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        protected override void WndProc(ref Message m)
        {
            if (WindowState == FormWindowState.Normal)
            {
                if (m.Msg == 0x84)
                {  // Trap WM_NCHITTEST
                    Point pos = new Point(m.LParam.ToInt32());
                    pos = this.PointToClient(pos);
                    if (pos.Y < cCaption)
                    {
                        m.Result = (IntPtr)2;  // HTCAPTION
                        return;
                    }
                    if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                        return;
                    }
                }
            }
            base.WndProc(ref m);
        }
        #endregion
        bool colapse = true;
        private void CollapseTimer_Tick(object sender, EventArgs e)
        {
            if (colapse)
            {
                btnMenu.Image = Resources.Collapse;
                pnlSideBar.Width += 40;
                pnlShowForm.Visible = false;
                if (pnlSideBar.Width == 250)
                {
                    pnlShowForm.Visible = true;
                    CollapseTimer.Stop();
                    lbUser.Visible = true;
                    colapse = false;
                }
            }
            else
            {
                hideSubmenu();
                lbUser.Visible = false;
                btnMenu.Image = Resources.Menu;
                pnlSideBar.Width -= 40;
                pnlShowForm.Visible = false;
                if (pnlSideBar.Width == 45)
                {
                    pnlShowForm.Visible = true;
                    CollapseTimer.Stop();
                    colapse = true;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseTimer.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.FromArgb(89, 206, 143);
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Transparent;
        }



        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}
    }
}
