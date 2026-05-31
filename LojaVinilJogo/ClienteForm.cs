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
    public partial class ClienteForm : Form
    {
        Cliente cliente = null;

        public ClienteForm()
        {
            InitializeComponent();
            this.Text = "Novo Cliente";
            idTextBox.Text = "Gerando...";
            cliente = new Cliente();
        }

        private void fecharClienteButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarClienteButton_Click(object sender, EventArgs e)
        {
            cliente.NomeCompleto = nomeCompletoTextBox.Text;
            cliente.DataNascimento = dataNascimentoDateTimePicker.Value;
            cliente.Sexo = sexoComboBox.Text;
            cliente.CPF = cpfTextBox.Text;
            cliente.Endereco = enderecoTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;
            cliente.Ativo = ativoCheckBox.Checked;

            var resp = new ClienteDAO().Salvar(cliente);

            if (resp == 0)
            {
                MessageBox.Show("Erro ao salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Cliente {resp} - {cliente.NomeCompleto} salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public ClienteForm(Cliente clienteEditar)
        {
            InitializeComponent();
            descricaoAcaoClienteLabel.Text = "Alterar Cliente";
            cliente = clienteEditar;
            idTextBox.Text = cliente.ID.ToString();
            nomeCompletoTextBox.Text = cliente.NomeCompleto;
            dataNascimentoDateTimePicker.Value = cliente.DataNascimento;
            sexoComboBox.Text = cliente.Sexo;
            cpfTextBox.Text = cliente.CPF;
            enderecoTextBox.Text = cliente.Endereco;
            emailTextBox.Text = cliente.Email;
            telefoneTextBox.Text = cliente.Telefone;
            ativoCheckBox.Checked = cliente.Ativo;
        }
    }
}