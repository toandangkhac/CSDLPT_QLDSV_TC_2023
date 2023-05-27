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
    public partial class Xfrm_BangDiemTongKet : Form
    {
        public Xfrm_BangDiemTongKet()
        {
            InitializeComponent();
        }

        private void Xfrm_BangDiemTongKet_Load(object sender, EventArgs e)
        {
            Program.servername = "DESKTOP-9QNDCS8\\DUCTRONG";
            Program.database = "QLDSV_TC";
            Program.mlogin = "sa";
            Program.password = "123456";
            Program.KetNoi();
            SqlDataReader dstk = Program.ExecSqlDataReader("exec sp_lay_bangdiemtongket 'D15CQCP01'");
            gcBangDiemTK.DataSource = dstk;
        }
    }
}
