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
        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            dS1.EnforceConstraints = false;
            try
            {
                //Program.connstr = "Data Source=DESKTOP-9QNDCS8\\DUCTRONG;Initial Catalog=QLDSV_TC;Integrated Security=True";
                this.lOPTINCHITableAdapter1.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter1.Fill(this.dS1.LOPTINCHI);
                this.dANGKYTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter1.Fill(this.dS1.DANGKY);
                cmbMONHOC.DataSource = Program.ExecSqlDataTable("SELECT * FROM ds_monhoc");
                cmbMONHOC.DisplayMember = "TENMH";
                cmbMONHOC.ValueMember = "MAMH";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form Lop tín chỉ!", "", MessageBoxButtons.OK);
                return;
            }
            maKhoa = ((DataRowView)bdsLOPTC[0])["MAKHOA"].ToString();
            
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

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            pnlLOPTC.Enabled = false;

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
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
                this.lOPTINCHITableAdapter1.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter1.Fill(this.dS1.LOPTINCHI);
                this.dANGKYTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter1.Fill(this.dS1.DANGKY);
                cmbMONHOC.DataSource = Program.ExecSqlDataTable("SELECT * FROM ds_monhoc");
                cmbMONHOC.DisplayMember = "TENMH";
                cmbMONHOC.ValueMember = "MAMH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chuyển khoa!", "", MessageBoxButtons.OK);
            }
            maKhoa = ((DataRowView)bdsLOPTC[0])["MAKHOA"].ToString();
        }
    }
}
