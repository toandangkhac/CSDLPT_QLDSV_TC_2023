using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class Xrpt_PhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_PhieuDiem()
        {
            InitializeComponent();
        }
        public Xrpt_PhieuDiem(string masv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource1.Fill();
        }

    }
}
