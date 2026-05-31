using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaVinilJogo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashForm splashForm = new SplashForm();
            splashForm.Show();
            Application.DoEvents();//renderiza a tela

            System.Threading.Thread.Sleep(2000); //criar delay
            splashForm.Close();

            Application.Run(new PrincipalForm()); // abre o login após o splash

        }
    }
}
