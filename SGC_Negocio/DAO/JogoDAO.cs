using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SGC_Negocio.Mapeamento;

namespace SGC_Negocio.DAO
{
    public class JogoDAO : Conexao
    {
        public Jogo Buscar(int id)
        {
            var resp = banco.Query<Jogo>
                ("SELECT j.*, p.Nome, p.Descricao, p.Ano, p.Quantidade, p.ValorUnitario, p.Foto, p.Ativo " +
                "FROM Jogo j " +
                "INNER JOIN Produto p ON p.Id = j.IDProduto " +
                "WHERE j.Id = @pID",
                new { pID = id }).SingleOrDefault();

            if (resp != null)
                resp.Genero = new GeneroDAO("GeneroJogo").Buscar(resp.IDGeneroJogo);

            return resp;
        }

        public List<Jogo> Listar()
        {
            var lista = banco.Query<Jogo>
                ("SELECT j.*, p.Nome, p.Descricao, p.Ano, p.Quantidade, p.ValorUnitario, p.Foto, p.Ativo " +
                "FROM Jogo j " +
                "INNER JOIN Produto p ON p.Id = j.IDProduto " +
                "ORDER BY p.Nome").ToList();

            var generoDAO = new GeneroDAO("GeneroJogo");
            foreach (var item in lista) { 
            item.Genero = generoDAO.Buscar(item.IDGeneroJogo);
            item.TipoProduto = "Jogo";

        }
            return lista;
        }

        public bool Excluir(int id)
        {
            try
            {
                var jogo = Buscar(id);
                if (jogo == null)
                    return false;

                banco.Execute("DELETE FROM Jogo WHERE Id = @pID", new { pID = id });
                banco.Execute("DELETE FROM Produto WHERE Id = @pID", new { pID = jogo.IDProduto });
                return true;
            }
            catch
            {
                return false;
            }
        }
        private int Inserir(Jogo jogo)
        {
            var idProduto = banco.Query<int>
                ("INSERT INTO Produto (Nome, Descricao, Ano, Quantidade, ValorUnitario, Foto, Ativo) " +
                "VALUES (@Nome, @Descricao, @Ano, @Quantidade, @ValorUnitario, @Foto, @Ativo) " +
                "SELECT @@IDENTITY", jogo).Single();

            return banco.Query<int>
                ("INSERT INTO Jogo (IDProduto, Estudio, Plataforma, IDGeneroJogo) " +
                "VALUES (@IDProduto, @Estudio, @Plataforma, @IDGeneroJogo) " +
                "SELECT @@IDENTITY",
                new
                {
                    IDProduto = idProduto,
                    jogo.Estudio,
                    jogo.Plataforma,
                    jogo.IDGeneroJogo
                }).Single();
        }

        private int Alterar(Jogo jogo)
        {
            banco.Execute(
                "UPDATE Produto SET " +
                "Nome = @Nome, Descricao = @Descricao, Ano = @Ano, " +
                "Quantidade = @Quantidade, ValorUnitario = @ValorUnitario, " +
                "Foto = @Foto, Ativo = @Ativo " +
                "WHERE Id = @IDProduto", jogo);

            var resp = banco.Execute(
                "UPDATE Jogo SET " +
                "Estudio = @Estudio, Plataforma = @Plataforma, IDGeneroJogo = @IDGeneroJogo " +
                "WHERE Id = @ID", jogo);

            return resp == 0 ? 0 : jogo.Id;
        }

        public Int32 Salvar(Jogo jogo)
        {
            if (jogo == null || jogo.Nome .Trim().Length == 0)
                return 0;

            if (jogo.Id == 0)
                return Inserir(jogo);
            else
                return Alterar(jogo);
        }
    }
}