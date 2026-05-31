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

    public partial class VitrineProdutoPesquisaForm : Form
    {
        //variaveis que irei usar na minha contagem de paginas
        int paginaAtual = 1;
        int itensPorPagina = 10;
        int totalPaginas = 1;
        public VitrineProdutoPesquisaForm() 
        {
            InitializeComponent();
            Application.DoEvents();
        }
        Panel CriarCard(Produto produto) // to criando um metodo que recebe produto e devolve um panel 
        {
            Panel card = new Panel(); // crio uma varivel card do tipo panel e armazeno um novo panel 
            card.Size = new Size(200, 340); //tamnho do meu card
            card.BorderStyle = BorderStyle.FixedSingle; //tipo da borda
            card.Margin = new Padding(10); //espaçamnto entre os cards
            card.BackColor = Color.White;//cor de fundo

            //elemento que vai dentro do card
            PictureBox foto = new PictureBox();
            foto.Size = new Size(180, 180);
            foto.Location = new Point(10, 10);
            foto.SizeMode = PictureBoxSizeMode.Zoom;
            card.Controls.Add(foto);

            if (!string.IsNullOrEmpty(produto.Foto)) //verifico se um produto tem foto ou não
            {
                string pasta = produto.TipoProduto == "Vinil" ? "Vinis" : "Jogos"; //uso um operador ternário para decidir em qual pasta vou entrar baseado no tipo de produto
                string caminho = Path.Combine(Application.StartupPath, "Fotos", pasta, produto.Foto); //montando um caminho para a imagem  o path combine quem junta tudo com as barras
                if (File.Exists(caminho)) //verifica se o arquivo de imagem realmente existe naquele caminho, para não dar erro
                    foto.Image = Image.FromFile(caminho); //carrego a imagem do arquivo dentro do pictureBox
            }

            //montando o tiutlo
            Label titulo = new Label();
            titulo.Text = produto.Nome; // potitulo da imagem virá do titulo ja adicionado na variavel nome
            titulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            titulo.Location = new Point(10, 195);
            titulo.Size = new Size(180, 40);
            titulo.AutoEllipsis = true;
            card.Controls.Add(titulo);

            //para determinar cantor ou estúdio
            Label autor = new Label();
            autor.Text = produto.TipoProduto == "Vinil" ? produto.Artista : produto.Estudio; // operador ternário que detemrina se será cantor (vinil) ou estúdio(game)
            autor.Font = new Font("Segoe UI", 8);
            autor.ForeColor = Color.Gray;
            autor.Location = new Point(10, 218);
            autor.Size = new Size(180, 20);
            card.Controls.Add(autor);

            //preço
            Label preco = new Label();
            preco.Text = produto.ValorUnitario.ToString("C"); //tipo C é para moedas
            preco.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            preco.ForeColor = Color.Green;
            preco.Location = new Point(10, 245);
            preco.Size = new Size(180, 25);
            card.Controls.Add(preco);

            //tag
            Label tag = new Label();
            tag.Text = produto.TipoProduto == "Vinil" ? "#vinil" : "#game"; //o operador ternário determina se vai ser vinil ou game baseado do tipo do produto
            tag.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            tag.ForeColor = Color.White;
            tag.BackColor = produto.TipoProduto == "Vinil" ? Color.MediumPurple : Color.SteelBlue; //operador ternário determina a cor da tag baseado no tipo do produto
            tag.Location = new Point(10, 275);
            tag.Size = new Size(60, 22);
            tag.TextAlign = ContentAlignment.MiddleCenter;
            card.Controls.Add(tag);

            return card; 
        }
        void Listar()
        {
            // limpa os cards antigos antes de listar de novo
            produtosFlowLayoutPanel.Controls.Clear();

            // cria a lista que vai guardar os produtos
            List<Produto> dados;

            // verifica qual radio está marcado para decidir o que listar
            if (vinilRadioButton.Checked)
                dados = new ProdutoDAO().ListarPorTipo("Vinil"); // lista só vinis
            else if (jogoRadioButton.Checked)
                dados = new ProdutoDAO().ListarPorTipo("Jogo"); // lista só jogos
            else
                dados = new ProdutoDAO().ListarTodos(); // lista todos (vinis e jogos)

            // mantém só os produtos que têm estoque maior que 0
            dados = dados.Where(p => p.Quantidade > 0).ToList();

            // filtra pelo nome digitado na busca
            if (pesquisarProdutoTextBox.Text.Trim().Length > 0) //checo se tem texto digitado na barra o trim remove espaços em branco
            {
                dados = dados.Where(p => p.Nome.ToUpper().Contains(
                    pesquisarProdutoTextBox.Text.ToUpper().Trim())).ToList();
            }
            // calcula o total de páginas
            totalPaginas = (int)Math.Ceiling(dados.Count / (double)itensPorPagina);//arredonda pra cima(ex: 25 produtos / 10 = 2, 5 -> 3 páginas)
            if (totalPaginas == 0) totalPaginas = 1;

            // pega só os produtos da página atual
            dados = dados
                .Skip((paginaAtual - 1) * itensPorPagina)//ondevai passar
                .Take(itensPorPagina) //pega os produtos
                .ToList();

            // mostra a página atual no label
            numeroPaginaLabel.Text = $"Página {paginaAtual} de {totalPaginas}";

            // percorre cada produto e cria um card para ele no flowlayoutpanel
            foreach (var produto in dados)
            {
                produtosFlowLayoutPanel.Controls.Add(CriarCard(produto));
            }


            // mostra no rodapé quantos produtos foram encontrados
            qtdLabel.Text = $"{dados.Count} produto(s) encontrado(s)";
        }

        private void numeroPaginaLabel_Click(object sender, EventArgs e)
        {

        }

        private void VitrineProdutoPesquisaForm_Shown(object sender, EventArgs e)
        {
            Listar();

        }

        private void pesquisarProdutoTextBox_TextChanged(object sender, EventArgs e)
        {
            paginaAtual = 1; //volta p/ página 1 quando eu começar a digitar
            Listar();
        }

        private void todosRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            paginaAtual = 1; //volta para o ínicio quando eu trocar a opção
            Listar();

        }

        private void anteriorButton_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 1) //só volta se página for maior que 1
            {
                paginaAtual--;
                Listar();
            }
        }

        private void proximoButton_Click(object sender, EventArgs e)
        {
            if (paginaAtual < totalPaginas) //só avanã se a pagina atual for menor que o numero total, ou seja não passa p ultima pagina direto
            {
                paginaAtual++;
                Listar();
            }
        }

      
    }
}
