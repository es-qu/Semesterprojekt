using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    internal static class Program
    {
        private static bool auth = false;
        public static bool Auth { get { return auth; } set { auth = value; } }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

            if (auth)
            {
                Application.Run(new FormMenu());
            }
        }
    }
}
