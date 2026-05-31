using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LojaVinilJogo
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            splashFormProgressBar.Value = 0;
            splashFormProgressBar.Minimum = 0;
            splashFormProgressBar.Maximum = 9;
            var msg = "Iniciando o sistema...;Conectando ao seu banco...;Ajustando visual; Carregando Games...; Carregando Vinis...; Usuários a postos...; Clientes prontos para as compras...; Finalizando...; Abrindo!".Split(';');
            for (int i = 1; i <= 9; i++)
            {
                textoCarregamentolabel.Text = $"{msg[i - 1]} {i} de 9";//I-1 PORQ O FOR COMEÇOU NO 1
                splashFormProgressBar.Value = i;
                Application.DoEvents();
                System.Threading.Thread.Sleep(400);
                //AUTOSIZE LABEL FALSE
            }
        }

    }
}
