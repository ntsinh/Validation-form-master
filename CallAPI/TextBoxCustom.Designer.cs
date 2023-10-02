namespace GUI.Components.Textboxs
{
    partial class TextBoxCustom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel = new TableLayoutPanel();
            label = new Label();
            lblError = new Label();
            txt = new TextBox();
            errorProvider = new ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(label, 0, 0);
            tableLayoutPanel.Controls.Add(lblError, 0, 2);
            tableLayoutPanel.Controls.Add(txt, 0, 1);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(4, 5, 4, 5);
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel.Size = new Size(214, 65);
            tableLayoutPanel.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.FlatStyle = FlatStyle.Flat;
            label.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label.ImageAlign = ContentAlignment.MiddleRight;
            label.Location = new Point(6, 5);
            label.Margin = new Padding(2, 0, 2, 0);
            label.Name = "label";
            label.Size = new Size(33, 17);
            label.TabIndex = 0;
            label.Text = "Title";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(7, 50);
            lblError.Name = "lblError";
            lblError.Size = new Size(39, 15);
            lblError.TabIndex = 1;
            lblError.Text = "label2";
            // 
            // txt
            // 
            txt.BackColor = Color.White;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Dock = DockStyle.Fill;
            txt.Location = new Point(7, 27);
            txt.Name = "txt";
            txt.Size = new Size(200, 22);
            txt.TabIndex = 2;
            txt.TextChanged += txt_TextChanged;
            txt.KeyPress += Txt_KeyPress;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // TextBoxCustom
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel);
            DoubleBuffered = true;
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2);
            MinimumSize = new Size(0, 65);
            Name = "TextBoxCustom";
            Size = new Size(214, 65);
            Load += TextBoxCustom_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel;
        private Label lblError;
        private Label label;
        private ErrorProvider errorProvider;
        private TextBox txt;
        private System.Windows.Forms.Timer timer1;
    }
}
