using SGC_Negocio.DAO;
using SGC_Negocio.Mapeamento;
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
    public partial class ClienteListarForm : Form
    {
        public ClienteListarForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }
        void AplicarPermissoes()
        {
            if (AreaCompartilhada.UsuarioLogado.TipoUsuario == 2)
            {
                alterarClienteButton.Enabled = false;
                excluirClienteButton.Enabled = false;
            }
        }
        void Listar()
        {
            var info = new ClienteDAO().Listar();
            //faz os filtros
            if (pesquisarClienteTextBox.Text.Trim().Length > 0)
            {
                info = info.Where(w => w.NomeCompleto.ToUpper().Contains(pesquisarClienteTextBox.Text.ToUpper().Trim())).ToList(); //lambda expressions
            }
            if (filtroAtivoClienteRadioButton.Checked)
            {
                info = info.Where(w => w.Ativo == true).ToList();
            }
            else if (filtroInativoClienteRadioButton.Checked)
            {
                info = info.Where(w => w.Ativo == false).ToList();

            }
            excluirClienteButton.Enabled = info.Count > 0;
            alterarClienteButton.Enabled = info.Count > 0;
            AplicarPermissoes();

            clienteDataGridView.DataSource = info;

            qtdClientesLabel.Text = $"{info.Count} cliente(s) encontrado(s)";
        }
        private void inserirClienteButton_Click(object sender, EventArgs e)
        {
            new ClienteForm().ShowDialog();
            Listar();
        }

        private void listarClienteButton_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void ClienteListarForm_Shown(object sender, EventArgs e)
        {
            excluirClienteButton.Enabled = false;
            alterarClienteButton.Enabled = false;
        }

        private void fecharClienteButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        int idMarcado = 0;
        void VerificarSelecao()
        {
            idMarcado = 0;
            try
            {
                idMarcado = Convert.ToInt32(clienteDataGridView.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinto muito!! Estamos com um erro ao selecionar: \n" + ex.Message);
            }
        }

        private void excluirClienteButton_Click(object sender, EventArgs e)
        {
            VerificarSelecao();
            if (idMarcado > 0)
            {
                if (MessageBox.Show("Você tem certeza que deseja excluir esse cliente? Essa ação não poderá ser desfeita?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resp = new ClienteDAO().Excluir(idMarcado);
                    if (resp == false)
                    {
                        MessageBox.Show("Erro ao excluir cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("O cliente foi excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Listar();
                }

            }
        }

        private void alterarClienteButton_Click(object sender, EventArgs e)
        {
            var clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
            new ClienteForm(clienteSelecionado).ShowDialog();
        }

      
    }
}
