using QLDSV_TC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmMonHoc : Form
    {
        int viTri = 0;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            try
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS.LOPTINCHI' table. You can move, or remove it, as needed.
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form Môn học!", "", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
            pnlThemMH.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsMONHOC.Position;
            pnlThemMH.Enabled = true;
            bdsMONHOC.AddNew();

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcMONHOC.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không để rỗng!", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                txtMAMH.Focus();
                return;
            }
            if (txtTENMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không để rỗng!", "", MessageBoxButtons.OK);
                txtTENMH.Focus();
                return;
            }
            if (spinSOTIETLT.Value < 0)
            {
                MessageBox.Show("Số tiết lý thuyết lớn hơn hoặc bằng 0!", "", MessageBoxButtons.OK);
                spinSOTIETLT.Focus();
                return;
            }
            if (spinSOTIETTH.Value < 0)
            {
                MessageBox.Show("Số tiết thực hành lớn hơn hoặc bằng 0!", "", MessageBoxButtons.OK);
                spinSOTIETTH.Focus();
                return;
            }

            // MAMH trùng với MAMH trên các side: CHUA CODE

            try
            {
                // ket thuc hieu chinh: ghi
                bdsMONHOC.EndEdit();
                // dua thong tin len luoi (grid)
                bdsMONHOC.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp tín chỉ!", "", MessageBoxButtons.OK);
                return;
            }
            gcMONHOC.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            pnlThemMH.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsMONHOC.Position;
            pnlThemMH.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
            gcMONHOC.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mamh = "";
            // neu lop da co sinh vien thi khong dc xoa
            if (bdsLOPTC.Count > 0)
            {
                MessageBox.Show("Khong the xoa môn học vì đã có lớp tín chỉ đăng kí môn này", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Ban có thật sự muốn xóa môn học này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // giu lai vi tri con tro chuot dang tro toi giang vien chon de xoa
                    mamh = ((DataRowView)bdsMONHOC[bdsMONHOC.Position])["MAMH"].ToString();
                    // xoa tren giao dien
                    bdsMONHOC.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    // cap nhat xoa tren database
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                }
                catch (Exception ex)
                {
                    // truong hop cap nhat tren db bi loi
                    MessageBox.Show("Lỗi xóa giảng viên. Bạn hãy thử xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    // do du lieu tu db vào lại giao diện nếu xóa k thành công
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    // hiển thị dòng được trỏ tới để xóa ở trên
                    bdsMONHOC.Position = bdsMONHOC.Find("MAMH", mamh);
                    return;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //neu chua ghi
            bdsMONHOC.CancelEdit();
            if (btnThem.Enabled == false) bdsMONHOC.Position = viTri;
            gcMONHOC.Enabled = true;
            pnlThemMH.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
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

