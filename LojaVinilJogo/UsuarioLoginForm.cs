using SGC_Negocio.DAO;
using SGC_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaVinilJogo
{
    public partial class UsuarioLoginForm : Form
    {
        public UsuarioLoginForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
         //variavel usuario recebe o DAO onde contem a função login e seus atributos//parametros
            var usuario = new UsuarioDAO().Login(emailLoginTextBox.Text, senhaLoginTextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Erro ao fazer login - usuário ou senha inválido!", "Acesso inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (usuario.Ativo == false)
            {
                MessageBox.Show("Erro ao fazer login - esse usuário foi desativado!", "Acesso inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AreaCompartilhada.UsuarioLogado = usuario;
            Close();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
