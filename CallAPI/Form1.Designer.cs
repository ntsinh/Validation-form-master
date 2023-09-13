namespace CallAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvKho = new DataGridView();
            maKhoXuat = new DataGridViewTextBoxColumn();
            tenKhoXuat = new DataGridViewTextBoxColumn();
            moTa = new DataGridViewTextBoxColumn();
            lbMaKhoLog = new Label();
            lbTenKhoLog = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            btnXoa = new GUI.CustomButton();
            btnThem = new GUI.CustomButton();
            btnSua = new GUI.CustomButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTenKho = new GUI.Components.Textboxs.TextBoxCustom();
            txtMoTa = new GUI.Components.Textboxs.TextBoxCustom();
            txtMaKho = new GUI.Components.Textboxs.TextBoxCustom();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKho
            // 
            dgvKho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKho.BackgroundColor = Color.Gainsboro;
            dgvKho.BorderStyle = BorderStyle.None;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { maKhoXuat, tenKhoXuat, moTa });
            dgvKho.Location = new Point(13, 13);
            dgvKho.Name = "dgvKho";
            dgvKho.ReadOnly = true;
            dgvKho.RowTemplate.Height = 25;
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.Size = new Size(764, 361);
            dgvKho.TabIndex = 0;
            dgvKho.CellClick += dgvKho_CellClick;
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
            // lbMaKhoLog
            // 
            lbMaKhoLog.AutoSize = true;
            lbMaKhoLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMaKhoLog.ForeColor = Color.Red;
            lbMaKhoLog.Location = new Point(17, 63);
            lbMaKhoLog.Name = "lbMaKhoLog";
            lbMaKhoLog.Size = new Size(0, 21);
            lbMaKhoLog.TabIndex = 4;
            // 
            // lbTenKhoLog
            // 
            lbTenKhoLog.AutoSize = true;
            lbTenKhoLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTenKhoLog.ForeColor = Color.Red;
            lbTenKhoLog.Location = new Point(18, 151);
            lbTenKhoLog.Name = "lbTenKhoLog";
            lbTenKhoLog.Size = new Size(0, 21);
            lbTenKhoLog.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvKho);
            panel3.Location = new Point(12, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(790, 388);
            panel3.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnSua);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(814, 50);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 101, 37);
            label4.Location = new Point(11, 10);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 8;
            label4.Text = "Kho hàng xuất";
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
            btnXoa.Image = GUI.Properties.Resources.delete25;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(703, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(0, 0, 12, 0);
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 7;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
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
            btnThem.Image = GUI.Properties.Resources.addNew25;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(491, 6);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(0, 0, 5, 0);
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
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
            btnSua.Image = GUI.Properties.Resources.update25;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(597, 6);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(0, 0, 12, 0);
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tableLayoutPanel1.Controls.Add(txtTenKho, 1, 0);
            tableLayoutPanel1.Controls.Add(txtMoTa, 2, 0);
            tableLayoutPanel1.Controls.Add(txtMaKho, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 58);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(790, 75);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // txtTenKho
            // 
            txtTenKho.AllowNull = true;
            txtTenKho.AllowWhiteSpace = true;
            txtTenKho.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenKho.BackColor = Color.White;
            txtTenKho.Error = "";
            txtTenKho.errorProvider1 = null;
            txtTenKho.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKho.Label = "Tên kho xuất";
            txtTenKho.Location = new Point(215, 5);
            txtTenKho.Margin = new Padding(2);
            txtTenKho.MinimumSize = new Size(0, 65);
            txtTenKho.Multiline = false;
            txtTenKho.Name = "txtTenKho";
            txtTenKho.ReadOnly = false;
            txtTenKho.Size = new Size(209, 65);
            txtTenKho.TabIndex = 1;
            txtTenKho.ValidationType = GUI.Components.Textboxs.TextBoxCustom.eValidationType.SpecialChar;
            // 
            // txtMoTa
            // 
            txtMoTa.AllowNull = true;
            txtMoTa.AllowWhiteSpace = true;
            txtMoTa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMoTa.BackColor = Color.White;
            txtMoTa.Error = "";
            txtMoTa.errorProvider1 = null;
            txtMoTa.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoTa.Label = "Mô tả";
            txtMoTa.Location = new Point(428, 5);
            txtMoTa.Margin = new Padding(2);
            txtMoTa.MinimumSize = new Size(0, 65);
            txtMoTa.Multiline = false;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ReadOnly = false;
            txtMoTa.Size = new Size(360, 65);
            txtMoTa.TabIndex = 2;
            txtMoTa.ValidationType = GUI.Components.Textboxs.TextBoxCustom.eValidationType.SpecialChar;
            // 
            // txtMaKho
            // 
            txtMaKho.AllowNull = true;
            txtMaKho.AllowWhiteSpace = true;
            txtMaKho.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaKho.BackColor = Color.White;
            txtMaKho.Error = "";
            txtMaKho.errorProvider1 = null;
            txtMaKho.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKho.Label = "Mã kho xuất";
            txtMaKho.Location = new Point(2, 5);
            txtMaKho.Margin = new Padding(2);
            txtMaKho.MinimumSize = new Size(0, 65);
            txtMaKho.Multiline = false;
            txtMaKho.Name = "txtMaKho";
            txtMaKho.ReadOnly = false;
            txtMaKho.Size = new Size(209, 65);
            txtMaKho.TabIndex = 0;
            txtMaKho.ValidationType = GUI.Components.Textboxs.TextBoxCustom.eValidationType.SpecialChar;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(814, 545);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(lbTenKhoLog);
            Controls.Add(lbMaKhoLog);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKho;
        private Label lbMaKhoLog;
        private Label lbTenKhoLog;
        private Panel panel3;
        private DataGridViewTextBoxColumn maKhoXuat;
        private DataGridViewTextBoxColumn tenKhoXuat;
        private DataGridViewTextBoxColumn moTa;
        private Panel panel2;
        private Label label4;
        private GUI.CustomButton btnXoa;
        private GUI.CustomButton btnThem;
        private GUI.CustomButton btnSua;
        private TableLayoutPanel tableLayoutPanel1;
        private GUI.Components.Textboxs.TextBoxCustom txtMaKho;
        private GUI.Components.Textboxs.TextBoxCustom txtTenKho;
        private GUI.Components.Textboxs.TextBoxCustom txtMoTa;
    }
}