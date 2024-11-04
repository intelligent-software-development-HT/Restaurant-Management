using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    internal static class Program
    {
        public static FormDangNhap formDangNhap;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formDangNhap = new FormDangNhap();
            Application.Run(formDangNhap);
        }
    }
}
