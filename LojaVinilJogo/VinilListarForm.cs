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
    public partial class VinilListarForm : Form
    {
        public VinilListarForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }
        void AplicarPermissoes()
        {
            if (AreaCompartilhada.UsuarioLogado.TipoUsuario == 2)
            {
                alterarVinilButton.Enabled = false;
                excluirVinilButton.Enabled = false;
            }
        }
        void Listar()
        {
            var dados = new VinilDAO().Listar();
            if (pesquisarVinilTextBox.Text.Trim().Length > 0)
            {
                dados = dados.Where(w => w.Nome.ToUpper().Contains(pesquisarVinilTextBox.Text.ToUpper().Trim())).ToList(); //lambda expressions
            }
            if (filtroAtivoVinilRadioButton.Checked)
            {
                dados = dados.Where(w => w.Ativo == true).ToList();
            }
            else if (filtroInativoVinilRadioButton.Checked)
            {
                dados = dados.Where(w => w.Ativo == false).ToList();

            }
            excluirVinilButton.Enabled = dados.Count > 0;
            alterarVinilButton.Enabled = dados.Count > 0;
            AplicarPermissoes();

            vinilDataGridView.DataSource = dados;

            qtdVinilLabel.Text = $"{dados.Count} vinil(is) encontrado(s)";

        }
        private void listarVinilButton_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void VinilListarForm_Shown(object sender, EventArgs e)
        {
            excluirVinilButton.Enabled = false;
            alterarVinilButton.Enabled = false;
        }

        private void fecharVinilButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        int idMarcado = 0;
        void VerificarSelecao()
        {
            idMarcado = 0;
            try
            {
                idMarcado = Convert.ToInt32(vinilDataGridView.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinto muito!! Estacomos com um erro ao selecionar: \n" + ex.Message);
            }
        }

        private void excluirVinilButton_Click(object sender, EventArgs e)
        {
            VerificarSelecao();
            if (idMarcado > 0)
            {
                if (MessageBox.Show("Você tem certeza que deseja excluir esse vinil? Essa ação não poderá ser desfeita!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resp = new VinilDAO().Excluir(idMarcado);
                    if (resp == false)
                    {
                        MessageBox.Show("Erro ao excluir vinil", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("O vinil foi excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Listar();
                }

            }
        }

        private void alterarVinilButton_Click(object sender, EventArgs e)
        {
            var vinilSelecionado = (Vinil)vinilDataGridView.CurrentRow.DataBoundItem;
            new VinilForm(vinilSelecionado).ShowDialog();
        }

        private void inserirVinilButton_Click(object sender, EventArgs e)
        {
            new VinilForm().ShowDialog();
            Listar();
        }
    }
}
