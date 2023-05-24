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
            pnlTTSV.Visible = false;
            pnlTAILTC.Visible = false;  
        }

        private void btnTTSV_Click(object sender, EventArgs e)
        {
            pnlTTSV.Visible = true;
            pnlTAILTC.Visible = true;
            using (SqlDataReader ttsv = Program.ExecSqlDataReader("sp_TimSV'" + txtMASV.Text + "'"))
            {
                if (ttsv == null)
                {
                    txtMASV.Focus();
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
                this.sp_lay_dsltc_de_dkyTableAdapter.Fill(this.dSdangKyLTC.sp_lay_dsltc_de_dky, cmbNienKhoa.Text.ToString(), int.Parse(cmbHocKy.Text.ToString()));
                
                if (sp_lay_dsltc_de_dkyBindingSource.Count == 0) // khong co lop tin chi trong nien khoa, hoc ky do user chon
                {
                    MessageBox.Show("Không có lớp tín chỉ trong niên khoá, học kỳ vừa chọn! Vui lòng chọn niên khóa, học kỳ khác", "", MessageBoxButtons.OK);
                    return;
                }
                //for (int i = 0; i < dSdangKyLTC.sp_lay_dsltc_de_dky.Rows.Count; i++)
                //{
                //    dSdangKyLTC.sp_lay_dsltc_de_dky.Rows[i]["DANGKI"] = false;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách lớp tín chỉ", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        
    }
}
