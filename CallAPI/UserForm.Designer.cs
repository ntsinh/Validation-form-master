namespace GUI
{
    partial class UserForm
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
            panel1 = new Panel();
            label4 = new Label();
            btnXoa = new CustomButton();
            btnThem = new CustomButton();
            btnSua = new CustomButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbPw = new Components.Textboxs.TextBoxCustom();
            tbUser = new Components.Textboxs.TextBoxCustom();
            tbEmail = new Components.Textboxs.TextBoxCustom();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            cbbRule = new ComboBox();
            lbError = new Label();
            panel3 = new Panel();
            dgvUser = new DataGridView();
            userName = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Rule = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 50);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 101, 37);
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(190, 25);
            label4.TabIndex = 12;
            label4.Text = "Danh sách tài khoản";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.Red;
            btnXoa.BackgroundColor = Color.Red;
            btnXoa.BorderColor = Color.Red;
            btnXoa.BorderRadius = 5;
            btnXoa.BorderSize = 0;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = Properties.Resources.delete25;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(718, 8);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(0, 0, 12, 0);
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 11;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(238, 101, 37);
            btnThem.BackgroundColor = Color.FromArgb(238, 101, 37);
            btnThem.BackgroundImageLayout = ImageLayout.None;
            btnThem.BorderColor = Color.Orange;
            btnThem.BorderRadius = 5;
            btnThem.BorderSize = 0;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Image = Properties.Resources.addNew25;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(506, 8);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(0, 0, 5, 0);
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.FromArgb(0, 192, 0);
            btnSua.BackgroundColor = Color.FromArgb(0, 192, 0);
            btnSua.BorderColor = Color.Orange;
            btnSua.BorderRadius = 5;
            btnSua.BorderSize = 0;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Image = Properties.Resources.update25;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(612, 8);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(0, 0, 12, 0);
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(tbPw, 1, 0);
            tableLayoutPanel1.Controls.Add(tbUser, 0, 0);
            tableLayoutPanel1.Controls.Add(tbEmail, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 0);
            tableLayoutPanel1.Location = new Point(12, 58);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(806, 75);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbPw
            // 
            tbPw.AllowNull = false;
            tbPw.AllowWhiteSpace = false;
            tbPw.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbPw.BackColor = Color.White;
            tbPw.Error = "";
            tbPw.errorProvider1 = null;
            tbPw.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbPw.Label = "Password";
            tbPw.Location = new Point(203, 5);
            tbPw.Margin = new Padding(2);
            tbPw.MinimumSize = new Size(0, 65);
            tbPw.Multiline = false;
            tbPw.Name = "tbPw";
            tbPw.ReadOnly = false;
            tbPw.Size = new Size(197, 65);
            tbPw.TabIndex = 1;
            tbPw.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.SpecialChar;
            // 
            // tbUser
            // 
            tbUser.AllowNull = false;
            tbUser.AllowWhiteSpace = false;
            tbUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbUser.BackColor = Color.White;
            tbUser.Error = "";
            tbUser.errorProvider1 = null;
            tbUser.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Label = "User Name";
            tbUser.Location = new Point(2, 5);
            tbUser.Margin = new Padding(2);
            tbUser.MinimumSize = new Size(0, 65);
            tbUser.Multiline = false;
            tbUser.Name = "tbUser";
            tbUser.ReadOnly = false;
            tbUser.Size = new Size(197, 65);
            tbUser.TabIndex = 3;
            tbUser.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.NumberAndLetter;
            // 
            // tbEmail
            // 
            tbEmail.AllowNull = true;
            tbEmail.AllowWhiteSpace = false;
            tbEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.BackColor = Color.White;
            tbEmail.Error = "";
            tbEmail.errorProvider1 = null;
            tbEmail.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Label = "Email";
            tbEmail.Location = new Point(404, 5);
            tbEmail.Margin = new Padding(2);
            tbEmail.MinimumSize = new Size(0, 65);
            tbEmail.Multiline = false;
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = false;
            tbEmail.Size = new Size(197, 65);
            tbEmail.TabIndex = 4;
            tbEmail.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.IsValidEmail;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(cbbRule, 0, 1);
            tableLayoutPanel2.Controls.Add(lbError, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(603, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(203, 75);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 11);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 4);
            label1.Size = new Size(43, 19);
            label1.TabIndex = 0;
            label1.Text = "Vai trò";
            // 
            // cbbRule
            // 
            cbbRule.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbbRule.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRule.FormattingEnabled = true;
            cbbRule.Items.AddRange(new object[] { "Quản trị viên", "Kiểm duyệt viên", "Khách" });
            cbbRule.Location = new Point(10, 31);
            cbbRule.Margin = new Padding(10, 0, 10, 0);
            cbbRule.Name = "cbbRule";
            cbbRule.Size = new Size(183, 23);
            cbbRule.TabIndex = 1;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Dock = DockStyle.Top;
            lbError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbError.ForeColor = Color.Firebrick;
            lbError.Location = new Point(10, 56);
            lbError.Margin = new Padding(10, 0, 0, 0);
            lbError.Name = "lbError";
            lbError.Padding = new Padding(0, 0, 0, 4);
            lbError.Size = new Size(193, 19);
            lbError.TabIndex = 0;
            lbError.Visible = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvUser);
            panel3.Location = new Point(12, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(806, 392);
            panel3.TabIndex = 12;
            // 
            // dgvUser
            // 
            dgvUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = Color.Gainsboro;
            dgvUser.BorderStyle = BorderStyle.None;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { userName, password, email, Rule });
            dgvUser.Location = new Point(13, 13);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(780, 365);
            dgvUser.TabIndex = 0;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // userName
            // 
            userName.DataPropertyName = "userName";
            userName.HeaderText = "User Name";
            userName.Name = "userName";
            userName.ReadOnly = true;
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Password";
            password.Name = "password";
            password.ReadOnly = true;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // Rule
            // 
            Rule.DataPropertyName = "Rule";
            Rule.HeaderText = "Vai trò";
            Rule.Name = "Rule";
            Rule.ReadOnly = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(830, 549);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "User";
            Load += UserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Components.Textboxs.TextBoxCustom tbPw;
        private Components.Textboxs.TextBoxCustom tbUser;
        private Label label4;
        private CustomButton btnXoa;
        private CustomButton btnThem;
        private CustomButton btnSua;
        private Panel panel3;
        private DataGridView dgvUser;
        private Components.Textboxs.TextBoxCustom tbEmail;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private ComboBox cbbRule;
        private Label lbError;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Rule;
    }
}