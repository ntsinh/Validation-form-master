namespace GUI
{
    partial class frmSPKD
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
            label1 = new Label();
            btnThem = new CustomButton();
            btnSua = new CustomButton();
            btnXoa = new CustomButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            textBoxCustom1 = new Components.Textboxs.TextBoxCustom();
            textBoxCustom2 = new Components.Textboxs.TextBoxCustom();
            panel2 = new Panel();
            dgvSpkd = new DataGridView();
            maKhoXuat = new DataGridViewTextBoxColumn();
            tenKhoXuat = new DataGridViewTextBoxColumn();
            moTa = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpkd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(238, 101, 37);
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 1;
            label1.Text = "Sản phẩm kinh doanh";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(238, 101, 37);
            btnThem.BackgroundColor = Color.FromArgb(238, 101, 37);
            btnThem.BorderColor = Color.Orange;
            btnThem.BorderRadius = 5;
            btnThem.BorderSize = 0;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Image = Properties.Resources.addNew25;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(491, 6);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(0, 0, 5, 0);
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += customButton1_Click;
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
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Image = Properties.Resources.update25;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(597, 6);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(0, 0, 15, 0);
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += customButton1_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.Red;
            btnXoa.BackgroundColor = Color.Red;
            btnXoa.BorderColor = Color.Orange;
            btnXoa.BorderRadius = 5;
            btnXoa.BorderSize = 0;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = Properties.Resources.delete25;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(703, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(0, 0, 15, 0);
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += customButton1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tableLayoutPanel1.Controls.Add(checkBox1, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxCustom1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxCustom2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(790, 70);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(429, 15);
            checkBox1.Margin = new Padding(3, 15, 3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 52);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Đang kinh doanh";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxCustom1
            // 
            textBoxCustom1.AllowNull = true;
            textBoxCustom1.AllowWhiteSpace = true;
            textBoxCustom1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCustom1.BackColor = Color.White;
            textBoxCustom1.Error = "";
            textBoxCustom1.errorProvider1 = null;
            textBoxCustom1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCustom1.Label = "Nội dung tìm kiếm";
            textBoxCustom1.Location = new Point(2, 2);
            textBoxCustom1.Margin = new Padding(2);
            textBoxCustom1.MinimumSize = new Size(0, 65);
            textBoxCustom1.Multiline = false;
            textBoxCustom1.Name = "textBoxCustom1";
            textBoxCustom1.ReadOnly = false;
            textBoxCustom1.Size = new Size(209, 65);
            textBoxCustom1.TabIndex = 3;
            textBoxCustom1.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.SpecialChar;
            // 
            // textBoxCustom2
            // 
            textBoxCustom2.AllowNull = true;
            textBoxCustom2.AllowWhiteSpace = true;
            textBoxCustom2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCustom2.BackColor = Color.White;
            textBoxCustom2.Error = "";
            textBoxCustom2.errorProvider1 = null;
            textBoxCustom2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCustom2.Label = "Phạm vi tìm kiếm";
            textBoxCustom2.Location = new Point(215, 2);
            textBoxCustom2.Margin = new Padding(2);
            textBoxCustom2.MinimumSize = new Size(0, 65);
            textBoxCustom2.Multiline = false;
            textBoxCustom2.Name = "textBoxCustom2";
            textBoxCustom2.ReadOnly = false;
            textBoxCustom2.Size = new Size(209, 65);
            textBoxCustom2.TabIndex = 4;
            textBoxCustom2.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.SpecialChar;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvSpkd);
            panel2.Location = new Point(12, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(790, 401);
            panel2.TabIndex = 2;
            // 
            // dgvSpkd
            // 
            dgvSpkd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSpkd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpkd.BackgroundColor = Color.Gainsboro;
            dgvSpkd.BorderStyle = BorderStyle.None;
            dgvSpkd.Columns.AddRange(new DataGridViewColumn[] { maKhoXuat, tenKhoXuat, moTa });
            dgvSpkd.Location = new Point(13, 14);
            dgvSpkd.Name = "dgvSpkd";
            dgvSpkd.ReadOnly = true;
            dgvSpkd.RowTemplate.Height = 25;
            dgvSpkd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpkd.Size = new Size(764, 375);
            dgvSpkd.TabIndex = 1;
            // 
            // maKhoXuat
            // 
            maKhoXuat.DataPropertyName = "maKhoXuat";
            maKhoXuat.HeaderText = "Mã Kho Xuất";
            maKhoXuat.Name = "maKhoXuat";
            maKhoXuat.ReadOnly = true;
            // 
            // tenKhoXuat
            // 
            tenKhoXuat.DataPropertyName = "tenKhoXuat";
            tenKhoXuat.HeaderText = "Tên Kho Xuất";
            tenKhoXuat.Name = "tenKhoXuat";
            tenKhoXuat.ReadOnly = true;
            // 
            // moTa
            // 
            moTa.DataPropertyName = "moTa";
            moTa.HeaderText = "Mô Tả";
            moTa.Name = "moTa";
            moTa.ReadOnly = true;
            // 
            // frmSPKD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(814, 545);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSPKD";
            Text = "frmSPKD";
            Load += frmSPKD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSpkd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomButton btnXoa;
        private CustomButton btnSua;
        private CustomButton btnThem;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private DataGridView dgvSpkd;
        private DataGridViewTextBoxColumn maKhoXuat;
        private DataGridViewTextBoxColumn tenKhoXuat;
        private DataGridViewTextBoxColumn moTa;
        private CheckBox checkBox1;
        private Components.Textboxs.TextBoxCustom textBoxCustom1;
        private Components.Textboxs.TextBoxCustom textBoxCustom2;
    }
}