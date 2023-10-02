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
using GUI.Components.Textboxs;
using Microsoft.VisualBasic.ApplicationServices;

namespace GUI
{
    public partial class frmSPKD : Form
    {
        List<Dssp>? listDssp;
        public frmSPKD()
        {
            InitializeComponent();
            cbbPhamvi.Text = "Tất cả";
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void frmSPKD_Load(object sender, EventArgs e)
        {
            // cấp quyền truy cập cho từng loại user
            // nếu rule của user là khách thì ẩn các nút thêm xóa sửa, kiểm duyệt viên thì ẩn nút xóa
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
        // import data từ file excel
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                if (op.ShowDialog() == DialogResult.OK)
                {
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
        // export data vào file excel
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

        private void textBoxCustom1_UCTextChanged(object sender, EventArgs e)
        {
            //mỗi khi textbox được gõ thì sẽ gọi hàm filter data lên
            FilterData();
            //if (tbSearchBox.Text != "")
            //{
            //    //check();
            //    FilterData();
            //}

        }
        bool isVisible = true;
        //lọc data dựa theo textbox, checkbox và combobox
        private void FilterData()
        {
            bool checkboxChecked = cbKinhdoanh.Checked;
            string filterText = tbSearchBox.Text;
            // đếm row của datagridview, nếu row lớn hơn 0 thi lọc
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
        #region check
        //private void check()
        //{
        //    bool checkboxChecked = cbKinhdoanh.Checked;
        //    bool check = true;
        //    foreach (DataGridViewRow data in dgvSpkd.Rows)
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {

        //            if ((data.Cells[i].Value.ToString() != "") && data.Cells[i].Value.ToString().Contains(tbSearchBox.Text))
        //            {
        //                check = true; break;
        //            }
        //            else
        //            {
        //                check = false;
        //            }
        //        }
        //        if (check == true)
        //        {
        //            if (checkboxChecked)
        //            {
        //                if (data.Cells[4].Value.ToString().Equals("Đang kinh doanh"))
        //                {
        //                    data.Visible = true;
        //                    break;
        //                }
        //                else
        //                {
        //                    dgvSpkd.CurrentCell = null;
        //                    data.Visible = false;
        //                }
        //            }
        //            else
        //            {
        //                data.Visible = true;
        //                break;
        //            }

        //        }
        //        else
        //        {
        //            dgvSpkd.CurrentCell = null;
        //            data.Visible = false;
        //        }
        //    }
        //}
        #endregion
        private void cbKinhdoanh_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        int cbbFilter;
        private void cbbPhamvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbbValue = cbbPhamvi.Text;
            //gán vị trí item dựa theo tên
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
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filerPanelState();
        }
        // đóng/mở panel filter
        private void filerPanelState()
        {
            if (pnlFilter.Visible == false)
            {
                pnlFilter.Visible = true;
                btnFilter.BackColor = Color.Gainsboro;
            }
            else
            {
                pnlFilter.Visible = false;
                btnFilter.BackColor = Color.Transparent;
            }
        }
        const int WM_PARENTNOTIFY = 0x210;
        const int WM_LBUTTONDOWN = 0x201;
        // đóng panel filter nếu user click chuột ra ngoài panel
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN || (m.Msg == WM_PARENTNOTIFY && (int)m.WParam == WM_LBUTTONDOWN))
            {
                if (pnlFilter.Visible == true)
                {
                    if (!pnlFilter.ClientRectangle.Contains(pnlFilter.PointToClient(Cursor.Position)) && !btnFilter.ClientRectangle.Contains(btnFilter.PointToClient(Cursor.Position)))
                    {
                        filerPanelState();
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            tbSearchBox.Text = "";
            cbbPhamvi.Text = "Tất cả";
            cbKinhdoanh.CheckState = CheckState.Unchecked;
            FilterData();
        }
        private void resetData()
        {
            dgvSpkd.DataSource = null;
        }
        private void clear()
        {
            tbMaSp.Text = null;
            tbTenSp.Text = null;
            tbSoluong.Text = null;
            tbMota.Text = null;
            cbbTinhTrang.SelectedIndex = -1;
            tbMaSp.Error = "";
            tbTenSp.Error = "";
            tbSoluong.Error = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (listDssp != null)
            {
                //tbMaSp.ErrorLable(true);
                //tbTenSp.ErrorLable(true);
                var maSp = listDssp.FirstOrDefault(dssp => dssp.MaSp == tbMaSp.Text);
                var tenSp = listDssp.FirstOrDefault(dssp => dssp.TenSp == tbTenSp.Text);
                if (maSp != null)
                {
                    tbMaSp.Focus();
                    tbMaSp.Error = "Mã sản phẩm đã tồn tại";
                    return;
                }
                else if (tenSp != null)
                {
                    tbTenSp.Focus();
                    tbTenSp.Error = "Tên sản phẩm đã tồn tại";
                    return;
                }
                else
                {
                    Dssp sp = new Dssp();
                    sp.MaSp = tbMaSp.Text;
                    sp.TenSp = tbTenSp.Text;
                    if (tbSoluong.Error == "" && tbSoluong.Text != "" && int.Parse(tbSoluong.Text) >= 0)
                    {
                        sp.SoLuong = int.Parse(tbSoluong.Text);
                    }
                    else
                    {
                        tbSoluong.Error = "Ít nhất bằng 0";
                    }
                    sp.MoTa = tbMota.Text;
                    if (cbbTinhTrang.Text != "")
                    {
                        lbError.Text = "";
                        lbError.Visible = false;
                        sp.TinhTrang = cbbTinhTrang.SelectedItem.ToString();
                    }
                    else
                    {
                        if (tbMaSp.Error == "" && tbTenSp.Error == "") cbbTinhTrang.Focus();
                        lbError.Visible = true;
                        lbError.Text = "Chưa được chọn";
                    }
                    if (tbMaSp.Error == "" && tbTenSp.Error == "" && tbSoluong.Error == "" && lbError.Text == "")
                    {
                        listDssp.Add(sp);
                        resetData();
                        dgvSpkd.DataSource = listDssp;
                        clear();
                    }
                    else
                    {

                        MessageBox.Show("Vui lòng nhập đúng các trường");
                    }
                }

            }
            else
            {
                MessageBox.Show("Chưa load data");
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSpkd.RowCount > 0)
            {
                var sanPham = listDssp.FirstOrDefault(dssp => dssp.MaSp == tbMaSp.Text);
                if (sanPham != null)
                {
                    //ngoại trừ mã sp, các trường khác nếu khác rỗng => thay đổi giá trị, nếu trống => cho phép null, không báo lỗi
                    if (tbMaSp.Error != "")
                    {
                        tbMaSp.Focus();
                    }
                    if (tbTenSp.Text != "")
                    {
                        sanPham.TenSp = tbTenSp.Text;
                    }
                    else
                    {
                        tbTenSp.AllowNull = true;
                    }
                    if (tbSoluong.Text != "")
                    {
                        if (tbSoluong.Error == "") sanPham.SoLuong = int.Parse(tbSoluong.Text);
                    }
                    else
                    {
                        tbSoluong.AllowNull = true;
                    }
                    sanPham.MoTa = tbMota.Text;
                    if (cbbTinhTrang.Text != "")
                    {
                        sanPham.TinhTrang = cbbTinhTrang.SelectedItem.ToString();
                    }
                    else
                    {
                        lbError.Text = "";
                    }
                    if (tbTenSp.Text == "" && tbSoluong.Text == "" && cbbTinhTrang.Text == "" && tbMota.Text == "")
                    {
                        MessageBox.Show("Chưa nhập giá trị");
                        return;
                    }
                    if (tbMaSp.Error == "" && tbTenSp.Error == "" && tbSoluong.Error == "" && lbError.Text == "")
                    {
                        resetData();
                        dgvSpkd.DataSource = listDssp;
                        clear();
                        tbTenSp.AllowNull = false;
                        tbSoluong.AllowNull = false;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng các trường");
                    }
                }
                else
                {
                    tbMaSp.Focus();
                    tbMaSp.Error = "Mã sp không tồn tại";
                }
            }
            else
            {
                MessageBox.Show("Chưa load data");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSpkd.RowCount > 0)
            {
                var sanPham = listDssp.FirstOrDefault(dssp => dssp.MaSp == tbMaSp.Text);
                if (sanPham != null)
                {
                    listDssp.Remove(sanPham);
                    resetData();
                    dgvSpkd.DataSource = listDssp;
                }
                else
                {
                    tbMaSp.Error = "Mã sp không tồn tại";
                }
            }
            else
            {
                MessageBox.Show("Chưa load data");
            }
        }

        private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTinhTrang.SelectedIndex != -1) lbError.Text = null;
        }

        private void dgvSpkd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            //kiểm tra nếu textboxUser trống hoặc có value khác với value của cellClick => fill value từ cellClick vào textbox
            //nếu khác thì làm trống textbox => mục đích khi ngươi dùng nhấn vào cùng 1 cell lần đầu thì fill value, lần 2 sẽ clear value
            DataGridViewRow row = dgvSpkd.Rows[e.RowIndex];
            if (!tbMaSp.Text.Equals(row.Cells[0].Value.ToString()) || tbMaSp.Text == "")
            {
                //gán value từ cell vào textbox
                tbMaSp.Text = row.Cells[0].Value.ToString();
                tbTenSp.Text = row.Cells[1].Value.ToString();
                tbSoluong.Text = row.Cells[2].Value.ToString();
                //nếu cell[3] có value khác rỗng, gán value vào textbox mô tả
                if (row.Cells[3].Value != null)
                {
                    tbMota.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    tbMota.Text = "";
                }
                cbbTinhTrang.Text = row.Cells[4].Value.ToString();
            }
            else
            {
                dgvSpkd.FirstDisplayedCell = null;
                dgvSpkd.ClearSelection();
                clear();
            }
        }
    }
}
