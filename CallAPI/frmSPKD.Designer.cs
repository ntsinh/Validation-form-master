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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            btnImport = new CustomButton();
            btnExport = new CustomButton();
            btnThem = new CustomButton();
            btnSua = new CustomButton();
            btnXoa = new CustomButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbKinhdoanh = new CheckBox();
            tbSearchBox = new Components.Textboxs.TextBoxCustom();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            cbbPhamvi = new ComboBox();
            dsspBindingSource = new BindingSource(components);
            panel2 = new Panel();
            dgvSpkd = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsspBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpkd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 50);
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
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.BackColor = Color.Transparent;
            btnImport.BackgroundColor = Color.Transparent;
            btnImport.BorderColor = Color.Orange;
            btnImport.BorderRadius = 0;
            btnImport.BorderSize = 0;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImport.ForeColor = Color.White;
            btnImport.Image = Properties.Resources.import;
            btnImport.ImageAlign = ContentAlignment.MiddleLeft;
            btnImport.Location = new Point(380, 7);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(40, 35);
            btnImport.TabIndex = 0;
            btnImport.TextAlign = ContentAlignment.MiddleRight;
            btnImport.TextColor = Color.White;
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.Transparent;
            btnExport.BackgroundColor = Color.Transparent;
            btnExport.BorderColor = Color.Orange;
            btnExport.BorderRadius = 0;
            btnExport.BorderSize = 0;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Image = Properties.Resources.export;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(426, 7);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(40, 35);
            btnExport.TabIndex = 0;
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.TextColor = Color.White;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
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
            btnThem.Location = new Point(507, 6);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(0, 0, 5, 0);
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
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
            btnSua.Location = new Point(613, 6);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(0, 0, 15, 0);
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
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
            btnXoa.Location = new Point(719, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(0, 0, 15, 0);
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tableLayoutPanel1.Controls.Add(cbKinhdoanh, 2, 0);
            tableLayoutPanel1.Controls.Add(tbSearchBox, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(806, 70);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // cbKinhdoanh
            // 
            cbKinhdoanh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbKinhdoanh.AutoSize = true;
            cbKinhdoanh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbKinhdoanh.Location = new Point(444, 15);
            cbKinhdoanh.Margin = new Padding(10, 15, 3, 3);
            cbKinhdoanh.Name = "cbKinhdoanh";
            cbKinhdoanh.Size = new Size(118, 52);
            cbKinhdoanh.TabIndex = 2;
            cbKinhdoanh.Text = "Đang kinh doanh";
            cbKinhdoanh.UseVisualStyleBackColor = true;
            cbKinhdoanh.CheckedChanged += cbKinhdoanh_CheckedChanged;
            // 
            // tbSearchBox
            // 
            tbSearchBox.AllowNull = true;
            tbSearchBox.AllowWhiteSpace = true;
            tbSearchBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSearchBox.BackColor = Color.White;
            tbSearchBox.Error = "";
            tbSearchBox.errorProvider1 = null;
            tbSearchBox.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchBox.Label = "Nội dung tìm kiếm";
            tbSearchBox.Location = new Point(2, 2);
            tbSearchBox.Margin = new Padding(2);
            tbSearchBox.MinimumSize = new Size(0, 65);
            tbSearchBox.Multiline = false;
            tbSearchBox.Name = "tbSearchBox";
            tbSearchBox.ReadOnly = false;
            tbSearchBox.Size = new Size(213, 65);
            tbSearchBox.TabIndex = 3;
            tbSearchBox.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.SpecialChar;
            tbSearchBox.UCTextChanged += textBoxCustom1_UCTextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(cbbPhamvi, 0, 1);
            tableLayoutPanel2.Location = new Point(220, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(211, 64);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 5);
            label3.Margin = new Padding(10, 0, 0, 5);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 0;
            label3.Text = "Phạm vi tìm kiếm";
            // 
            // cbbPhamvi
            // 
            cbbPhamvi.Dock = DockStyle.Fill;
            cbbPhamvi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhamvi.FormattingEnabled = true;
            cbbPhamvi.Items.AddRange(new object[] { "Tất cả", "Mã Sp", "Tên Sp", "Số lượng", "Mô tả" });
            cbbPhamvi.Location = new Point(10, 25);
            cbbPhamvi.Margin = new Padding(10, 0, 10, 0);
            cbbPhamvi.Name = "cbbPhamvi";
            cbbPhamvi.Size = new Size(191, 23);
            cbbPhamvi.TabIndex = 1;
            cbbPhamvi.Tag = "";
            cbbPhamvi.SelectedIndexChanged += cbbPhamvi_SelectedIndexChanged;
            // 
            // dsspBindingSource
            // 
            dsspBindingSource.DataSource = typeof(DTO.Dssp);
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvSpkd);
            panel2.Location = new Point(12, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 405);
            panel2.TabIndex = 2;
            // 
            // dgvSpkd
            // 
            dgvSpkd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSpkd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpkd.BackgroundColor = Color.Gainsboro;
            dgvSpkd.BorderStyle = BorderStyle.None;
            dgvSpkd.Location = new Point(13, 14);
            dgvSpkd.Name = "dgvSpkd";
            dgvSpkd.ReadOnly = true;
            dgvSpkd.RowTemplate.Height = 25;
            dgvSpkd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpkd.Size = new Size(780, 379);
            dgvSpkd.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(51, 0);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmSPKD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(830, 549);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dsspBindingSource).EndInit();
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
        private CheckBox cbKinhdoanh;
        private Components.Textboxs.TextBoxCustom tbSearchBox;
        private CustomButton btnExport;
        private CustomButton btnImport;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private ComboBox cbbPhamvi;
        private BindingSource dsspBindingSource;
    }
}