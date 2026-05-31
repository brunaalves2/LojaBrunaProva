using SGC_Negocio;
using SGC_Negocio.Mapeamento;
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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }
        void ValidandoPermissoesLogin()
        {
            //checando se o usuario logado estiver sem nenhum login realizado para desabilitar todas as funcionalidades do meu menu
            if (AreaCompartilhada.UsuarioLogado == null)
            {
                loginToolStripMenuItem.Text = "Faça o login";

                clienteToolStripMenuItem.Enabled = false;
                vinilToolStripMenuItem.Enabled = false;
                gêneroVinilToolStripMenuItem.Enabled = false;
                jogoToolStripMenuItem.Enabled = false;
                gêneroJogoToolStripMenuItem.Enabled = false;
                usuáriosToolStripMenuItem.Enabled = false;

                usuarioStripStatusLabel.Text = "Não foi detectado nenhum usuário logado!";
            }
            //checando se o usuario logado estiver com algum login realizado para habilitar as funcionalidades do meu menu de acordo com o tipo de usuário

            else
            {
                loginToolStripMenuItem.Text = "Fazer Logoff";
                //permissões para admin
                if (AreaCompartilhada.UsuarioLogado.TipoUsuario == 1)
                {
                    clienteToolStripMenuItem.Enabled = true;
                    vinilToolStripMenuItem.Enabled = true;
                    gêneroVinilToolStripMenuItem.Enabled = true;
                    jogoToolStripMenuItem.Enabled = true;
                    gêneroJogoToolStripMenuItem.Enabled = true;
                    usuáriosToolStripMenuItem.Enabled = true;
                }
                //permissões para operador
                // eu apenas desabilitei funções de botões nos listar então está em cada listar (vinil, nogo e cliente)

                else if (AreaCompartilhada.UsuarioLogado.TipoUsuario == 2)
                {
                    clienteToolStripMenuItem.Enabled = true;
                    vinilToolStripMenuItem.Enabled = true;
                    gêneroVinilToolStripMenuItem.Enabled = false;
                    jogoToolStripMenuItem.Enabled = true;
                    gêneroJogoToolStripMenuItem.Enabled = false;
                    usuáriosToolStripMenuItem.Enabled = false;
                }
                string tipoNome = AreaCompartilhada.UsuarioLogado.TipoUsuario == 1 ? "Admin" : "Operador";
                usuarioStripStatusLabel.Text = $"{AreaCompartilhada.UsuarioLogado.Nome} || Seu tipo de usuário é: {tipoNome}";
            }
        }
        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteListarForm clienteListarForm = new ClienteListarForm();
            clienteListarForm.MdiParent = this;
            clienteListarForm.WindowState = FormWindowState.Maximized;
            clienteListarForm.Show();

        }

        private void gêneroJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneroJogoListarForm generoJogoListarForm = new GeneroJogoListarForm();
            generoJogoListarForm.MdiParent = this;
            generoJogoListarForm.WindowState = FormWindowState.Maximized;
            generoJogoListarForm.Show();
        }

        private void gêneroVinilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneroListarForm generoVinilListarForm = new GeneroListarForm();
            generoVinilListarForm.MdiParent = this;
            generoVinilListarForm.WindowState = FormWindowState.Maximized;
            generoVinilListarForm.Show();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoListarForm jogoListarForm = new JogoListarForm();
            jogoListarForm.MdiParent = this;
            jogoListarForm.WindowState = FormWindowState.Maximized;
            jogoListarForm.Show();
        }

        private void vinilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VinilListarForm vinilListarForm = new VinilListarForm();
            vinilListarForm.MdiParent = this;
            vinilListarForm.WindowState = FormWindowState.Maximized;
            vinilListarForm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreaCompartilhada.UsuarioLogado = null;
            ValidandoPermissoesLogin();
            Application.DoEvents();

            new UsuarioLoginForm().ShowDialog();

            ValidandoPermissoesLogin();
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
               "Deseja realmente fechar o sistema?",
               "Confirme",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2
               ) == DialogResult.No)
                e.Cancel = true;
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioListarForm usuarioListarForm = new UsuarioListarForm();
            usuarioListarForm.MdiParent = this;
            usuarioListarForm.WindowState = FormWindowState.Maximized;
            usuarioListarForm.Show();
        }

        private void PrincipalForm_Shown(object sender, EventArgs e)
        {
            ValidandoPermissoesLogin();
        }

        private void vitrineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VitrineProdutoPesquisaForm vitrineProdutoPesquisaForm = new VitrineProdutoPesquisaForm();
            vitrineProdutoPesquisaForm.MdiParent = this;
            vitrineProdutoPesquisaForm.WindowState = FormWindowState.Maximized;
            vitrineProdutoPesquisaForm.Show();
        }

        private void encerrarOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }
    }
}
