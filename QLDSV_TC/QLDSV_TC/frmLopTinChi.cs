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
    public partial class frmLopTinChi : Form
    {
        private string maKhoa = "";
        private string maLop = "";
        private int viTri = 0;
        private bool dangThem =false;
        public frmLopTinChi()
        {
            InitializeComponent();
        }

        public void trangThaiBanDau()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            pnlLOPTC.Enabled = false;
        }

        public void trangThaiChuaGhi()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            pnlLOPTC.Enabled = true;
        }
        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
          

            dS_MoLTC.EnforceConstraints = false;
            try
            {
                //Program.connstr = "Data Source=DESKTOP-9QNDCS8\\DUCTRONG;Initial Catalog=QLDSV_TC;Integrated Security=True";
                this.dSLTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSLTCTableAdapter.Fill(this.dS_MoLTC.DSLTC);
                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.dS_MoLTC.DANGKY);
                cmbMONHOC.DataSource = Program.ExecSqlDataTable("SELECT * FROM MONHOC");
                cmbMONHOC.DisplayMember = "TENMH";
                cmbMONHOC.ValueMember = "MAMH";
                cmbGV.DataSource = Program.ExecSqlDataTable("SELECT MAGV, TENGV = HO + ' ' + TEN FROM GIANGVIEN");
                cmbGV.DisplayMember = "TENGV";
                cmbGV.ValueMember = "MAGV";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form Lop tín chỉ!", "", MessageBoxButtons.OK);
                return;
            }
            
            
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            // ten khoa da dang nhap
            cmbKhoa.SelectedIndex = Program.mKhoa;
            maKhoa = ((DataRowView)bdsLOPTC[0])["MAKHOA"].ToString();
            if (maKhoa == null)
            {
                if (cmbKhoa.SelectedIndex == 0)
                {
                    maKhoa = "CNTT";
                }
                else if (cmbKhoa.SelectedIndex == 1)
                {
                    maKhoa = "VT";
                }
            }
            // phong giao vu moi duoc chuyen qua lai 2 khoa
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;
            
            trangThaiBanDau();
            

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void cmbKhoa_SelectionChangeCommitted(object sender, EventArgs e)
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
                this.dSLTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSLTCTableAdapter.Fill(this.dS_MoLTC.DSLTC);
                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.dS_MoLTC.DANGKY);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chuyển khoa!", "", MessageBoxButtons.OK);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLOPTC.Position;
            txtMAKHOA.Text = maKhoa;
            cmbNIENKHOA.Text = "";
            cmbHOCKY.Text = "";
            cmbMONHOC.Text = "";
            cmbNHOM.Text = "";
            cmbGV.Text = "";
            trangThaiChuaGhi();
            chkHUYLOP.Visible = false;
            lblHUYLOP.Visible = false;
            dangThem = true;
            Console.WriteLine(chkHUYLOP.Checked);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
           if(cmbNIENKHOA.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được để trống, vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbNIENKHOA.Focus();
                return;
            }
            if (cmbHOCKY.Text.Trim() == "")
            {
                MessageBox.Show("Học kỳ không được để trống, vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbHOCKY.Focus();
                return;
            }
            if (cmbMONHOC.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống, vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbMONHOC.Focus();
                return;
            }
            if (cmbNHOM.Text.Trim() == "")
            {
                MessageBox.Show("Nhóm không được để trống, vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbNHOM.Focus();
                return;
            }
            if (cmbGV.Text.Trim() == "")
            {
                MessageBox.Show("Tên giảng viên không được để trống, vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbGV.Focus();
                return;
            }
            if (spinSVTOITHIEU.Text == "")
            {
                MessageBox.Show("Số sinh viên tối thiểu không được để trống, vui lòng chọn!", "", MessageBoxButtons.OK);
                spinSVTOITHIEU.Focus();
                return;
            }



            
            
            try
            {
                if (dangThem)
                {
                    int moLop = Program.ExecSqlNonQuery("INSERT INTO LOPTINCHI(NIENKHOA, HOCKY, MAMH, NHOM, MAGV, MAKHOA, SOSVTOITHIEU, HUYLOP) VALUES('" +
                        cmbNIENKHOA.Text + "','"
                        + cmbHOCKY.Text + "','"
                        + cmbMONHOC.SelectedValue.ToString() + "','"
                        + cmbNHOM.Text + "','"
                        + cmbGV.SelectedValue.ToString() + "','"
                        + txtMAKHOA.Text + "',"
                        + spinSVTOITHIEU.Text + ",'"
                        + chkHUYLOP.Checked + "')"
                        );
                    if (moLop != 0)
                    {
                        MessageBox.Show("Lỗi ghi lớp tín chỉ, vui lòng kiểm tra lại thông tin đã nhập!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    int maltc = int.Parse(((DataRowView)bdsLOPTC[bdsLOPTC.Position])["MALTC"].ToString());
                    int suaLop = Program.ExecSqlNonQuery("UPDATE LOPTINCHI " +
                        "SET NIENKHOA= '" + cmbNIENKHOA.Text + "'," +
                        "HOCKY='" + cmbHOCKY.Text + "'," +
                        "MAMH='" + cmbMONHOC.SelectedValue.ToString() + "'," +
                        "NHOM= " + cmbNHOM.Text + "," +
                        "MAGV='" + cmbGV.SelectedValue.ToString() + "'," +
                        "MAKHOA='" + txtMAKHOA.Text + "'," +
                        "SOSVTOITHIEU= " + spinSVTOITHIEU.Text + "," +
                        "HUYLOP ='" + chkHUYLOP.Checked + "'" +
                        "WHERE MALTC =" + maltc.ToString()

                        ) ;
                    if (suaLop != 0)
                    {
                        MessageBox.Show("Lỗi ghi lớp tín chỉ, vui lòng kiểm tra lại thông tin đã nhập!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                    
                
                
            }
            catch
            {
                MessageBox.Show("Lỗi ghi lớp tín chỉ, vui lòng kiểm tra lại thông tin đã nhập!", "", MessageBoxButtons.OK);
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            trangThaiBanDau();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOPTC.CancelEdit();
            if (btnThem.Enabled == false)
                bdsLOPTC.Position = viTri;
            trangThaiBanDau();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLOPTC.Position;
            trangThaiChuaGhi();
            chkHUYLOP.Visible = true;
            lblHUYLOP.Visible = true;
            dangThem = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maltc = "";
            if (bdsDANGKI.Count > 0)
            {
                MessageBox.Show("Lớp tín chỉ này đã được đăng kí mở lớp! Không thế xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp tín chỉ này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                try
            {
                // giu lai vi tri con tro chuot dang tro toi giang vien chon de xoa
                maltc = ((DataRowView)bdsLOPTC[bdsLOPTC.Position])["MALTC"].ToString();
                bdsLOPTC.RemoveCurrent();
                int moLop = Program.ExecSqlNonQuery("DELETE FROM LOPTINCHI WHERE MALTC=" + maltc.ToString());
                  
                if (moLop != 0)
                {
                    MessageBox.Show("Lỗi xóa lớp tín chỉ, vui lòng kiểm tra lại!", "", MessageBoxButtons.OK);
                    return;
                }
                //this.lOPTINCHITableAdapter1.Connection.ConnectionString = Program.connstr;
                //this.lOPTINCHITableAdapter1.Update(this.dS1.LOPTINCHI);
            }
            catch (Exception ex)
            {
                // truong hop cap nhat tren db bi loi
                MessageBox.Show("Lỗi xóa lớp tín chỉ. Bạn hãy thử xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                // do du lieu tu db vào lại giao diện nếu xóa không thành công
                this.dSLTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSLTCTableAdapter.Fill(this.dS_MoLTC.DSLTC);
                // hiển thị dòng được trỏ tới để xóa ở trên
                bdsLOPTC.Position = bdsLOPTC.Find("MALTC", maltc);
                return;
            }
            trangThaiBanDau();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dSLTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSLTCTableAdapter.Fill(this.dS_MoLTC.DSLTC);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, " ", MessageBoxButtons.OK);
                return;
            }
            trangThaiBanDau();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcLOPTC_Click(object sender, EventArgs e)
        {

        }
    }
}
