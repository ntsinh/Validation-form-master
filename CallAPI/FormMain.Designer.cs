using System.Runtime.InteropServices;

namespace GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pnlSideBar = new Panel();
            pnlDstk = new Panel();
            button9 = new Button();
            btnDsUser = new Button();
            pnlDsUser = new Panel();
            btnUser = new Button();
            pbUser = new PictureBox();
            pnlSubmenuDonHang = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            pnlViTri = new Panel();
            btnDonHang = new Button();
            pbArrowVitri = new PictureBox();
            pnlSubMenuDssp = new Panel();
            button5 = new Button();
            button4 = new Button();
            btnSpkd = new Button();
            pnlDssp = new Panel();
            btnDssp = new Button();
            pbArrowDssp = new PictureBox();
            pnlSubMenuKho = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnThemKho = new Button();
            pnlDsKho = new Panel();
            btnDsKho = new Button();
            pbArrowDsKho = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pnlUser = new Panel();
            lbUser = new Label();
            panel5 = new Panel();
            tblShowForm = new TableLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlTitleBar = new Panel();
            label1 = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            pnlSideBar.SuspendLayout();
            pnlDstk.SuspendLayout();
            pnlDsUser.SuspendLayout();
            btnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            pnlSubmenuDonHang.SuspendLayout();
            pnlViTri.SuspendLayout();
            btnDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrowVitri).BeginInit();
            pnlSubMenuDssp.SuspendLayout();
            pnlDssp.SuspendLayout();
            btnDssp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrowDssp).BeginInit();
            pnlSubMenuKho.SuspendLayout();
            pnlDsKho.SuspendLayout();
            btnDsKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrowDsKho).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUser.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.AutoScroll = true;
            pnlSideBar.BackColor = Color.FromArgb(64, 64, 64);
            pnlSideBar.Controls.Add(pnlDstk);
            pnlSideBar.Controls.Add(pnlDsUser);
            pnlSideBar.Controls.Add(pnlSubmenuDonHang);
            pnlSideBar.Controls.Add(pnlViTri);
            pnlSideBar.Controls.Add(pnlSubMenuDssp);
            pnlSideBar.Controls.Add(pnlDssp);
            pnlSideBar.Controls.Add(pnlSubMenuKho);
            pnlSideBar.Controls.Add(pnlDsKho);
            pnlSideBar.Controls.Add(panel2);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 31);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(250, 553);
            pnlSideBar.TabIndex = 0;
            // 
            // pnlDstk
            // 
            pnlDstk.Controls.Add(button9);
            pnlDstk.Controls.Add(btnDsUser);
            pnlDstk.Dock = DockStyle.Top;
            pnlDstk.Location = new Point(0, 576);
            pnlDstk.Name = "pnlDstk";
            pnlDstk.Size = new Size(233, 88);
            pnlDstk.TabIndex = 10;
            // 
            // button9
            // 
            button9.BackColor = Color.Gray;
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(0, 30);
            button9.Name = "button9";
            button9.Padding = new Padding(20, 0, 0, 0);
            button9.Size = new Size(233, 30);
            button9.TabIndex = 6;
            button9.Text = "Button1";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // btnDsUser
            // 
            btnDsUser.BackColor = Color.Gray;
            btnDsUser.Dock = DockStyle.Top;
            btnDsUser.FlatAppearance.BorderSize = 0;
            btnDsUser.FlatStyle = FlatStyle.Flat;
            btnDsUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDsUser.ForeColor = Color.White;
            btnDsUser.Location = new Point(0, 0);
            btnDsUser.Name = "btnDsUser";
            btnDsUser.Padding = new Padding(20, 0, 0, 0);
            btnDsUser.Size = new Size(233, 30);
            btnDsUser.TabIndex = 5;
            btnDsUser.Text = "Danh sách tài khoản";
            btnDsUser.TextAlign = ContentAlignment.MiddleLeft;
            btnDsUser.UseVisualStyleBackColor = false;
            btnDsUser.Click += btnDsUser_Click;
            // 
            // pnlDsUser
            // 
            pnlDsUser.BackColor = Color.DarkOrange;
            pnlDsUser.Controls.Add(btnUser);
            pnlDsUser.Dock = DockStyle.Top;
            pnlDsUser.Location = new Point(0, 541);
            pnlDsUser.Name = "pnlDsUser";
            pnlDsUser.Size = new Size(233, 35);
            pnlDsUser.TabIndex = 11;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(238, 101, 37);
            btnUser.Controls.Add(pbUser);
            btnUser.Dock = DockStyle.Fill;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = Color.White;
            btnUser.Image = Properties.Resources.user1;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 0);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(10, 0, 0, 0);
            btnUser.Size = new Size(233, 35);
            btnUser.TabIndex = 5;
            btnUser.Text = "Quản lý tài khoản";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // pbUser
            // 
            pbUser.BackColor = Color.Transparent;
            pbUser.BackgroundImageLayout = ImageLayout.None;
            pbUser.Image = Properties.Resources.DownArrow;
            pbUser.Location = new Point(200, 12);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(20, 12);
            pbUser.TabIndex = 7;
            pbUser.TabStop = false;
            pbUser.Click += pbUser_Click;
            // 
            // pnlSubmenuDonHang
            // 
            pnlSubmenuDonHang.Controls.Add(button8);
            pnlSubmenuDonHang.Controls.Add(button7);
            pnlSubmenuDonHang.Controls.Add(button6);
            pnlSubmenuDonHang.Dock = DockStyle.Top;
            pnlSubmenuDonHang.Location = new Point(0, 453);
            pnlSubmenuDonHang.Name = "pnlSubmenuDonHang";
            pnlSubmenuDonHang.Size = new Size(233, 88);
            pnlSubmenuDonHang.TabIndex = 6;
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 60);
            button8.Name = "button8";
            button8.Padding = new Padding(20, 0, 0, 0);
            button8.Size = new Size(233, 30);
            button8.TabIndex = 7;
            button8.Text = "Button1";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 30);
            button7.Name = "button7";
            button7.Padding = new Padding(20, 0, 0, 0);
            button7.Size = new Size(233, 30);
            button7.TabIndex = 6;
            button7.Text = "Button1";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Padding = new Padding(20, 0, 0, 0);
            button6.Size = new Size(233, 30);
            button6.TabIndex = 5;
            button6.Text = "Button1";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // pnlViTri
            // 
            pnlViTri.BackColor = Color.DarkOrange;
            pnlViTri.Controls.Add(btnDonHang);
            pnlViTri.Dock = DockStyle.Top;
            pnlViTri.Location = new Point(0, 418);
            pnlViTri.Name = "pnlViTri";
            pnlViTri.Size = new Size(233, 35);
            pnlViTri.TabIndex = 9;
            // 
            // btnDonHang
            // 
            btnDonHang.BackColor = Color.FromArgb(238, 101, 37);
            btnDonHang.Controls.Add(pbArrowVitri);
            btnDonHang.Dock = DockStyle.Fill;
            btnDonHang.FlatAppearance.BorderSize = 0;
            btnDonHang.FlatStyle = FlatStyle.Flat;
            btnDonHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDonHang.ForeColor = Color.White;
            btnDonHang.Image = Properties.Resources.Local;
            btnDonHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnDonHang.Location = new Point(0, 0);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Padding = new Padding(10, 0, 0, 0);
            btnDonHang.Size = new Size(233, 35);
            btnDonHang.TabIndex = 5;
            btnDonHang.Text = "Vị trí";
            btnDonHang.TextAlign = ContentAlignment.MiddleLeft;
            btnDonHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDonHang.UseVisualStyleBackColor = false;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // pbArrowVitri
            // 
            pbArrowVitri.BackColor = Color.Transparent;
            pbArrowVitri.BackgroundImageLayout = ImageLayout.None;
            pbArrowVitri.Image = Properties.Resources.DownArrow;
            pbArrowVitri.Location = new Point(200, 12);
            pbArrowVitri.Name = "pbArrowVitri";
            pbArrowVitri.Size = new Size(20, 12);
            pbArrowVitri.TabIndex = 7;
            pbArrowVitri.TabStop = false;
            pbArrowVitri.Click += pbArrowVitri_Click;
            // 
            // pnlSubMenuDssp
            // 
            pnlSubMenuDssp.Controls.Add(button5);
            pnlSubMenuDssp.Controls.Add(button4);
            pnlSubMenuDssp.Controls.Add(btnSpkd);
            pnlSubMenuDssp.Dock = DockStyle.Top;
            pnlSubMenuDssp.Location = new Point(0, 330);
            pnlSubMenuDssp.Name = "pnlSubMenuDssp";
            pnlSubMenuDssp.Size = new Size(233, 88);
            pnlSubMenuDssp.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 60);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(233, 30);
            button5.TabIndex = 4;
            button5.Text = "Button1";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 30);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(233, 30);
            button4.TabIndex = 3;
            button4.Text = "Button1";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // btnSpkd
            // 
            btnSpkd.BackColor = Color.Gray;
            btnSpkd.Dock = DockStyle.Top;
            btnSpkd.FlatAppearance.BorderSize = 0;
            btnSpkd.FlatStyle = FlatStyle.Flat;
            btnSpkd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSpkd.ForeColor = Color.White;
            btnSpkd.Location = new Point(0, 0);
            btnSpkd.Name = "btnSpkd";
            btnSpkd.Padding = new Padding(20, 0, 0, 0);
            btnSpkd.Size = new Size(233, 30);
            btnSpkd.TabIndex = 2;
            btnSpkd.Text = "Sản phẩm kinh doanh";
            btnSpkd.TextAlign = ContentAlignment.MiddleLeft;
            btnSpkd.UseVisualStyleBackColor = false;
            btnSpkd.Click += btnSpkd_Click;
            // 
            // pnlDssp
            // 
            pnlDssp.BackColor = Color.DarkOrange;
            pnlDssp.Controls.Add(btnDssp);
            pnlDssp.Dock = DockStyle.Top;
            pnlDssp.Location = new Point(0, 295);
            pnlDssp.Name = "pnlDssp";
            pnlDssp.Size = new Size(233, 35);
            pnlDssp.TabIndex = 8;
            // 
            // btnDssp
            // 
            btnDssp.BackColor = Color.FromArgb(238, 101, 37);
            btnDssp.Controls.Add(pbArrowDssp);
            btnDssp.Dock = DockStyle.Fill;
            btnDssp.FlatAppearance.BorderSize = 0;
            btnDssp.FlatStyle = FlatStyle.Flat;
            btnDssp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDssp.ForeColor = Color.White;
            btnDssp.Image = Properties.Resources.Product;
            btnDssp.ImageAlign = ContentAlignment.MiddleLeft;
            btnDssp.Location = new Point(0, 0);
            btnDssp.Name = "btnDssp";
            btnDssp.Padding = new Padding(10, 0, 0, 0);
            btnDssp.Size = new Size(233, 35);
            btnDssp.TabIndex = 3;
            btnDssp.Text = "Danh sách sản phẩm";
            btnDssp.TextAlign = ContentAlignment.MiddleLeft;
            btnDssp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDssp.UseVisualStyleBackColor = false;
            btnDssp.Click += btnDssp_Click;
            // 
            // pbArrowDssp
            // 
            pbArrowDssp.BackColor = Color.Transparent;
            pbArrowDssp.BackgroundImageLayout = ImageLayout.None;
            pbArrowDssp.Image = Properties.Resources.DownArrow;
            pbArrowDssp.Location = new Point(200, 12);
            pbArrowDssp.Name = "pbArrowDssp";
            pbArrowDssp.Size = new Size(20, 12);
            pbArrowDssp.TabIndex = 7;
            pbArrowDssp.TabStop = false;
            pbArrowDssp.Click += pbArrowDssp_Click;
            // 
            // pnlSubMenuKho
            // 
            pnlSubMenuKho.Controls.Add(button2);
            pnlSubMenuKho.Controls.Add(button1);
            pnlSubMenuKho.Controls.Add(btnThemKho);
            pnlSubMenuKho.Dock = DockStyle.Top;
            pnlSubMenuKho.Location = new Point(0, 205);
            pnlSubMenuKho.Name = "pnlSubMenuKho";
            pnlSubMenuKho.Size = new Size(233, 90);
            pnlSubMenuKho.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 60);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(233, 30);
            button2.TabIndex = 2;
            button2.Text = "Button1";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 30);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(233, 30);
            button1.TabIndex = 1;
            button1.Text = "Button1";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnThemKho
            // 
            btnThemKho.BackColor = Color.Gray;
            btnThemKho.Dock = DockStyle.Top;
            btnThemKho.FlatAppearance.BorderSize = 0;
            btnThemKho.FlatStyle = FlatStyle.Flat;
            btnThemKho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemKho.ForeColor = Color.White;
            btnThemKho.Location = new Point(0, 0);
            btnThemKho.Name = "btnThemKho";
            btnThemKho.Padding = new Padding(20, 0, 0, 0);
            btnThemKho.Size = new Size(233, 30);
            btnThemKho.TabIndex = 0;
            btnThemKho.Text = "Thêm kho xuất";
            btnThemKho.TextAlign = ContentAlignment.MiddleLeft;
            btnThemKho.UseVisualStyleBackColor = false;
            btnThemKho.Click += btnThemKho_Click;
            // 
            // pnlDsKho
            // 
            pnlDsKho.BackColor = Color.DarkOrange;
            pnlDsKho.Controls.Add(btnDsKho);
            pnlDsKho.Dock = DockStyle.Top;
            pnlDsKho.Location = new Point(0, 170);
            pnlDsKho.Name = "pnlDsKho";
            pnlDsKho.Size = new Size(233, 35);
            pnlDsKho.TabIndex = 1;
            // 
            // btnDsKho
            // 
            btnDsKho.BackColor = Color.FromArgb(238, 101, 37);
            btnDsKho.Controls.Add(pbArrowDsKho);
            btnDsKho.Dock = DockStyle.Fill;
            btnDsKho.FlatAppearance.BorderSize = 0;
            btnDsKho.FlatStyle = FlatStyle.Flat;
            btnDsKho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDsKho.ForeColor = Color.White;
            btnDsKho.Image = Properties.Resources.Storal;
            btnDsKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnDsKho.Location = new Point(0, 0);
            btnDsKho.Name = "btnDsKho";
            btnDsKho.Padding = new Padding(10, 0, 0, 0);
            btnDsKho.Size = new Size(233, 35);
            btnDsKho.TabIndex = 1;
            btnDsKho.Text = "Danh sách kho";
            btnDsKho.TextAlign = ContentAlignment.MiddleLeft;
            btnDsKho.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDsKho.UseVisualStyleBackColor = false;
            btnDsKho.Click += btnDsKho_Click;
            // 
            // pbArrowDsKho
            // 
            pbArrowDsKho.BackColor = Color.Transparent;
            pbArrowDsKho.BackgroundImageLayout = ImageLayout.None;
            pbArrowDsKho.Image = Properties.Resources.DownArrow;
            pbArrowDsKho.Location = new Point(200, 12);
            pbArrowDsKho.Name = "pbArrowDsKho";
            pbArrowDsKho.Size = new Size(20, 12);
            pbArrowDsKho.TabIndex = 7;
            pbArrowDsKho.TabStop = false;
            pbArrowDsKho.Click += pbArrowDsKho_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pnlUser);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 170);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(lbUser);
            pnlUser.Dock = DockStyle.Bottom;
            pnlUser.Location = new Point(0, 135);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(233, 35);
            pnlUser.TabIndex = 1;
            // 
            // lbUser
            // 
            lbUser.Dock = DockStyle.Fill;
            lbUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.ForeColor = Color.White;
            lbUser.Location = new Point(0, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(233, 35);
            lbUser.TabIndex = 0;
            lbUser.Text = "label1";
            lbUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 185);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 40);
            panel5.TabIndex = 7;
            // 
            // tblShowForm
            // 
            tblShowForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblShowForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblShowForm.ColumnCount = 1;
            tblShowForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblShowForm.Location = new Point(250, 32);
            tblShowForm.Name = "tblShowForm";
            tblShowForm.RowCount = 1;
            tblShowForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblShowForm.Size = new Size(830, 547);
            tblShowForm.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(238, 101, 37);
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1080, 31);
            pnlTitleBar.TabIndex = 2;
            pnlTitleBar.MouseDoubleClick += pnlTitleBar_MouseDoubleClick;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            pnlTitleBar.MouseMove += pnlTitleBar_MouseMove;
            pnlTitleBar.MouseUp += pnlTitleBar_MouseUp;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.LogoGonSa1;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 1;
            label1.Text = "Data management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.minus;
            btnMinimize.Location = new Point(987, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(31, 31);
            btnMinimize.TabIndex = 0;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.maximize;
            btnMaximize.Location = new Point(1018, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(31, 31);
            btnMaximize.TabIndex = 0;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btnMaximize_MouseEnter;
            btnMaximize.MouseLeave += btnMaximize_MouseLeave;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(1049, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 31);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 584);
            Controls.Add(tblShowForm);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(950, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data management";
            FormClosing += Form2_FormClosing;
            Load += FormMain_Load;
            pnlSideBar.ResumeLayout(false);
            pnlDstk.ResumeLayout(false);
            pnlDsUser.ResumeLayout(false);
            btnUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            pnlSubmenuDonHang.ResumeLayout(false);
            pnlViTri.ResumeLayout(false);
            btnDonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArrowVitri).EndInit();
            pnlSubMenuDssp.ResumeLayout(false);
            pnlDssp.ResumeLayout(false);
            btnDssp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArrowDssp).EndInit();
            pnlSubMenuKho.ResumeLayout(false);
            pnlDsKho.ResumeLayout(false);
            btnDsKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArrowDsKho).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlUser.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSideBar;
        private Button btnDsKho;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel pnlSubMenuKho;
        private Button btnThemKho;
        private Panel pnlSubMenuDssp;
        private Button btnDssp;
        private Button btnDonHang;
        private TableLayoutPanel tblShowForm;
        private Panel pnlSubmenuDonHang;
        private PictureBox pbArrowDsKho;
        private PictureBox pbArrowDssp;
        private PictureBox pbArrowVitri;
        private Panel pnlDsKho;
        private Panel pnlDssp;
        private Button button1;
        private Panel pnlViTri;
        private Button button4;
        private Button btnSpkd;
        private Button button7;
        private Button button6;
        private Panel pnlDstk;
        private Button button9;
        private Button btnDsUser;
        private Panel pnlDsUser;
        private Button btnUser;
        private PictureBox pbUser;
        private Panel panel5;
        private Button button8;
        private Button button5;
        private Button button2;
        private Panel pnlUser;
        private Label lbUser;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlTitleBar;
        private Label label1;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
    }
}