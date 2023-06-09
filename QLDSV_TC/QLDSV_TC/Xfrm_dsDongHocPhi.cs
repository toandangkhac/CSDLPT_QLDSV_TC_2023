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
    public partial class Xfrm_dsDongHocPhi : Form
    {
        public Xfrm_dsDongHocPhi()
        {
            InitializeComponent();
        }

        private void Xfrm_dsDongHocPhi_Load(object sender, EventArgs e)
        {
            DataTable dsl = Program.ExecSqlDataTable("SELECT MALOP FROM LOP");
            cmbMALOP.DataSource = dsl;
            cmbMALOP.ValueMember = "MALOP";
            cmbMALOP.DisplayMember = "MALOP";


        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(cmbMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp!", "", MessageBoxButtons.OK);
                cmbMALOP.Focus();
            }
            if (cmbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn niên khóa!", "", MessageBoxButtons.OK);
                cmbNienKhoa.Focus();
            }
            if (cmbHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "", MessageBoxButtons.OK);
                cmbHocKy.Focus();
            }
            Xrpt_ds_donghocphi_theolop xfrm = new Xrpt_ds_donghocphi_theolop(cmbMALOP.SelectedValue.ToString(), cmbNienKhoa.Text, Int32.Parse(cmbHocKy.Text));
            SqlDataReader tenkhoa = Program.ExecSqlDataReader("SELECT TENKHOA FROM KHOA WHERE MAKHOA = (SELECT MAKHOA FROM LOP WHERE MALOP = '" + cmbMALOP.Text + "')");
            tenkhoa.Read();
            xfrm.xrlbKHOA.Text = tenkhoa.GetString(0);
            xfrm.xrlbMALOP.Text = cmbMALOP.Text;

            ReportPrintTool print = new ReportPrintTool(xfrm);
            print.ShowPreviewDialog();
        }
    }
}
