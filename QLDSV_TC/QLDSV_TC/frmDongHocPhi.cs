using DevExpress.XtraRichEdit.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDongHocPhi : Form
    {
        int viTri;
        public frmDongHocPhi()
        {
            InitializeComponent();
        }
        private void trangThaiBanDau()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            
            gcHP.Enabled = dgvCTHP.Enabled = true;
            pnlThemHP.Enabled = false;
        }

        private void trangThaiChuaGhi()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

            gcHP.Enabled = dgvCTHP.Enabled = false;
            pnlThemHP.Enabled = true;
        }
        private void frmDongHocPhi_Load(object sender, EventArgs e)
        {
            trangThaiBanDau();
            // TODO: This line of code loads data into the 'dSDongHocPhi.HOCPHI' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dSDongHocPhi.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            dSDongHocPhi.EnforceConstraints = false;

            gcHP.Visible = dgvCTHP.Visible = pnlThemHP.Visible = pnlTTSV.Visible = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            using(SqlDataReader ttsv = Program.ExecSqlDataReader("SELECT HOTEN = HO + ' ' + TEN, MALOP FROM SINHVIEN WHERE MASV = '" + txtSV.Text + "'")){
                ttsv.Read();
                txtHOTEN.Text = ttsv.GetString(0);
                txtMALOP.Text = ttsv.GetString(1);
            }
            this.sp_lay_ds_donghocphi_cuasvTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_ds_donghocphi_cuasvTableAdapter.Fill(dSDongHocPhi.sp_lay_ds_donghocphi_cuasv, txtSV.Text.ToString());
            this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_DONGHOCPHITableAdapter.Fill(dSDongHocPhi.CT_DONGHOCPHI);
            dgvCTHP.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            gcHP.Visible = dgvCTHP.Visible = pnlThemHP.Visible = pnlTTSV.Visible = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = sp_lay_ds_donghocphi_cuasvBindingSource.Position;
            cmbNIENKHOA.Text = cmbHOCKY.Text = "";
            spinHOCPHI.Value = 0;
            trangThaiChuaGhi();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbNIENKHOA.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không để trống! Vui lòng chọn", "", MessageBoxButtons.OK);
                cmbNIENKHOA.Focus();
                return;
            }
            if (cmbHOCKY.Text.Trim() == "")
            {
                MessageBox.Show("Học kỳ không để trống! Vui lòng chọn", "", MessageBoxButtons.OK);
                cmbHOCKY.Focus();
                return;
            }
            if (spinHOCPHI.Text.Trim() == "")
            {
                MessageBox.Show("Học phí không để trống! Vui lòng chọn", "", MessageBoxButtons.OK);
                spinHOCPHI.Focus();
                return;
            }

            try
            {
                int ghiHP = Program.ExecSqlNonQuery("INSERT INTO HOCPHI (MASV, NIENKHOA, HOCKY, HOCPHI) VALUES('" + txtMASV.Text + "', '" + cmbNIENKHOA.Text + "', " + cmbHOCKY.Text + ", " + spinHOCPHI.Text + ")");
                if (ghiHP != 0) {
                    MessageBox.Show(ghiHP.ToString(), "", MessageBoxButtons.OK);
                    return;
                }  
                this.sp_lay_ds_donghocphi_cuasvTableAdapter.Fill(dSDongHocPhi.sp_lay_ds_donghocphi_cuasv, txtSV.Text.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ghi học phí không thành công! Vui lòng thử lại", "", MessageBoxButtons.OK);
                return;
            }
            trangThaiBanDau();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThem.Enabled == false) sp_lay_ds_donghocphi_cuasvBindingSource.Position = viTri;
            trangThaiBanDau();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sp_lay_ds_donghocphi_cuasvTableAdapter.Fill(dSDongHocPhi.sp_lay_ds_donghocphi_cuasv, txtSV.Text.ToString());
            }
            catch
            {

            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
