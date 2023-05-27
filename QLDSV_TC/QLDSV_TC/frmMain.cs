using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                btnTaoTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                ribPGVKHOA.Visible = true;
                ribSinhVien.Visible = false;
                ribKeToan.Visible = false;
                ribBaoCao.Visible = true;
            }
            else if (Program.mGroup == "PKT")
            {
                btnTaoTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                ribPGVKHOA.Visible = false;
                ribSinhVien.Visible = false;
                ribKeToan.Visible = true;
                ribBaoCao.Visible = false;
            }
            else if (Program.mGroup == "SV")
            {
                btnTaoTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                ribPGVKHOA.Visible = false;
                ribSinhVien.Visible = true;
                ribKeToan.Visible = false;
                ribBaoCao.Visible = false;
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnDanhMucLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDMLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frmDN = new frmDangNhap();
            Program.frmDN.Show();
            Program.frmChinh.Hide();
           
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTinChi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLopTinChi f = new frmLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(XfrmDSLopTCtheoNienKhoaHocKy));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                XfrmDSLopTCtheoNienKhoaHocKy f = new XfrmDSLopTCtheoNienKhoaHocKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKyLTC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangKyLTC f = new frmDangKyLTC();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(XfrmDSSVDkyLTC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                XfrmDSSVDkyLTC f = new XfrmDSSVDkyLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(XfrmBangDiemHetMon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                XfrmBangDiemHetMon f = new XfrmBangDiemHetMon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(XfrmPhieuDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                XfrmPhieuDiem f = new XfrmPhieuDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Xfrm_dsDongHocPhi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Xfrm_dsDongHocPhi f = new Xfrm_dsDongHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Xfrm_BangDiemTongKet));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Xfrm_BangDiemTongKet f = new Xfrm_BangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDongHocPhi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDongHocPhi f = new frmDongHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }
    }

}
