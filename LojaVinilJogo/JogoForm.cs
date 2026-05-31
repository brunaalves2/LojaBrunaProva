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
    public partial class JogoForm : Form
    {
        Jogo jogo = null;

        public JogoForm()
        {
            InitializeComponent();
            descricaoAcaoJogoLabel.Text = "Cadastrar Jogo";
            idTextBox.Text = "Gerando...";
            plataformasTextBox.Text = "Ex: PS5; Xbox; PC; Switch";
            jogo = new Jogo();
            CarregarGeneros();
        }

        public JogoForm(Jogo jogoEditar)
        {
            InitializeComponent();
            descricaoAcaoJogoLabel.Text = "Alterar Jogo";
            jogo = jogoEditar;
            CarregarGeneros();

            idTextBox.Text = jogo.Id.ToString();
            nomedoJogoTextBox.Text = jogo.Nome;
            artistaTextBox.Text = jogo.Estudio;
            plataformasTextBox.Text = jogo.Plataforma;
            anoTextBox.Text = jogo.Ano.ToString();
            descricaoRichTextBox.Text = jogo.Descricao;
            quantidadeNumericUpDown.Value = jogo.Quantidade;
            valorUnitarioNumericUpDown.Value = jogo.ValorUnitario;
            ativoCheckBox.Checked = jogo.Ativo;
            generoComboBox.SelectedValue = jogo.IDGeneroJogo;

            if (!string.IsNullOrEmpty(jogo.Foto))
            {
                string caminhoFoto = Path.Combine(Application.StartupPath, "Fotos", "Jogos", jogo.Foto);
                if (File.Exists(caminhoFoto))
                    capaJogoPictureBox.Image = Image.FromFile(caminhoFoto);
            }
        }

        void CarregarGeneros()
        {
            generoComboBox.DataSource = new GeneroDAO("GeneroJogo").Listar();
            generoComboBox.DisplayMember = "Nome";
            generoComboBox.ValueMember = "ID";
        }

        private void plataformasTextBox_Enter(object sender, EventArgs e)
        {
            if (plataformasTextBox.Text == "Ex: PS5; Xbox; PC; Switch")
                plataformasTextBox.Text = "";
        }

        private void plataformasTextBox_Leave(object sender, EventArgs e)
        {
            if (plataformasTextBox.Text.Trim() == "")
                plataformasTextBox.Text = "Ex: PS5; Xbox; PC; Switch";
        }

        private void enviarCapaJogoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string nomeFoto = Path.GetFileName(dialog.FileName);
                string pasta = Path.Combine(Application.StartupPath, "Fotos", "Jogos");
                string destino = Path.Combine(pasta, nomeFoto);

                Directory.CreateDirectory(pasta);
                File.Copy(dialog.FileName, destino, true);

                capaJogoPictureBox.Image = Image.FromFile(destino);
                jogo.Foto = nomeFoto;
            }
        }

        private void salvarJogoButton_Click(object sender, EventArgs e)
        {
            jogo.Nome = nomedoJogoTextBox.Text;
            jogo.Estudio = artistaTextBox.Text;
            jogo.Plataforma = plataformasTextBox.Text == "Ex: PS5; Xbox; PC; Switch" ? "" : plataformasTextBox.Text;
            jogo.Ano = Convert.ToInt32(anoTextBox.Text);
            jogo.Descricao = descricaoRichTextBox.Text;
            jogo.Quantidade = Convert.ToInt32(quantidadeNumericUpDown.Value);
            jogo.ValorUnitario = valorUnitarioNumericUpDown.Value;
            jogo.Ativo = ativoCheckBox.Checked;
            jogo.IDGeneroJogo = (int)generoComboBox.SelectedValue;

            var resp = new JogoDAO().Salvar(jogo);

            if (resp == 0)
            {
                MessageBox.Show("Erro ao salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                idTextBox.Text = resp.ToString();
                MessageBox.Show($"Jogo {resp} - {jogo.Nome} salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fecharJogoButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}