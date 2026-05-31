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
    public partial class GeneroJogoForm : Form
    {
        Genero genero = null;

        public GeneroJogoForm()
        {
            InitializeComponent();
            idTextBox.Text = "Gerando...";
            genero = new Genero();
        }

        public GeneroJogoForm(Genero generoEditar)
        {
            InitializeComponent();
            genero = generoEditar;
            descricaoAcaoGeneroLabel.Text = "Alterar Gênero Jogo";  
            idTextBox.Text = genero.ID.ToString();
            nomeGeneroTextBox.Text = genero.Nome;
            ativoCheckBox.Checked = genero.Ativo;
        }

        private void salvarGeneroButton_Click(object sender, EventArgs e)
        {
            genero.Nome = nomeGeneroTextBox.Text;
            genero.Ativo = ativoCheckBox.Checked;

            var resp = new GeneroDAO("GeneroJogo").Salvar(genero);

            if (resp == 0)
            {
                MessageBox.Show("Erro ao salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                idTextBox.Text = resp.ToString();
                MessageBox.Show($"Gênero {resp} - {genero.Nome} salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fecharGeneroButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}