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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnFilter = new CustomButton();
            btnImport = new CustomButton();
            btnXoa = new CustomButton();
            btnExport = new CustomButton();
            btnSua = new CustomButton();
            btnThem = new CustomButton();
            label1 = new Label();
            tbFilter = new TableLayoutPanel();
            tbMaSp = new Components.Textboxs.TextBoxCustom();
            tbTenSp = new Components.Textboxs.TextBoxCustom();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            tbMota = new TextBox();
            tbSoluong = new Components.Textboxs.TextBoxCustom();
            tableLayoutPanel7 = new TableLayoutPanel();
            label8 = new Label();
            cbbTinhTrang = new ComboBox();
            lbError = new Label();
            cbKinhdoanh = new CheckBox();
            tbSearchBox = new Components.Textboxs.TextBoxCustom();
            label3 = new Label();
            cbbPhamvi = new ComboBox();
            panel2 = new Panel();
            dgvSpkd = new DataGridView();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            cbbRule = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label6 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label7 = new Label();
            comboBox2 = new ComboBox();
            pnlInput = new Panel();
            pnlFilter = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            customButton1 = new CustomButton();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tbFilter.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpkd).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlFilter.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 50);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tableLayoutPanel2.Controls.Add(btnFilter, 5, 0);
            tableLayoutPanel2.Controls.Add(btnImport, 0, 0);
            tableLayoutPanel2.Controls.Add(btnXoa, 4, 0);
            tableLayoutPanel2.Controls.Add(btnExport, 1, 0);
            tableLayoutPanel2.Controls.Add(btnSua, 3, 0);
            tableLayoutPanel2.Controls.Add(btnThem, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Right;
            tableLayoutPanel2.Location = new Point(323, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 5, 10, 5);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(507, 50);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Transparent;
            btnFilter.BackgroundColor = Color.Transparent;
            btnFilter.BorderColor = Color.Orange;
            btnFilter.BorderRadius = 0;
            btnFilter.BorderSize = 0;
            btnFilter.Dock = DockStyle.Fill;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.Gray;
            btnFilter.Image = Properties.Resources.filer;
            btnFilter.ImageAlign = ContentAlignment.MiddleLeft;
            btnFilter.Location = new Point(433, 8);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(61, 34);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "Lọc";
            btnFilter.TextAlign = ContentAlignment.MiddleRight;
            btnFilter.TextColor = Color.Gray;
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.Transparent;
            btnImport.BackgroundColor = Color.Transparent;
            btnImport.BorderColor = Color.Orange;
            btnImport.BorderRadius = 0;
            btnImport.BorderSize = 0;
            btnImport.Dock = DockStyle.Fill;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImport.ForeColor = Color.White;
            btnImport.Image = Properties.Resources.import;
            btnImport.Location = new Point(3, 8);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(38, 34);
            btnImport.TabIndex = 0;
            btnImport.TextAlign = ContentAlignment.MiddleRight;
            btnImport.TextColor = Color.White;
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            btnXoa.BackgroundColor = Color.FromArgb(244, 67, 54);
            btnXoa.BorderColor = Color.Orange;
            btnXoa.BorderRadius = 5;
            btnXoa.BorderSize = 0;
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = Properties.Resources.delete25;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(319, 8);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(0, 0, 15, 0);
            btnXoa.Size = new Size(108, 34);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Transparent;
            btnExport.BackgroundColor = Color.Transparent;
            btnExport.BorderColor = Color.Orange;
            btnExport.BorderRadius = 0;
            btnExport.BorderSize = 0;
            btnExport.Dock = DockStyle.Fill;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Image = Properties.Resources.export;
            btnExport.Location = new Point(47, 8);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(38, 34);
            btnExport.TabIndex = 0;
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.TextColor = Color.White;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(89, 206, 143);
            btnSua.BackgroundColor = Color.FromArgb(89, 206, 143);
            btnSua.BorderColor = Color.Orange;
            btnSua.BorderRadius = 5;
            btnSua.BorderSize = 0;
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Image = Properties.Resources.update25;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(205, 8);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(0, 0, 15, 0);
            btnSua.Size = new Size(108, 34);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(238, 101, 37);
            btnThem.BackgroundColor = Color.FromArgb(238, 101, 37);
            btnThem.BorderColor = Color.Orange;
            btnThem.BorderRadius = 5;
            btnThem.BorderSize = 0;
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Image = Properties.Resources.addNew25;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(91, 8);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(0, 0, 5, 0);
            btnThem.Size = new Size(108, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
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
            // tbFilter
            // 
            tbFilter.BackColor = Color.White;
            tbFilter.ColumnCount = 5;
            tbFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tbFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbFilter.Controls.Add(tbMaSp, 0, 0);
            tbFilter.Controls.Add(tbTenSp, 1, 0);
            tbFilter.Controls.Add(tableLayoutPanel3, 3, 0);
            tbFilter.Controls.Add(tbSoluong, 2, 0);
            tbFilter.Controls.Add(tableLayoutPanel7, 4, 0);
            tbFilter.Dock = DockStyle.Left;
            tbFilter.Location = new Point(0, 0);
            tbFilter.MaximumSize = new Size(1900, 73);
            tbFilter.Name = "tbFilter";
            tbFilter.RowCount = 1;
            tbFilter.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tbFilter.Size = new Size(1009, 73);
            tbFilter.TabIndex = 1;
            // 
            // tbMaSp
            // 
            tbMaSp.AllowNull = false;
            tbMaSp.AllowWhiteSpace = true;
            tbMaSp.BackColor = Color.White;
            tbMaSp.Dock = DockStyle.Fill;
            tbMaSp.Error = "";
            tbMaSp.errorProvider1 = null;
            tbMaSp.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaSp.Label = "Mã Sp";
            tbMaSp.Location = new Point(2, 2);
            tbMaSp.Margin = new Padding(2);
            tbMaSp.MinimumSize = new Size(0, 65);
            tbMaSp.Multiline = false;
            tbMaSp.Name = "tbMaSp";
            tbMaSp.ReadOnly = false;
            tbMaSp.Size = new Size(197, 69);
            tbMaSp.TabIndex = 0;
            tbMaSp.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.NumberAndLetter;
            // 
            // tbTenSp
            // 
            tbTenSp.AllowNull = false;
            tbTenSp.AllowWhiteSpace = true;
            tbTenSp.BackColor = Color.White;
            tbTenSp.Dock = DockStyle.Fill;
            tbTenSp.Error = "";
            tbTenSp.errorProvider1 = null;
            tbTenSp.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbTenSp.Label = "Tên Sp";
            tbTenSp.Location = new Point(203, 2);
            tbTenSp.Margin = new Padding(2);
            tbTenSp.MinimumSize = new Size(0, 65);
            tbTenSp.Multiline = false;
            tbTenSp.Name = "tbTenSp";
            tbTenSp.ReadOnly = false;
            tbTenSp.Size = new Size(197, 69);
            tbTenSp.TabIndex = 1;
            tbTenSp.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.NumberAndLetter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(tbMota, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(553, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Size = new Size(252, 73);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 9);
            label4.Margin = new Padding(10, 0, 0, 5);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Mô tả";
            // 
            // tbMota
            // 
            tbMota.Dock = DockStyle.Fill;
            tbMota.Location = new Point(10, 29);
            tbMota.Margin = new Padding(10, 0, 10, 5);
            tbMota.Multiline = true;
            tbMota.Name = "tbMota";
            tbMota.ScrollBars = ScrollBars.Vertical;
            tbMota.Size = new Size(232, 39);
            tbMota.TabIndex = 1;
            // 
            // tbSoluong
            // 
            tbSoluong.AllowNull = false;
            tbSoluong.AllowWhiteSpace = true;
            tbSoluong.BackColor = Color.White;
            tbSoluong.Dock = DockStyle.Fill;
            tbSoluong.Error = "";
            tbSoluong.errorProvider1 = null;
            tbSoluong.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbSoluong.Label = "Số lượng";
            tbSoluong.Location = new Point(404, 2);
            tbSoluong.Margin = new Padding(2);
            tbSoluong.MinimumSize = new Size(0, 65);
            tbSoluong.Multiline = false;
            tbSoluong.Name = "tbSoluong";
            tbSoluong.ReadOnly = false;
            tbSoluong.Size = new Size(147, 69);
            tbSoluong.TabIndex = 2;
            tbSoluong.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.OnlyNumber;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label8, 0, 0);
            tableLayoutPanel7.Controls.Add(cbbTinhTrang, 0, 1);
            tableLayoutPanel7.Controls.Add(lbError, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(805, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.Size = new Size(204, 73);
            tableLayoutPanel7.TabIndex = 6;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 10);
            label8.Margin = new Padding(10, 0, 3, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 0, 4);
            label8.Size = new Size(64, 19);
            label8.TabIndex = 0;
            label8.Text = "Tình trạng";
            // 
            // cbbTinhTrang
            // 
            cbbTinhTrang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbbTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTinhTrang.FormattingEnabled = true;
            cbbTinhTrang.Items.AddRange(new object[] { "Đang kinh doanh", "Ngưng kinh doanh" });
            cbbTinhTrang.Location = new Point(10, 30);
            cbbTinhTrang.Margin = new Padding(10, 0, 10, 0);
            cbbTinhTrang.Name = "cbbTinhTrang";
            cbbTinhTrang.Size = new Size(184, 23);
            cbbTinhTrang.TabIndex = 1;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Dock = DockStyle.Top;
            lbError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbError.ForeColor = Color.Firebrick;
            lbError.Location = new Point(10, 54);
            lbError.Margin = new Padding(10, 0, 0, 0);
            lbError.Name = "lbError";
            lbError.Padding = new Padding(0, 0, 0, 4);
            lbError.Size = new Size(194, 19);
            lbError.TabIndex = 0;
            lbError.Visible = false;
            // 
            // cbKinhdoanh
            // 
            cbKinhdoanh.AutoSize = true;
            cbKinhdoanh.Dock = DockStyle.Fill;
            cbKinhdoanh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbKinhdoanh.Location = new Point(10, 142);
            cbKinhdoanh.Margin = new Padding(10, 0, 10, 0);
            cbKinhdoanh.Name = "cbKinhdoanh";
            cbKinhdoanh.Size = new Size(188, 25);
            cbKinhdoanh.TabIndex = 2;
            cbKinhdoanh.Text = "Đang kinh doanh";
            cbKinhdoanh.UseVisualStyleBackColor = true;
            cbKinhdoanh.CheckedChanged += cbKinhdoanh_CheckedChanged;
            // 
            // tbSearchBox
            // 
            tbSearchBox.AllowNull = true;
            tbSearchBox.AllowWhiteSpace = true;
            tbSearchBox.BackColor = Color.White;
            tbSearchBox.Dock = DockStyle.Fill;
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
            tbSearchBox.Size = new Size(204, 65);
            tbSearchBox.TabIndex = 3;
            tbSearchBox.ValidationType = Components.Textboxs.TextBoxCustom.eValidationType.SpecialChar;
            tbSearchBox.UCTextChanged += textBoxCustom1_UCTextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 67);
            label3.Margin = new Padding(10, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 25);
            label3.TabIndex = 0;
            label3.Text = "Phạm vi tìm kiếm";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbPhamvi
            // 
            cbbPhamvi.Dock = DockStyle.Fill;
            cbbPhamvi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhamvi.FormattingEnabled = true;
            cbbPhamvi.Items.AddRange(new object[] { "Tất cả", "Mã Sp", "Tên Sp", "Số lượng", "Mô tả" });
            cbbPhamvi.Location = new Point(10, 92);
            cbbPhamvi.Margin = new Padding(10, 0, 10, 0);
            cbbPhamvi.Name = "cbbPhamvi";
            cbbPhamvi.Size = new Size(188, 23);
            cbbPhamvi.TabIndex = 1;
            cbbPhamvi.Tag = "";
            cbbPhamvi.SelectedIndexChanged += cbbPhamvi_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvSpkd);
            panel2.Location = new Point(12, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 382);
            panel2.TabIndex = 2;
            // 
            // dgvSpkd
            // 
            dgvSpkd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSpkd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpkd.BackgroundColor = Color.Gainsboro;
            dgvSpkd.BorderStyle = BorderStyle.None;
            dgvSpkd.Location = new Point(13, 13);
            dgvSpkd.Name = "dgvSpkd";
            dgvSpkd.ReadOnly = true;
            dgvSpkd.RowTemplate.Height = 25;
            dgvSpkd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpkd.Size = new Size(780, 356);
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 0);
            label5.Margin = new Padding(10, 0, 3, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 4);
            label5.Size = new Size(43, 19);
            label5.TabIndex = 0;
            label5.Text = "Vai trò";
            // 
            // cbbRule
            // 
            cbbRule.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbbRule.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRule.FormattingEnabled = true;
            cbbRule.Items.AddRange(new object[] { "Quản trị viên", "Kiểm duyệt viên", "Khách" });
            cbbRule.Location = new Point(10, 48);
            cbbRule.Margin = new Padding(10, 0, 10, 0);
            cbbRule.Name = "cbbRule";
            cbbRule.Size = new Size(180, 23);
            cbbRule.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 1);
            label6.Margin = new Padding(10, 0, 3, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 4);
            label6.Size = new Size(43, 19);
            label6.TabIndex = 0;
            label6.Text = "Vai trò";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Quản trị viên", "Kiểm duyệt viên", "Khách" });
            comboBox1.Location = new Point(10, 48);
            comboBox1.Margin = new Padding(10, 0, 10, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label7, 0, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 1);
            label7.Margin = new Padding(10, 0, 3, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 0, 4);
            label7.Size = new Size(43, 19);
            label7.TabIndex = 0;
            label7.Text = "Vai trò";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Quản trị viên", "Kiểm duyệt viên", "Khách" });
            comboBox2.Location = new Point(10, 48);
            comboBox2.Margin = new Padding(10, 0, 10, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 23);
            comboBox2.TabIndex = 1;
            // 
            // pnlInput
            // 
            pnlInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInput.AutoScroll = true;
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(tbFilter);
            pnlInput.Location = new Point(11, 59);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(806, 90);
            pnlInput.TabIndex = 3;
            // 
            // pnlFilter
            // 
            pnlFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlFilter.BackColor = Color.White;
            pnlFilter.BorderStyle = BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(tableLayoutPanel1);
            pnlFilter.Location = new Point(608, 50);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(210, 220);
            pnlFilter.TabIndex = 2;
            pnlFilter.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cbKinhdoanh, 0, 4);
            tableLayoutPanel1.Controls.Add(cbbPhamvi, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(tbSearchBox, 0, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(customButton1, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(208, 218);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(10, 117);
            label9.Margin = new Padding(10, 0, 10, 0);
            label9.Name = "label9";
            label9.Size = new Size(188, 25);
            label9.TabIndex = 0;
            label9.Text = "Tình trạng";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(244, 67, 54);
            customButton1.BackgroundColor = Color.FromArgb(244, 67, 54);
            customButton1.BorderColor = Color.Orange;
            customButton1.BorderRadius = 3;
            customButton1.BorderSize = 0;
            customButton1.Dock = DockStyle.Fill;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Image = Properties.Resources.delete25;
            customButton1.ImageAlign = ContentAlignment.MiddleLeft;
            customButton1.Location = new Point(10, 167);
            customButton1.Margin = new Padding(10, 0, 10, 10);
            customButton1.Name = "customButton1";
            customButton1.Padding = new Padding(3, 0, 0, 0);
            customButton1.Size = new Size(188, 41);
            customButton1.TabIndex = 4;
            customButton1.Text = "Xóa bộ lọc";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += btnClearFilter_Click;
            // 
            // frmSPKD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(830, 549);
            Controls.Add(pnlFilter);
            Controls.Add(pnlInput);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSPKD";
            Text = "frmSPKD";
            Load += frmSPKD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tbFilter.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSpkd).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomButton btnXoa;
        private CustomButton btnSua;
        private CustomButton btnThem;
        private Label label1;
        private TableLayoutPanel tbFilter;
        private Panel panel2;
        private DataGridView dgvSpkd;
        private CheckBox cbKinhdoanh;
        private Components.Textboxs.TextBoxCustom tbSearchBox;
        private CustomButton btnExport;
        private CustomButton btnImport;
        private Label label2;
        private Label label3;
        private ComboBox cbbPhamvi;
        private CustomButton btnFilter;
        private Components.Textboxs.TextBoxCustom tbMaSp;
        private Components.Textboxs.TextBoxCustom tbTenSp;
        private Components.Textboxs.TextBoxCustom tbSoluong;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private TextBox tbMota;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private ComboBox cbbRule;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label6;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label8;
        private ComboBox cbbTinhTrang;
        private Label lbError;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label7;
        private ComboBox comboBox2;
        private Panel pnlInput;
        private Panel pnlFilter;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private CustomButton customButton1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}