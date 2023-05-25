using DevExpress.XtraReports.UI;
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
    public partial class XfrmPhieuDiem : Form
    {
        public XfrmPhieuDiem()
        {
            InitializeComponent();
        }

        private void XfrmPhieuDiem_Load(object sender, EventArgs e)
        {
            DataTable dssv = Program.ExecSqlDataTable("SELECT MASV, MALOP FROM LINK0.QLDSV_TC.DBO.SINHVIEN WHERE DANGHIHOC = 'False'");
            cmbMASV.DataSource = dssv;
            cmbMASV.ValueMember = "MASV";
            cmbMASV.DisplayMember = "MASV";

            SqlDataReader tenkhoa = Program.ExecSqlDataReader("sp_lay_tenkhoa_tu_malop '" + dssv.Rows[0][1].ToString() + "'");
            tenkhoa.Read();
            Program.bds_dspm.Position = Program.bds_dspm.Find("tenkhoa", tenkhoa.GetString(0));
            Program.servername = ((DataRowView)Program.bds_dspm[Program.bds_dspm.Position])["TENSERVER"].ToString();

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

            

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // server mảnh chua mo
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới Khoa!", "", MessageBoxButtons.OK);
                return;
            }
            Xrpt_PhieuDiem xfrm = new Xrpt_PhieuDiem(cmbMASV.SelectedValue.ToString());

            ReportPrintTool print = new ReportPrintTool(xfrm);
            print.ShowPreviewDialog();

        }
    }
}
