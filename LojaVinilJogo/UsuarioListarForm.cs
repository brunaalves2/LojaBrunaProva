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
    public partial class UsuarioListarForm : Form
    {
        public UsuarioListarForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }
        void Listar()
        {
            var info = new UsuarioDAO().Listar(); //crio a variável info e instancio a classe usuarioDao chamando o metodo listar
            if (pesquisarUsuarioTextBox.Text.Trim().Length > 0) //caso o o campo de pesquisa esteja diferente maior q vazio com texto
            {
                info = info.Where(w => w.Nome.ToUpper().Contains(pesquisarUsuarioTextBox.Text.ToUpper().Trim())).ToList(); 
            }
            if (filtroAtivoUsuarioRadioButton.Checked)
            {
                info = info.Where(w => w.Ativo == true).ToList();
            }
            else if (filtroInativoUsuarioRadioButton.Checked)
            {
                info = info.Where(w => w.Ativo == false).ToList();

            }
            excluirUsuarioButton.Enabled = info.Count > 0; //caso a contagem de listar seja >0
            alterarUsuarioButton.Enabled = info.Count > 0; //caso a contagem de listar seja >0
            
            usuarioDataGridView.DataSource = info; // preenche o datagrid com as informações do mapamento usuario
            
            qtdUsuariosLabel.Text = $"{info.Count} usuários(s) encontrado(s)";

        }
        private void listarUsuárioButton_Click(object sender, EventArgs e)
        {
            Listar(); //chamo o método listar
        }
        int idMarcado = 0; //inciio a varivel intMarcado =0 para sabermos qaul id está selecionado no datagridview
        void VerificarSelecao()
        {
            idMarcado = 0; // o id marcado continua 0 dentro da função (inicio)
            try
            {
                idMarcado = Convert.ToInt32(usuarioDataGridView.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value); //confiro o id que está selecionado atrvés da linha id do datagridview 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinto muito!! Estamos com um erro ao selecionar: \n" + ex.Message);
            }
        }
        private void excluirUsuarioButton_Click(object sender, EventArgs e)
        {
            VerificarSelecao();
            if (idMarcado > 0)
            {
                if (MessageBox.Show("Você tem certeza que deseja excluir esse usuário? Essa ação não poderá ser desfeita?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resp = new UsuarioDAO().Excluir(idMarcado);
                    if (resp == false)
                    {
                        MessageBox.Show("Erro ao excluir usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("O usuário foi excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Listar();
                }

            }
        }

        private void inserirUsuarioButton_Click(object sender, EventArgs e)
        {
            new UsuarioForm().ShowDialog(); //chamo o formulário de cadastro para abri-lo
            Listar(); //depois de cadstrar coloco os dados dentro do listar  as informações mais recentes
        }

        private void alterarUsuarioButton_Click(object sender, EventArgs e)
        {
            var usuarioSelecionado = (Usuario)usuarioDataGridView.CurrentRow.DataBoundItem; //a varivel usuario recebe os dados do Usuario mapamento dentro do datagridview na respectiva linha com o DataBoundItem que é é uma propriedade que permite acessar o objeto de dado origina
            new UsuarioForm(usuarioSelecionado).ShowDialog();
            Listar();
        }

        private void fecharUsuarioButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UsuarioListarForm_Shown(object sender, EventArgs e)
        {
            excluirUsuarioButton.Enabled = false;
            alterarUsuarioButton.Enabled = false;
        }
    }
}
