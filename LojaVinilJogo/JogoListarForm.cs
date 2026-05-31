using SGC_Negocio;
using SGC_Negocio.DAO;
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
    public partial class JogoListarForm : Form
    {
        public JogoListarForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }
        void AplicarPermissoes()
        {
            if (AreaCompartilhada.UsuarioLogado.TipoUsuario == 2)
            {
                alterarJogoButton.Enabled = false;
                excluirJogoButton.Enabled = false;
            }
        }
        void Listar()
        {
            var info = new JogoDAO().Listar();

            if (pesquisarJogoTextBox.Text.Trim().Length > 0)
            {
                info = info.Where(w => w.Nome.ToUpper().Contains(
                    pesquisarJogoTextBox.Text.ToUpper().Trim())).ToList();
            }

            if (filtroAtivoJogoRadioButton.Checked)
                info = info.Where(w => w.Ativo == true).ToList();
            else if (filtroInativoJogoRadioButton.Checked)
                info = info.Where(w => w.Ativo == false).ToList();

            excluirJogoButton.Enabled = info.Count > 0;
            alterarJogoButton.Enabled = info.Count > 0;
            AplicarPermissoes();

            jogoGridView.DataSource = info;

            qtdJogosLabel.Text = $"{info.Count} jogo(s) encontrado(s)";

        }

        int idMarcado = 0;

        void VerificarSelecao()
        {
            idMarcado = 0;
            try
            {
                idMarcado = Convert.ToInt32(
                    jogoGridView.SelectedRows[0]
                    .Cells["iDDataGridViewTextBoxColumn"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinto muito!! Estamos com um erro ao selecionar: \n" + ex.Message);
            }
        }

        private void JogoListarForm_Shown(object sender, EventArgs e)
        {
            excluirJogoButton.Enabled = false;
            alterarJogoButton.Enabled = false;
        }

        private void listarJogoButton_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void inserirJogoButton_Click(object sender, EventArgs e)
        {
            new JogoForm().ShowDialog();
            Listar();
        }

        private void alterarJogoButton_Click(object sender, EventArgs e)
        {
            var jogoSelecionado = (Jogo)jogoGridView.CurrentRow.DataBoundItem;
            new JogoForm(jogoSelecionado).ShowDialog();
            Listar();
        }

        private void excluirJogoButton_Click(object sender, EventArgs e)
        {
            VerificarSelecao();
            if (idMarcado > 0)
            {
                if (MessageBox.Show("Você tem certeza que deseja excluir esse jogo? Essa ação não poderá ser desfeita!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resp = new JogoDAO().Excluir(idMarcado);
                    if (resp == false)
                        MessageBox.Show("Erro ao excluir jogo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Jogo excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                }
            }
        }

        private void fecharJogoButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}