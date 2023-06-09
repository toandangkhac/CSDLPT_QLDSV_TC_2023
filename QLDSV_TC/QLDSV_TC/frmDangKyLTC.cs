using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDangKyLTC : Form
    {
        public frmDangKyLTC()
        {
            InitializeComponent();
        }

        

        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            dSdangKyLTC.EnforceConstraints = false;
            pnlLTC.Visible = false;
            pnlLTCdaDKY.Visible = false;
            pnlTAILTC.Visible = false;  
            pnlTTSV.Visible = false;
            btnLuu.Visible = false;
        }

        private void btnTTSV_Click(object sender, EventArgs e)
        {
            pnlTTSV.Visible = true;
            pnlTAILTC.Visible = true;
            pnlLTC.Visible = false;
            pnlLTCdaDKY.Visible = false;
            btnLuu.Visible = false;
            using (SqlDataReader ttsv = Program.ExecSqlDataReader("sp_TimSV'" + txtMASV.Text + "'"))
            {
                if (ttsv == null)
                {
                    txtMASV.Focus();
                    MessageBox.Show("Mã sinh viên không tồn tại, vui lòng nhập chính xác!", "", MessageBoxButtons.OK);
                    return;
                }
                ttsv.Read();
                txtHO.Text = ttsv.GetString(0);
                txtTEN.Text = ttsv.GetString(1);
                txtMALOP.Text = ttsv.GetString(2);
            }

            using (SqlDataReader tenkhoa = Program.ExecSqlDataReader("sp_lay_tenkhoa_tu_malop '" + txtMALOP.Text.ToString() + "'"))
            {
                tenkhoa.Read();
                Program.bds_dspm.Position = Program.bds_dspm.Find("tenkhoa", tenkhoa.GetString(0));
                Program.servername = ((DataRowView)Program.bds_dspm[Program.bds_dspm.Position])["TENSERVER"].ToString();
            }
                
            if (Program.bds_dspm.Position != Program.mKhoa)
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
                MessageBox.Show("Lỗi kết nối tới Khoa!", "", MessageBoxButtons.OK);
                return;
            }
          

        }

        private void btnTaiLTC_Click(object sender, EventArgs e)
        {
            pnlTTSV.Visible = true;
            pnlTAILTC.Visible = true;
            pnlLTC.Visible = true;
            pnlLTCdaDKY.Visible = true;
            btnLuu.Visible = true;
            //btnLuu.Enabled = false;
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
            

            try
            {
                this.sp_lay_dsltc_de_dkyTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_lay_dsltc_de_dkyTableAdapter.Fill(this.dSdangKyLTC.sp_lay_dsltc_de_dky, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                this.sp_lay_dsltc_da_dkyTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_lay_dsltc_da_dkyTableAdapter.Fill(this.dSdangKyLTC.sp_lay_dsltc_da_dky, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text), txtMASV.Text);
                if (bdsLTC_DKY.Count == 0) // khong co lop tin chi trong nien khoa, hoc ky do user chon
                {
                    MessageBox.Show("Không có lớp tín chỉ trong niên khoá, học kỳ vừa chọn! Vui lòng chọn niên khóa, học kỳ khác", "", MessageBoxButtons.OK);
                    return;
                }
                for (int i = 0; i < dgvLTC_DKY.Rows.Count - 1; i++)
                {

                    dgvLTC_DKY.Rows[i].Cells[5].Value = "False";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách lớp tín chỉ", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            int maltc = int.Parse( ((DataRowView)bdsLTC_DKY[bdsLTC_DKY.Position])["MALTC"].ToString());
            int countTick = 0;
            
            for (int i = 0; i < dgvLTC_DKY.Rows.Count-1; i++)
            {

                if (dgvLTC_DKY.Rows[i].Cells[5].Value.ToString() == "True")
                {
                    dt.Rows.Add(dSdangKyLTC.sp_lay_dsltc_de_dky.Rows[i]["MALTC"], txtMASV.Text);
                    countTick++;
                }  
            }

            if (countTick == 0)
            {
                MessageBox.Show("Bạn chưa chọn đăng kí lớp tín chỉ nào! Vui lòng chọn!", "", MessageBoxButtons.OK);
                pnlLTC.Focus();
                return;
            }
            printDT(dt);
            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_DANGKI_LTC";
            para.ParameterName = "@DANGKY";
            para.Value = dt;

            try
            {
                Program.KetNoi();
                SqlCommand sqlcmd = new SqlCommand("sp_dky_loptc", Program.conn);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Lưu đăng kí thành công!", "", MessageBoxButtons.OK);
                this.sp_lay_dsltc_da_dkyTableAdapter.Fill(this.dSdangKyLTC.sp_lay_dsltc_da_dky, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text), txtMASV.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu đăng kí không thành công! Có lớp đã đăng kí rồi!", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
                return;
            }
        }
        public void printDT(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("MALTC: " + dt.Rows[i]["MALTC"] + ",MASV: " + dt.Rows[i]["MASV"]);
            }
        }
    }
}
