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
    public partial class frmLop : Form
    {
        // vi tri khi them
        private int viTri = 0;
        private string maKhoa = "";
        private string maLop = "";
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            

            //  SET FONT FOR ALL CONTROLS
            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = new System.Drawing.Font("Times New Roman", 12));
            dS1.EnforceConstraints = false;
            try
            {
                //Program.connstr = "Data Source=DESKTOP-9QNDCS8\\DUCTRONG;Initial Catalog=QLDSV_TC;Integrated Security=True";
                this.lOPTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter1.Fill(this.dS1.LOP);
                // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
                this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter1.Fill(this.dS1.SINHVIEN);
                // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
                this.dANGKYTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter1.Fill(this.dS1.DANGKY);
                dgvSINHVIEN.ContextMenuStrip = contextMenuStrip2;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form Lop!", "", MessageBoxButtons.OK);
                return;
            }
            maKhoa = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
            maLop = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
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
            pnlLOP.Enabled = false;
            pnlSINHVIEN.Enabled = false;

            
        }



        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
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
                this.lOPTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter1.Fill(this.dS1.LOP);
                this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter1.Fill(this.dS1.SINHVIEN);
                maKhoa = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chuyển khoa!", "", MessageBoxButtons.OK);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLOP.Position;
            pnlLOP.Enabled = true;
            bdsLOP.AddNew();
            txtMAKHOA.Text = maKhoa;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLOP.Enabled = true;
            
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLOP.Position;
            pnlLOP.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
            gcLOP.Enabled = false;
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
                this.lOPTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter1.Update(this.dS1.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp!", "", MessageBoxButtons.OK);
                return;
            }
            gcLOP.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            pnlLOP.Enabled = false;
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
                    this.lOPTableAdapter1.Connection.ConnectionString = Program.connstr;
                    // cap nhat xoa tren database
                    this.lOPTableAdapter1.Update(this.dS1.LOP);
                }
                catch (Exception ex)
                {
                    // truong hop cap nhat tren db bi loi
                    MessageBox.Show("Lỗi xóa giảng viên. Bạn hãy thử xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    // do du lieu tu db vào lại giao diện nếu xóa k thành công
                    this.lOPTableAdapter1.Fill(this.dS1.LOP);
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
            pnlLOP.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter1.Fill(this.dS1.LOP);
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

        

        private void tsTHEMSV_Click(object sender, EventArgs e)
        {
            viTri = bdsSINHVIEN.Position;
            pnlSINHVIEN.Enabled = true;
            bdsSINHVIEN.AddNew();
            txtMALOPSV.Text = maLop;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            dgvSINHVIEN.Enabled = true;
        }

        private void tsHIEUCHINHSV_Click(object sender, EventArgs e)
        {
            viTri = bdsSINHVIEN.Position;
            pnlSINHVIEN.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            
            dgvSINHVIEN.Enabled = false;
        }

        private void tsXOASV_Click(object sender, EventArgs e)
        {
            string masv = "";
            // sinh vien da dang ki lop tin chi thi khong xoa
            if (bdsDANGKI.Count > 0)
            {
                MessageBox.Show("Sinh viên đã đăng kí lớp tính chỉ, không thế xóa!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MASV"].ToString();
                    // XOA TREN GIAO DIEN
                    bdsSINHVIEN.RemoveCurrent();
                    this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter1.Update(this.dS1.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên!", "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter1.Fill(this.dS1.SINHVIEN);
                    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MASV", masv);
                    return;
                }
            }
        }

        private void btnGHISV_Click(object sender, EventArgs e)
        {
            if (txtMASV.Text.Trim() == "")
                MessageBox.Show("mã sinh viên không được để trống!", "", MessageBoxButtons.OK);
            if (txtHO.Text.Trim() == "")
                MessageBox.Show("họ sinh viên không được để trống!", "", MessageBoxButtons.OK);
            if (txtTEN.Text.Trim() == "")
                MessageBox.Show("tên sinh viên không được để trống!", "", MessageBoxButtons.OK);
            // DIACHI, NGAYSINH, PASSWORD có thể null
            // viet sp kiem tra MASV đã tồn tại trên các mảnh chưa

            try
            {
                bdsSINHVIEN.EndEdit();
                bdsSINHVIEN.ResetCurrentItem();
                this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter1.Update(this.dS1.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên!", "", MessageBoxButtons.OK);
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
                return;
            }
             
            pnlSINHVIEN.Enabled = false;
        }

        private void btnPHUCHOISV_Click(object sender, EventArgs e)
        {
            // neu chưa ghi
            // The EndEdit method has not been called yet.
            bdsSINHVIEN.CancelEdit();
            dgvSINHVIEN.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            pnlSINHVIEN.Enabled = false;
        }
    }
}
