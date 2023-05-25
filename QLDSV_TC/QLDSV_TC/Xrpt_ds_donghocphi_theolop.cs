using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class Xrpt_ds_donghocphi_theolop : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_ds_donghocphi_theolop()
        {
            InitializeComponent();
        }
        public Xrpt_ds_donghocphi_theolop(string malop, string nienkhoa, int hocky)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocky;
            this.sqlDataSource1.Fill();
        }
    }
}
