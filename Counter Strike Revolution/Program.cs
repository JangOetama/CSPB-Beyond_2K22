using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter_Strike_Point_Blank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           if (CJDW.GetFile("Settings.ini", "Setting", "Page") == "Kadal")
            {
                //Application.Run(new formWait());
                //Application.Run(new formCSPBLauncher());
                Application.Run(new ExampleShop());

            }
           else
            {
                Application.Run(new formMainLoading());
            }
            
        }

    }
}
