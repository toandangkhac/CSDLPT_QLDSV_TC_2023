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
    public partial class frmLopTinChi : Form
    {
        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            // TODO: This line of code loads data into the 'dS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);

        }
    }
}
