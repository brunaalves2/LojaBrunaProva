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
    public partial class GeneroListarForm : Form
    {
        public GeneroListarForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        void Listar()
        {
            var info = new GeneroDAO("GeneroVinil").Listar();

            if (pesquisarGeneroTextBox.Text.Trim().Length > 0)
            {
                info = info.Where(w => w.Nome.ToUpper().Contains(
                    pesquisarGeneroTextBox.Text.ToUpper().Trim())).ToList();
            }

            if (filtroAtivoGeneroRadioButton.Checked)
            {
                info = info.Where(w => w.Ativo == true).ToList();
            }
            else if (filtroInativoGeneroRadioButton.Checked)
            {
                info = info.Where(w => w.Ativo == false).ToList();
            }

            excluirGeneroButton.Enabled = info.Count > 0;
            alterarGeneroButton.Enabled = info.Count > 0;

            generoDataGridView.DataSource = info;

            qtdGenerosLabel.Text = $"{info.Count} gênero(s) encontrado(s)";

        }

        int idMarcado = 0;

        void VerificarSelecao()
        {
            idMarcado = 0;
            try
            {
                idMarcado = Convert.ToInt32(
                    generoDataGridView.SelectedRows[0]
                    .Cells["iDDataGridViewTextBoxColumn"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinto muito!! Estamos com um erro ao selecionar: \n" + ex.Message);
            }
        }

        private void listarGeneroButton_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void excluirGeneroButton_Click(object sender, EventArgs e)
        {
            VerificarSelecao();
            if (idMarcado > 0)
            {
                if (MessageBox.Show("Você tem certeza que deseja excluir esse gênero? Essa ação não poderá ser desfeita!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resp = new GeneroDAO("GeneroVinil").Excluir(idMarcado);
                    if (resp == false)
                        MessageBox.Show("Erro ao excluir gênero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Gênero excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                }
            }
        }

        private void alterarGeneroButton_Click(object sender, EventArgs e)
        {
            var generoSelecionado = (Genero)generoDataGridView.CurrentRow.DataBoundItem;
            new GeneroForm(generoSelecionado).ShowDialog();
            Listar();
        }
        private void inserirGeneroButton_Click(object sender, EventArgs e)
        {
            new GeneroForm().ShowDialog();
            Listar();
        }

        private void GeneroListarForm_Shown(object sender, EventArgs e)
        {
            excluirGeneroButton.Enabled = false;
            alterarGeneroButton.Enabled = false;
        }

        private void fecharGeneroButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}