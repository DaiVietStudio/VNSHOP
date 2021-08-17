using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VNShop
{
    static class Program
    {
        public static string nameUser = "";
        public static long idUser = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new Font("Time New Roman", 12);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
