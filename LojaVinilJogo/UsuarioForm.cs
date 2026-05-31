using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGC_Negocio.DAO;
using SGC_Negocio.Mapeamento;

namespace LojaVinilJogo
{
    public partial class UsuarioForm : Form
    {
        Usuario usuario = null; //guarda o objeto usuário que está sendo alterado
        public UsuarioForm()
        {
            InitializeComponent();
            this.Text = "Novo Usuário";
            idTextBox.Text = "Gerando...";
            usuario = new Usuario(); //cria um objeto vazio do mapeamento com os atirbutos
        }

        private void salvarUsuarioButton_Click(object sender, EventArgs e)
        {
            // Se for cadastro novo (ID 0) e a senha estiver vazia, bloqueia
            if (usuario.ID == 0 && senhaTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("A senha é obrigatória para cadastrar um novo usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuario.Nome = nomeCompletoTextBox.Text;
            usuario.Login = emailTextBox.Text;
            if (senhaTextBox.Text.Trim().Length > 0)
                usuario.Senha = senhaTextBox.Text;
            usuario.TipoUsuario = tipoUsuarioComboBox.SelectedIndex + 1;
            usuario.DataCadastro = dataCadastroDateTimePicker.Value;
            usuario.Ativo = ativoCheckBox.Checked;

            var resp = new UsuarioDAO().Salvar(usuario);

            if (resp == 0)
            {
                MessageBox.Show("Erro ao salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                idTextBox.Text = resp.ToString();
                MessageBox.Show($"Usuário {resp} - {usuario.Nome} salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public UsuarioForm(Usuario usuarioEditar)
        {
            InitializeComponent();
            descricaoAcaoUsuarioLabel.Text = "Alterar Usuário";
            usuario = usuarioEditar;
            idTextBox.Text = usuario.ID.ToString();
            nomeCompletoTextBox.Text = usuario.Nome;
            emailTextBox.Text = usuario.Login;
            senhaTextBox.Text = usuario.Senha;
            tipoUsuarioComboBox.SelectedIndex = usuario.TipoUsuario - 1;
            //SelectedIndex começa em 0
            dataCadastroDateTimePicker.Value = usuario.DataCadastro;

            ativoCheckBox.Checked = usuario.Ativo;
        }
        private void fecharUsuarioButton_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
