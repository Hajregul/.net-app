using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB120045_UI
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
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik.KorisnickoIme == "admin")
                {
                    Application.Run(new Meni());
                }
                else
                {
                    Application.Run(new MainRadnik());
                }
            }


        }
    }
}
