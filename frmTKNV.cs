using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace btlquanlycuahanginternet
{
    public partial class frmTKNV : Form
    {
        DataTable tableNhanVien;
        public frmTKNV()
        {
            InitializeComponent();
        }

        private void frmTKNV_Load(object sender, EventArgs e)
        {
            Class. functions.Connect();
            loadDataGridview();
            cbomaca.Items.Add("01");
            cbomaca.Items.Add("02");
            cbomaca.Items.Add("03");
        }
        private void loadDataGridview()
        {
            string sql;
            sql = "select *from NhanVien";
            tableNhanVien = Class.functions.GetDataToTable(sql);
            dataGridView_TKNV.DataSource = tableNhanVien;

        }

        private void dataGridView_TKNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdiachi.Text = dataGridView_TKNV.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtgioitinh.Text = dataGridView_TKNV.CurrentRow.Cells["GioiTinh"].Value.ToString();
            cbomaca.Text = dataGridView_TKNV.CurrentRow.Cells["MaCa"].Value.ToString();
            txtmanv.Text = dataGridView_TKNV.CurrentRow.Cells["MaNV"].Value.ToString();
            msknamsinh.Text = dataGridView_TKNV.CurrentRow.Cells["NamSinh"].Value.ToString();
            txtsdt.Text = dataGridView_TKNV.CurrentRow.Cells["SDT"].Value.ToString();
            txttennv.Text = dataGridView_TKNV.CurrentRow.Cells["TenNV"].Value.ToString();
            txtmanv.Enabled = false;
        }
        private void resetvalues()
        {
            txtdiachi.Text = "";
            txtgioitinh.Text = "";
            msknamsinh.Text = "";
            txtmanv.Text = "";
            txtsdt.Text = "";
            txttennv.Text = "";
            cbomaca.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            resetvalues();
            txtmanv.Enabled = true;
            txtmanv.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmanv.Text == "")
            {
                MessageBox.Show(" bạn cần nhập mã nhân viên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show(" Bạn cần nhập tên nhân viên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show(" bạn cần nhập địa chỉ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                txtdiachi.Focus();
                return;
            }
            if (txtgioitinh.Text == "")
            {
                MessageBox.Show(" bạn cần nhập giới tính", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgioitinh.Focus();
                return;
            }
            if (cbomaca.Text == "")
            {
                MessageBox.Show(" bạn cần nhập mã ca", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaca.Focus();
                return;
            }
            if (msknamsinh.Text == "")
            {
                MessageBox.Show(" bạn cần nhập năm sinh", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msknamsinh.Focus();
                return;

            }
            if (txtsdt.Text == "")
            {
                MessageBox.Show("bạn cần nhập sdt", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsdt.Focus();
                return;
            }
            sql = "select  *from NhanVien where MaNV='" + txtmanv.Text + "'";
            if (Class.functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã này đã có, hãy nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                txtmanv.Text = "";
                return;
            }
            sql = "insert into NhanVien values('" + txtmanv.Text + "','" + txttennv.Text + "','" +
                cbomaca.Text + "','" + Class.functions.ConvertDateTime(msknamsinh.Text) + "','" +
                txtgioitinh.Text + "','" + txtdiachi.Text + "','" + txtsdt.Text + "'";
            sql = sql + ")";          
            Class.functions.RunSQL(sql);
            loadDataGridview();
            resetvalues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tableNhanVien.Rows.Count == 0)
            {
                MessageBox.Show(" không còn dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (txtmanv.Text == "")
            {
                MessageBox.Show(" bạn chưa chọn bản ghi nào", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string sql = "delete from NhanVien where manv= '" + txtmanv.Text + "'";
            Class.functions.RunSQL(sql);
            loadDataGridview();
            resetvalues();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tableNhanVien.Rows.Count == 0)
            {
                MessageBox.Show(" không còn dữ liệu", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show(" bạn chưa chọn bản ghi nào", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show(" bạn cần nhập tên nhân viên", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }
            if (cbomaca.Text == "")
            {
                MessageBox.Show(" bạn cần nhập mã ca", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaca.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show(" bạn cần nhập địa chỉ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (txtgioitinh.Text == "")
            {
                MessageBox.Show(" bạn cần nhập giới tính", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgioitinh.Focus();
                return;
            }
            if (msknamsinh.Text == "")
            {
                MessageBox.Show(" bạn cần nhập năm sinh", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msknamsinh.Focus();
                return;

            }
            if (txtsdt.Text == "")
            {
                MessageBox.Show(" bạn cần nhập sdt", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsdt.Focus();
                return;
            }
            string sql = " update NhanVien set TenNV='" + txttennv.Text + "',MaCa='" + cbomaca.Text +
          "', NamSinh= '" + Class.functions.ConvertDateTime(msknamsinh.Text) + "', GioiTinh='" + txtgioitinh.Text + "'" +
          ", DiaChi= '" + txtdiachi.Text + "',SDT='" + txtsdt.Text + "' where MaNV='" + txtmanv.Text + "' ";        
            Class.functions.RunSQL(sql);
            loadDataGridview();
            resetvalues();

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnhuy.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
          
            Class.functions.DisConnect();
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txttennv.Text == "") && (cbomaca.Text == "") && (txtgioitinh.Text == ""))
            {
                MessageBox.Show("hãy nhập điều kiện tìm kiếm", "yêu cầu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select *from NhanVien where 1=1";
            if (txttennv.Text != "") sql = sql + "and TenNV Like '%" + txttennv.Text + "%'";
            if (cbomaca.Text != "") sql = sql + "and MaCa Like '%" + cbomaca.Text + "%'";
            if (txtgioitinh.Text != "") sql = sql + "and GioiTinh Like '%" + txtgioitinh.Text + "%'";
            tableNhanVien = Class.functions.GetDataToTable(sql);
            if (tableNhanVien.Rows.Count == 0)
                MessageBox.Show("không có bản ghi nào thảo mãn điều kiện",
                    "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("có" + tableNhanVien.Rows.Count + "bản ghi thỏa mã điều kiện",
                    "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            tableNhanVien = Class.functions.GetDataToTable(sql);
            dataGridView_TKNV.DataSource = tableNhanVien;
            
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)||(Convert.ToInt32(e.KeyChar) == 13))

            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            int nv = 0, cot = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa Hàng Internet03";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Tien Du - Bac Ninh";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)39641582";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "Danh Sách Nhân Viên";
            //Tạo dòng tiêu đề bảng
            exRange.Range["A6:H6"].Font.Bold = true;
            exRange.Range["A6:H6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:H6"].ColumnWidth = 12;
            exRange.Range["C6:H6"].ColumnWidth = 12;
            exRange.Range["C6:H6"].ColumnWidth = 12;
            exRange.Range["A6:A6"].Value = "STT";
            exRange.Range["B6:B6"].Value = "Mã NV";
            exRange.Range["C6:C6"].Value = "Tên NV";
            exRange.Range["D6:D6"].Value = "Mã Ca";
            exRange.Range["E6:E6"].Value = "Ngày Sinh";
            exRange.Range["F6:F6"].Value = "Giới Tính";
            exRange.Range["G6:G6"].Value = "Địa Chỉ";
            exRange.Range["H6:H6"].Value = "SĐT";

            for (nv = 0; nv < tableNhanVien.Rows.Count; nv++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][nv + 7] = nv + 1;
                for (cot = 0; cot < tableNhanVien.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 7
                {
                    exSheet.Cells[cot + 2][nv + 7] = tableNhanVien.Rows[nv][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][nv + 7] = tableNhanVien.Rows[nv][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][nv + 14];
            exRange.Font.Bold = true;
            exApp.Visible = true;
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            loadDataGridview();
            resetvalues();
        }
    }
}
