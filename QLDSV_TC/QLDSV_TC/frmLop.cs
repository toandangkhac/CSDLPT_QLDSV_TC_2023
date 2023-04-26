using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmLop : Form
    {
        // vi tri khi them
        int viTri = 0;
        string maKhoa = "";
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.


            // TODO: This line of code loads data into the 'dS1.SINHVIEN' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dS1.LOP' table. You can move, or remove it, as needed.
            // LOP, SINH VIEN THUOC KHOA VT

            dS.EnforceConstraints = false;
            try
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form Lop!", "", MessageBoxButtons.OK);
                return;
            }

            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.

            maKhoa = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            // ten khoa da dang nhap
            cmbKhoa.SelectedIndex = Program.mKhoa;
            // phong giao vu moi duoc chuyen qua lai 2 khoa
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
            pnlThemLop.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLOP.Position;
            pnlThemLop.Enabled = true;
            bdsLOP.AddNew();
            txtMAKHOA.Text = maKhoa;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLOP.Enabled = true;
        }

        private void sINHVIENBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kiem tra hien tai combobox da co so lieu chua: chua nhan datasource
            if (cmbKhoa.SelectedIndex.ToString() == "System.Data.DataRowView")
                return;
            // neu chon duoc 1 khoa trong combobox

            Program.servername = cmbKhoa.SelectedValue.ToString();

            // truong hop chuyen khoa khac voi khoa luc dang nhap
            if (cmbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            // server mảnh chua mo
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới Khoa mới!", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                maKhoa = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chuyển khoa!", "", MessageBoxButtons.OK);
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không để rỗng!", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                txtMALOP.Focus();
                return;
            }
            if (txtTENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không để rỗng!", "", MessageBoxButtons.OK);
                txtTENLOP.Focus();
                return;
            }

            // MALOP trùng với MALOP trên các side: CHUA CODE

            try
            {
                // ket thuc hieu chinh: ghi
                bdsLOP.EndEdit();
                // dua thong tin len luoi (grid)
                bdsLOP.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp!", "", MessageBoxButtons.OK);
                return;
            }
            gcLOP.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            pnlThemLop.Enabled = false;
        }

        private void txtMALOP_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLOP.Position;
            pnlThemLop.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
            gcLOP.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string malop = "";
            // neu lop da co sinh vien thi khong dc xoa
            if (bdsSINHVIEN.Count > 0)
            {
                MessageBox.Show("Khong the xoa lớp vì đã chứa sinh viên", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Ban có thật sự muốn xóa lớp này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // giu lai vi tri con tro chuot dang tro toi giang vien chon de xoa
                    malop = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
                    // xoa tren giao dien
                    bdsLOP.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    // cap nhat xoa tren database
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                catch (Exception ex)
                {
                    // truong hop cap nhat tren db bi loi
                    MessageBox.Show("Lỗi xóa giảng viên. Bạn hãy thử xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    // do du lieu tu db vào lại giao diện nếu xóa k thành công
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    // hiển thị dòng được trỏ tới để xóa ở trên
                    bdsLOP.Position = bdsLOP.Find("MALOP", malop);
                    return;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //neu chua ghi
            bdsLOP.CancelEdit();
            if (btnThem.Enabled == false) bdsLOP.Position = viTri;
            gcLOP.Enabled = true;
            pnlThemLop.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi Reload: " + ex.Message, " ", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }

}


