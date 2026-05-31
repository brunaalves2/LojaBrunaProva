using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SGC_Negocio.Mapeamento;

namespace SGC_Negocio.DAO
{
    public class GeneroDAO : Conexao
    {
        private string _tabela;

        public GeneroDAO(string tabela)
        {
            _tabela = tabela;
        }

        public List<Genero> Listar(bool? soAtivos = null)
        {
            string sql =
                "SELECT * " +
                $"FROM {_tabela} " +
                "WHERE 1 = 1 ";

            if (soAtivos != null)
                sql += "AND Ativo = @ativo ";

            sql += "ORDER BY Nome";

            return banco.Query<Genero>
                (sql,
                new { ativo = soAtivos != null ? soAtivos.Value : false }
                ).ToList();
        }

        public Genero Buscar(int id)
        {
            return banco.Query<Genero>(
                "SELECT * " +
                $"FROM {_tabela} " +
                "WHERE Id = @pID",
                new { pID = id }
                ).SingleOrDefault();
        }

        private int Inserir(Genero genero)
        {
            return banco.Query<int>(
                $"INSERT INTO {_tabela} (Nome, Ativo) " +
                "VALUES (@Nome, @Ativo) " +
                "SELECT @@IDENTITY",
                genero).Single();
        }

        private int Alterar(Genero genero)
        {
            var resp = banco.Execute(
                $"UPDATE {_tabela} SET " +
                "Nome = @Nome, Ativo = @Ativo " +
                "WHERE Id = @ID",
                genero);

            return resp == 0 ? 0 : genero.ID;
        }

        public int Salvar(Genero genero)
        {
            if (genero == null || genero.Nome.Trim().Length == 0)
                return 0;

            if (genero.ID == 0)
                return Inserir(genero);
            else
                return Alterar(genero);
        }

        public bool Excluir(int id)
        {
            try
            {
                var resp = banco.Execute(
                    $"DELETE FROM {_tabela} WHERE Id = @pID",
                    new { pID = id });
                return resp == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}