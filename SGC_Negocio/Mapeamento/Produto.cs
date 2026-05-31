using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Negocio.Mapeamento
{
    public class Produto
    {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public int Ano { get; set; }
            public int Quantidade { get; set; }
            public decimal ValorUnitario { get; set; }
            public string Foto { get; set; }
            public bool Ativo { get; set; }

            // só pra identificar na vitrine
            public string TipoProduto { get; set; }
            public string Artista { get; set; }
            public string Estudio { get; set; }
    }
    }

