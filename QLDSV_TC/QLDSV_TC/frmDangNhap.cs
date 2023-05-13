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
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "TENSERVER";
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private int KetNoi_CSDLGOC()
        {
            if(conn_publisher == null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc.\nBạn xem lại Tên Server của Publisher, và tên CSDL trong SQL");
                return 0;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            
            if (KetNoi_CSDLGOC() == 0)
            {
                return;
            }
            LayDSPM("SELECT * FROM Get_Subscribes");
            cmbKhoa.SelectedIndex = 0;
            cmbKhoa.SelectedIndex = 1;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // gan ten server de ket noi khi chon khoa tren combobox
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không để trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.servername = cmbKhoa.SelectedValue.ToString();
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            // ket noi toi sv phan manh// lay duoc Program.connstr
            if (Program.KetNoi() == 0) return;

            // lay 3 thong tin nay dua vao bien toan cuc trong program 
            Program.mKhoa = cmbKhoa.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh = "";
            if (radGiangVien.Checked)
            {
                strLenh = "EXEC sp_lay_thong_tin_gv_tu_login '" + Program.mlogin + "'";
            }
            else if (radSinhVien.Checked)
            {
                strLenh = "EXEC sp_lay_thong_tin_sv_tu_login '" + Program.mlogin + "'";
            }
            

            // viet chuong trinh tra ve du lieu tu viec goi sp
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return; // khong tim thay du lieu cua sinh vien dang nhap
            Program.myReader.Read();    // doc 1 dong trong datareader, neu nhieu dong thi viet vong lap

            Program.username = Program.myReader.GetString(0); // cot dau tien la username
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            // dong datareader va connect db
            Program.myReader.Close();
            Program.conn.Close();

            
            Program.frmChinh = new frmMain();
            Program.frmChinh.Show();
            
            // Hien thi thong tin sinh  vien
            Program.frmChinh.MA.Text = "Mã SV = " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ Tên = " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm = " + Program.mGroup;
            Program.frmDN.Hide();
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }





        private void radGiangVien_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radGiangVien.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }

        }

        private void radSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            if (radSinhVien.Checked)
            {
                cmbKhoa.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = true;
            }
            
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
