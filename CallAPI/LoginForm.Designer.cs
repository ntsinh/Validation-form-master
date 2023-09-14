namespace UserControl2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLogin = new CustomButton();
            userControl12 = new UserControl1();
            userControl11 = new UserControl1();
            pbEye = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEye).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(391, 183);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 101, 37);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(343, 428);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = GUI.Properties.Resources.LogoGonSa;
            pictureBox2.Location = new Point(109, 2);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GUI.Properties.Resources.GONSA_Fly_7K;
            pictureBox1.Location = new Point(50, 158);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(238, 101, 37);
            label2.Location = new Point(438, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 45);
            label2.TabIndex = 3;
            label2.Text = "LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(380, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 4;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(391, 271);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(380, 200);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(238, 101, 37);
            btnLogin.BackgroundColor = Color.FromArgb(238, 101, 37);
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 5;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(424, 300);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 46);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // userControl12
            // 
            userControl12.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            userControl12.BackColor = SystemColors.Window;
            userControl12.BorderColor = Color.FromArgb(238, 101, 37);
            userControl12.BorderFocusColor = Color.HotPink;
            userControl12.BorderRadius = 0;
            userControl12.BorderSize = 2;
            userControl12.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            userControl12.ForeColor = Color.DimGray;
            userControl12.Location = new Point(380, 225);
            userControl12.Margin = new Padding(5);
            userControl12.Multiline = false;
            userControl12.Name = "userControl12";
            userControl12.Padding = new Padding(8);
            userControl12.PasswordChar = true;
            userControl12.Size = new Size(260, 33);
            userControl12.TabIndex = 5;
            userControl12.textBox1_Text = "";
            userControl12.Texts = "";
            userControl12.UnderlinedStyle = true;
            userControl12._TextChanged += userControl12__TextChanged;
            // 
            // userControl11
            // 
            userControl11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            userControl11.BackColor = SystemColors.Window;
            userControl11.BorderColor = Color.FromArgb(238, 101, 37);
            userControl11.BorderFocusColor = Color.HotPink;
            userControl11.BorderRadius = 0;
            userControl11.BorderSize = 2;
            userControl11.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            userControl11.ForeColor = Color.DimGray;
            userControl11.Location = new Point(380, 136);
            userControl11.Margin = new Padding(5);
            userControl11.Multiline = false;
            userControl11.Name = "userControl11";
            userControl11.Padding = new Padding(8);
            userControl11.PasswordChar = false;
            userControl11.Size = new Size(260, 33);
            userControl11.TabIndex = 0;
            userControl11.textBox1_Text = "";
            userControl11.Texts = "";
            userControl11.UnderlinedStyle = true;
            userControl11._TextChanged += userControl11__TextChanged;
            // 
            // pbEye
            // 
            pbEye.Image = GUI.Properties.Resources.close_eye;
            pbEye.Location = new Point(601, 225);
            pbEye.Name = "pbEye";
            pbEye.Size = new Size(24, 24);
            pbEye.TabIndex = 7;
            pbEye.TabStop = false;
            pbEye.Click += pbEye_Click;
            pbEye.MouseEnter += pbEye_MouseEnter;
            pbEye.MouseLeave += pbEye_MouseLeave;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(674, 428);
            Controls.Add(pbEye);
            Controls.Add(btnLogin);
            Controls.Add(userControl12);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(userControl11);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += LoginForm_Load;
            KeyDown += LoginForm_KeyDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControl1 userControl11;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private UserControl1 userControl12;
        private CustomButton btnLogin;
        private PictureBox pbEye;
    }
}

