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
    public partial class GeneroForm : Form
    {
        Genero genero = null;

        public GeneroForm()
        {
            InitializeComponent();
            idVinilTextBox.Text = "Gerando...";
            genero = new Genero();
        }

        public GeneroForm(Genero generoEditar)
        {
            InitializeComponent();
            genero = generoEditar;
            descricaoAcaoGeneroLabel.Text = "Alterar Gênero Vinil";
            idVinilTextBox.Text = genero.ID.ToString();
            nomeGeneroVinilTextBox.Text = genero.Nome;
            ativoCheckBox.Checked = genero.Ativo;
        }

        private void salvarGeneroButton_Click(object sender, EventArgs e)
        {
            genero.Nome = nomeGeneroVinilTextBox.Text;
            genero.Ativo = ativoCheckBox.Checked;

            var resp = new GeneroDAO("GeneroVinil").Salvar(genero);

            if (resp == 0)
            {
                MessageBox.Show("Erro ao salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                idVinilTextBox.Text = resp.ToString();
                MessageBox.Show($"Gênero {resp} - {genero.Nome} salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fecharVinilButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}