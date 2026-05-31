using SGC_Negocio.DAO;
using SGC_Negocio.Mapeamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaVinilJogo
{
    public partial class VinilForm : Form
    {
        Vinil vinil = null;

        public VinilForm()
        {
            InitializeComponent();
            descricaoAcaoLabel.Text = "Cadastrar Vinil";
            idTextBox.Text = "Gerando...";
            vinil = new Vinil();
            CarregarGeneros();
        }

        public VinilForm(Vinil vinilEditar)
        {
            InitializeComponent();
            descricaoAcaoLabel.Text = "Alterar Vinil";
            vinil = vinilEditar;
            CarregarGeneros();
            idTextBox.Text = vinil.Id.ToString();
            nomedoVinilTextBox.Text = vinil.Nome;
            artistaTextBox.Text = vinil.Artista;
            gravadoraTextBox.Text = vinil.Gravadora;
            anoTextBox.Text = vinil.Ano.ToString();
            descricaoRichTextBox.Text = vinil.Descricao;
            quantidadeNumericUpDown.Value = vinil.Quantidade;
            valorUnitarioNumericUpDown.Value = vinil.ValorUnitario;
            ativoCheckBox.Checked = vinil.Ativo;
            generoComboBox.SelectedValue = vinil.IDGeneroVinil;

            if (!string.IsNullOrEmpty(vinil.Foto))
            {
                string caminhoFoto = Path.Combine(Application.StartupPath, "Fotos", "Vinis", vinil.Foto);
                if (File.Exists(caminhoFoto))
                    capaAlbumpictureBox.Image = Image.FromFile(caminhoFoto);
            }
        }

        void CarregarGeneros()
        {
            generoComboBox.DataSource = new GeneroDAO("GeneroVinil").Listar();
            generoComboBox.DisplayMember = "Nome";
            generoComboBox.ValueMember = "ID";
        }

        private void enviarCapaVinilbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string nomeFoto = Path.GetFileName(dialog.FileName);
                string pasta = Path.Combine(Application.StartupPath, "Fotos", "Vinis");
                string destino = Path.Combine(pasta, nomeFoto);

                Directory.CreateDirectory(pasta);
                File.Copy(dialog.FileName, destino, true);

                capaAlbumpictureBox.Image = Image.FromFile(destino);
                vinil.Foto = nomeFoto;
            }
        }

        private void salvarVinilButton_Click(object sender, EventArgs e)
        {
            vinil.Nome = nomedoVinilTextBox.Text;
            vinil.Artista = artistaTextBox.Text;
            vinil.Gravadora = gravadoraTextBox.Text;
            vinil.Ano = Convert.ToInt32(anoTextBox.Text);
            vinil.Descricao = descricaoRichTextBox.Text;
            vinil.Quantidade = Convert.ToInt32(quantidadeNumericUpDown.Value);
            vinil.ValorUnitario = valorUnitarioNumericUpDown.Value;
            vinil.Ativo = ativoCheckBox.Checked;
            vinil.IDGeneroVinil = (int)generoComboBox.SelectedValue;

            var resp = new VinilDAO().Salvar(vinil);

            if (resp == 0)
            {
                MessageBox.Show("Erro ao salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                idTextBox.Text = resp.ToString();
                MessageBox.Show($"Vinil {resp} - {vinil.Nome} salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fecharVinilButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void middleCadastrarClientePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fecharVinilButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}