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
    public partial class frmNhapDiem : Form
    {
        private int maltc;
        private DataTable dt_ds_dki;
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            // ten khoa da dang nhap
            cmbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;
            btnNhapDiem.Enabled = btnGhi.Enabled = false;
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
            btnNhapDiem.Enabled = btnGhi.Enabled = false;
        }

        private void btnTaiLoptc_Click(object sender, EventArgs e)
        {
            if (cmbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không để trống!", "", MessageBoxButtons.OK);
                cmbNienKhoa.Focus();
                return;
            }
            if (cmbHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Học kỳ không để trống!", "", MessageBoxButtons.OK);
                cmbHocKy.Focus();
                return;
            }
            if (gcDKY.Visible == true)
            {
                gcDKY.Visible = false;
            }

            try
            {
                this.sp_ds_loptc_de_nhap_diemTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_ds_loptc_de_nhap_diemTableAdapter.Fill(this.dS1.sp_ds_loptc_de_nhap_diem, cmbNienKhoa.Text.ToString(), int.Parse(cmbHocKy.Text.ToString()));
                if (bdsDSLOPTC.Count ==  0) // khong co lop tin chi trong nien khoa, hoc ky do user chon
                {
                    gcDSLTC.Visible = false;
                    MessageBox.Show("Không có lớp tín chỉ trong niên khoá, học kỳ vừa chọn! Vui lòng chọn niên khóa, học kỳ khác", "", MessageBoxButtons.OK);
                    return;
                }
                gcDSLTC.Visible=true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi load form lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }
            btnNhapDiem.Enabled = true;
            btnGhi.Enabled = false;
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            maltc = int.Parse(((DataRowView)bdsDSLOPTC[bdsDSLOPTC.Position])["MALTC"].ToString()) ;
            try
            {
                this.ds_sv_dki_loptc_de_nhapdiemTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ds_sv_dki_loptc_de_nhapdiemTableAdapter.Fill(this.dS1.ds_sv_dki_loptc_de_nhapdiem, maltc);
                if (bdsDSSVDKI.Count == 0) // khong co lop tin chi trong nien khoa, hoc ky do user chon
                {
                    gcDKY.Visible = false;
                    MessageBox.Show("Chưa có sinh viên nào đăng kí lớp tín chỉ vừa chọn! Vui lòng chọn lớp tín chỉ khác", "", MessageBoxButtons.OK);
                    return;
                }
                if (gcDKY.Visible == false)
                {
                    gcDKY.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form sinh viên đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }
            btnGhi.Enabled = true;
            
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof (string));
            dt.Columns.Add("DIEM_CC", typeof(int));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            int intmaltc = maltc;
            //Console.WriteLine(maltc);
            //Console.WriteLine(dS1.ds_sv_dki_loptc_de_nhapdiem.Rows.Count);
            for (int i = 0; i < dS1.ds_sv_dki_loptc_de_nhapdiem.Rows.Count; i++)
            {
                // chua bat loi phan nhập điểm phải nằm trong phạm vi [0, 10]
                //if (int.Parse(dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["DIEM_CC"].ToString()) < 0 || int.Parse(dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["DIEM_CC"].ToString()) > 10)
                //{
                //    MessageBox.Show("Điểm chuyên cần phải >= 0 và <= 10! Vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
                //    cmbNienKhoa.Focus();
                //    return;
                //}
                //if (double.Parse(dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["DIEM_GK"].ToString()) < 0.0 || double.Parse(dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["DIEM_GK"].ToString()) > 10.0)
                //{
                //    MessageBox.Show("Điểm giữa kì phải >= 0 và <= 10! Vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
                //    cmbNienKhoa.Focus();
                //    return;
                //}
                //if (double.Parse(dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["DIEM_CK"].ToString()) < 0.0 || double.Parse(dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["DIEM_CK"].ToString()) > 10.0)
                //{
                //    MessageBox.Show("Điểm cuối kỳ phải >= 0 và <= 10! Vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
                //    cmbNienKhoa.Focus();
                //    return;
                //}
                dt.Rows.Add(maltc, dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["MASV"], dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["DIEM_CC"], dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["DIEM_GK"], dS1.ds_sv_dki_loptc_de_nhapdiem.Rows[i]["DIEM_CK"]);
                
            }
            //printDT(dt);
            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_DANGKI";
            para.ParameterName = "@DIEMTHI";
            para.Value = dt;

            try
            {
                Program.KetNoi();
                SqlCommand sqlcmd = new SqlCommand("sp_capnhat_diem", Program.conn);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Ghi điểm thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật điểm không thành công! Vui lòng kiểm tra lại!", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public void printDT(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {          
                Console.WriteLine("MALTC: " + dt.Rows[i]["MALTC"]  + ",MASV: " + dt.Rows[i]["MASV"] + ",DIEMCC: " + dt.Rows[i]["DIEM_CC"] + ", DIEMGK: " + dt.Rows[i]["DIEM_GK"] + ", DIEMCK: " + dt.Rows[i]["DIEM_CK"]);
            }
        }
        
    }
}
