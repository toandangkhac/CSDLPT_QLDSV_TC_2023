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
    public partial class XfrmDSLopTCtheoNienKhoaHocKy : Form
    {
        public XfrmDSLopTCtheoNienKhoaHocKy()
        {
            InitializeComponent();
        }

        private void XfrmDSLopTCtheoNienKhoaHocKy_Load(object sender, EventArgs e)
        {
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

        }
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// kiem tra hien tai combobox da co so lieu chua: chua nhan datasource
            //if (cmbKhoa.SelectedIndex.ToString() == "System.Data.DataRowView")
            //    return;
            //// neu chon duoc 1 khoa trong combobox

            //Program.servername = cmbKhoa.SelectedValue.ToString();

            //// truong hop chuyen khoa khac voi khoa luc dang nhap
            //if (cmbKhoa.SelectedIndex != Program.mKhoa)
            //{
            //    Program.mlogin = Program.remotelogin;
            //    Program.password = Program.remotepassword;
            //}
            //else
            //{
            //    Program.mlogin = Program.mloginDN;
            //    Program.password = Program.passwordDN;
            //}

            //// server mảnh chua mo
            //if (Program.KetNoi() == 0)
            //{
            //    MessageBox.Show("Lỗi kết nối tới Khoa mới!", "", MessageBoxButtons.OK);
            //    return;
            //}
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            XrptDSLopTCtheoNienKhoaHocKy xfrm = new XrptDSLopTCtheoNienKhoaHocKy(cmbNienKhoa.Text, Int32.Parse(cmbHocKy.Text));
            xfrm.xrlblKHOA.Text = cmbKhoa.Text;
            xfrm.xrlblNIENKHOA.Text = cmbNienKhoa.Text;
            xfrm.xrlblHOCKY.Text = cmbHocKy.Text;

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
