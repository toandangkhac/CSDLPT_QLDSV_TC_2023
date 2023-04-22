using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace QLDSV_TC
{
    internal static class Program
    {
        public static FormMain formMain;
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-BL3R2J4;Initial Catalog = QLDSV_TC;Integrated Security=True";
        public static SqlDataReader myReader;
        //public static String servername = "";
        //public static String username = "";
        //public static String password = "";
        //public static String database = "QLDSV_TC";
        //public static String remoteLogin = "HTKN";
        //public static String remotePassword = "123456";
        //public static String mLoginDN = "";
        //public static String passwordDN = "";
        //public static String mGroup = "";
        //public static String mHoten = "";
        //public static int mKhoa = 0;


        public static BindingSource bds_dspm = new BindingSource();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            Application.Run(formMain);
        }
    }
}
