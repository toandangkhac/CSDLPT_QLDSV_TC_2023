using DevExpress.XtraReports.UI;
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
    public partial class XfrmBangDiemHetMon : Form
    {
        public XfrmBangDiemHetMon()
        {
            InitializeComponent();
        }

        private void XfrmBangDiemHetMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSXrpt_dssvDkyLTC.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dSXrpt_dssvDkyLTC.MONHOC);
            // TODO: This line of code loads data into the 'dSXrpt_dssvDkyLTC.MONHOC' table. You can move, or remove it, as needed.

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
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dSXrpt_dssvDkyLTC.MONHOC);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cmbKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khoa!", "", MessageBoxButtons.OK);
                cmbKhoa.Focus();
            }
            if (cmbMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn môn học!", "", MessageBoxButtons.OK);
                cmbMonHoc.Focus();
            }
            if (cmbHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "", MessageBoxButtons.OK);
                cmbHocKy.Focus();
            }
            if (cmbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn niên khóa!", "", MessageBoxButtons.OK);
                cmbNienKhoa.Focus();
            }
            if (cmbNhom.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhóm!", "", MessageBoxButtons.OK);
                cmbNhom.Focus();
            }
            Xrpt_BangDiemHetMon xfrm = new Xrpt_BangDiemHetMon(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text), cmbMonHoc.SelectedValue.ToString(), int.Parse(cmbNhom.Text));
            xfrm.xrlblKHOA.Text = cmbKhoa.Text;
            xfrm.xrlblNIENKHOA.Text = cmbNienKhoa.Text;
            xfrm.xrlblHOCKY.Text = cmbHocKy.Text;
            xfrm.xrlblMONHOC.Text = cmbMonHoc.Text;
            xfrm.xrlblNHOM.Text = cmbNhom.Text;

            ReportPrintTool print = new ReportPrintTool(xfrm);
            print.ShowPreviewDialog();
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
        }
    }
}
