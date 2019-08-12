using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_411
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private static string _name = "No Current User";
        private static string _role = "No Current Role";

        public static class currentUser
        {
            public static string name
            {
                get { return _name; }
                set { _name = value; }
            }
            public static string role
            {
                get { return _role; }
                set { _role = value; }
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
