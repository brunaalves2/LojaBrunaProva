using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Negocio.Mapeamento
{
    public class Jogo : Produto
    {
        public int IDProduto { get; set; }
        public string Estudio { get; set; }
        public string Plataforma { get; set; }
        public int IDGeneroJogo { get; set; }
        public Genero Genero { get; set; }
    }
}
