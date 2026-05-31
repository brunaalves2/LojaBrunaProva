using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SGC_Negocio
{
    public class Conexao
    {
        public SqlConnection banco = null;
        public Conexao()
        {
            banco = new SqlConnection("Data Source=.;Initial Catalog=BrunaLojaVinis;Integrated Security=true;Column Encryption Setting=enabled;");

        }
    }
}
