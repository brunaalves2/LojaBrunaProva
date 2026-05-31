using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Negocio.Mapeamento
{
    public class Genero
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        // Virtual - não é campo no banco
        public override string ToString()
        {
            return Nome;
        }
    }
}