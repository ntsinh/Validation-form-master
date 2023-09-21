using CallAPI;
using System;
using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using BLL;
using Newtonsoft.Json;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace GUI
{
    public partial class frmSPKD : Form
    {
        List<Dssp>? listDssp;
        public frmSPKD()
        {
            InitializeComponent();
            cbbPhamvi.Text = "Tất cả";
        }
        int cbbFilter;
        private void frmSPKD_Load(object sender, EventArgs e)
        {
            if (Program.rule.Equals("Khách"))
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            if (Program.rule.Equals("Kiểm duyệt viên"))
            {
                btnXoa.Enabled = false;
            }

        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    //DataTable dt = new DataTable();
                    string filePath = op.FileName;
                    ApiBLL apiBLL = new ApiBLL();
                    var data = apiBLL.ReadExcelFileForGUI(filePath);
                    listDssp = (List<Dssp>)data;
                    dgvSpkd.DataSource = listDssp;
                    dgvSpkd.Columns[0].HeaderText = "Mã Sp";
                    dgvSpkd.Columns[1].HeaderText = "Tên Sp";
                    dgvSpkd.Columns[2].HeaderText = "Số lượng";
                    dgvSpkd.Columns[3].HeaderText = "Mô tả";
                    dgvSpkd.Columns[4].HeaderText = "Tình trạng";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Trường dữ liệu của file không hợp lệ");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvSpkd.RowCount > 0)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sf.FileName;
                    FileInfo f = new FileInfo(filePath);
                    if (f.Exists) f.Delete();
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (ExcelPackage ep = new ExcelPackage(f))
                    {
                        ExcelWorksheet sheet = ep.Workbook.Worksheets.Add("Sheet1");
                        sheet.Cells[1, 1].Value = "Mã Sp";
                        sheet.Cells[1, 2].Value = "Tên Sp";
                        sheet.Cells[1, 3].Value = "Số lượng";
                        sheet.Cells[1, 4].Value = "Mô tả";
                        sheet.Cells[1, 5].Value = "Tình trạng";
                        int i = 2;
                        foreach (DataGridViewRow row in dgvSpkd.Rows)
                        {
                            if (row.Visible == true)
                            {
                                sheet.Cells[i, 1].Value = row.Cells[0].Value.ToString();
                                sheet.Cells[i, 2].Value = row.Cells[1].Value.ToString();
                                sheet.Cells[i, 3].Value = row.Cells[2].Value.ToString();
                                sheet.Cells[i, 4].Value = row.Cells[3].Value.ToString();
                                sheet.Cells[i, 5].Value = row.Cells[4].Value.ToString();
                                i++;
                            }
                        }
                        ep.Save();
                        MessageBox.Show("Hoàn tất !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để export");
            }
        }
        private void saveJson()
        {
            var UserlistJson = JsonConvert.SerializeObject(listDssp);
            string fileName = @"D:\WinForm\Validation-form-master\UserList.json";
            if (File.Exists(fileName) == false)
            {
                File.WriteAllText(fileName, UserlistJson);
            }
            else
            {
                File.Delete(fileName);
                File.WriteAllText(fileName, UserlistJson);
            }
        }

        private void textBoxCustom1_UCTextChanged(object sender, EventArgs e)
        {

            if (tbSearchBox.Text != null)
            {
                //check();
                FilterData();
            }

        }
        bool isVisible = true;
        private void FilterData()
        {

            bool checkboxChecked = cbKinhdoanh.Checked;
            string filterText = tbSearchBox.Text;

            if (dgvSpkd.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvSpkd.Rows)
                {


                    if (cbbPhamvi.Text == "Tất cả")
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string cellValue = cell.Value == null ? string.Empty : cell.Value.ToString();

                            if ((filterText != "") && !(cellValue.Contains(filterText)))
                            {
                                dgvSpkd.CurrentCell = null;
                                isVisible = false;
                            }
                            else
                            {
                                if (checkboxChecked)
                                {
                                    if (row.Cells[4].Value.ToString().Equals("Đang kinh doanh"))
                                    {
                                        isVisible = true;
                                        break;
                                    }
                                    else
                                    {
                                        dgvSpkd.CurrentCell = null;
                                        isVisible = false;
                                    }
                                }
                                else
                                {
                                    isVisible = true;
                                    break;
                                }
                            }
                        }
                        row.Visible = isVisible;
                    }
                    else
                    {
                        string cellValue = row.Cells[cbbFilter].Value == null ? string.Empty : row.Cells[cbbFilter].Value.ToString();

                        if ((filterText != "") && !(cellValue.Contains(filterText)))
                        {
                            dgvSpkd.CurrentCell = null;
                            isVisible = false;
                        }
                        else
                        {
                            if (checkboxChecked)
                            {
                                if (row.Cells[4].Value.ToString().Equals("Đang kinh doanh"))
                                {
                                    isVisible = true;
                                }
                                else
                                {
                                    dgvSpkd.CurrentCell = null;
                                    isVisible = false;
                                }
                            }
                            else
                            {
                                isVisible = true;
                            }
                        }
                        row.Visible = isVisible;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu");
            }
        }
        private void check()
        {
            bool checkboxChecked = cbKinhdoanh.Checked;
            bool check = true;
            foreach (DataGridViewRow data in dgvSpkd.Rows)
            {
                for (int i = 0; i < 5; i++)
                {

                    if ((data.Cells[i].Value.ToString() != "") && data.Cells[i].Value.ToString().Contains(tbSearchBox.Text))
                    {
                        check = true; break;
                    }
                    else
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    if (checkboxChecked)
                    {
                        if (data.Cells[4].Value.ToString().Equals("Đang kinh doanh"))
                        {
                            data.Visible = true;
                            break;
                        }
                        else
                        {
                            dgvSpkd.CurrentCell = null;
                            data.Visible = false;
                        }
                    }
                    else
                    {
                        data.Visible = true;
                        break;
                    }

                }
                else
                {
                    dgvSpkd.CurrentCell = null;
                    data.Visible = false;
                }
            }
        }

        private void cbKinhdoanh_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbKinhdoanh.Checked)
            //{
            //    if (data.Cells[4].Value.ToString().Equals("Đang kinh doanh"))
            //    {
            //        data.Visible = true;
            //    }
            //    else
            //    {
            //        data.Visible = false;
            //    }
            //}
            //else
            //{
            //    data.Visible = true;
            //}
            FilterData();
            //check();
        }

        private void cbbPhamvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbbValue = cbbPhamvi.Text;
            switch (cbbValue)
            {
                case "Mã Sp":
                    cbbFilter = 0;
                    break;
                case "Tên Sp":
                    cbbFilter = 1;
                    break;
                case "Số lượng":
                    cbbFilter = 2;
                    break;
                case "Mô tả":
                    cbbFilter = 3;
                    break;
            }
            if (tbSearchBox.Text != "")
            {
                FilterData();
            }
        }
    }
}
