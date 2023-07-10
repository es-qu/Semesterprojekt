using MaterialSkin;
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
        }

        public static MaterialSkinManager GetStandardManager()
        {
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo300, Accent.Indigo200, TextShade.WHITE);

            return manager;
        }
    }
}
