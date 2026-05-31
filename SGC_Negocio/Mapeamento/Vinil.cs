using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Negocio.Mapeamento
{
    public class Vinil:Produto
    {
        public int IDProduto { get; set; }
        public string Artista { get; set; }
        public string Gravadora { get; set; }
        public int IDGeneroVinil { get; set; }

        // Virtual - não é campo no banco
        public decimal ValorTotal { get { return ValorUnitario * Quantidade; } }
        public Genero Genero { get; set; }
    }
}
