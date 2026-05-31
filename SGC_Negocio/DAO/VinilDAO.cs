using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SGC_Negocio.Mapeamento;

namespace SGC_Negocio.DAO
{
    public class VinilDAO : Conexao
    {
        public Vinil Buscar(int id)
        {
            var resp = banco.Query<Vinil>
                ("SELECT v.*, p.Nome, p.Descricao, p.Ano, p.Quantidade, p.ValorUnitario, p.Foto, p.Ativo " +
                "FROM Vinil v " +
                "INNER JOIN Produto p ON p.Id = v.IDProduto " +
                "WHERE v.Id = @pID",
                new { pID = id }).SingleOrDefault();

            if (resp != null)
                resp.Genero = new GeneroDAO("GeneroVinil").Buscar(resp.IDGeneroVinil);

            return resp;
        }

        public List<Vinil> Listar()
        {
            var lista = banco.Query<Vinil>
                ("SELECT v.*, p.Nome, p.Descricao, p.Ano, p.Quantidade, p.ValorUnitario, p.Foto, p.Ativo " +
                "FROM Vinil v " +
                "INNER JOIN Produto p ON p.Id = v.IDProduto " +
                "ORDER BY p.Nome").ToList();

            var generoDAO = new GeneroDAO("GeneroVinil");
            foreach (var item in lista) { 
                item.Genero = generoDAO.Buscar(item.IDGeneroVinil);
                item.TipoProduto = "Vinil";
            }


            return lista;
        }

        public bool Excluir(int id)
        {
            try
            {
                // Busca o IDProduto antes de excluir
                var vinil = Buscar(id);
                banco.Execute("DELETE FROM Vinil WHERE Id = @pID", new { pID = id });
                banco.Execute("DELETE FROM Produto WHERE Id = @pID", new { pID = vinil.IDProduto });
                return true;
            }
            catch
            {
                return false;
            }
        }

        private int Inserir(Vinil vinil)
        {
            // Primeiro insere em Produto
            var idProduto = banco.Query<int>
                ("INSERT INTO Produto (Nome, Descricao, Ano, Quantidade, ValorUnitario, Foto, Ativo) " +
                "VALUES (@Nome, @Descricao, @Ano, @Quantidade, @ValorUnitario, @Foto, @Ativo) " +
                "SELECT @@IDENTITY", vinil).Single();

            // Depois insere em Vinil
            return banco.Query<int>
                ("INSERT INTO Vinil (IDProduto, Artista, Gravadora, IDGeneroVinil) " +
                "VALUES (@IDProduto, @Artista, @Gravadora, @IDGeneroVinil) " +
                "SELECT @@IDENTITY",
                new
                {
                    IDProduto = idProduto,
                    vinil.Artista,
                    vinil.Gravadora,
                    vinil.IDGeneroVinil
                }).Single();
        }

        private int Alterar(Vinil vinil)
        {
            // Atualiza Produto
            banco.Execute(
                "UPDATE Produto SET " +
                "Nome = @Nome, Descricao = @Descricao, Ano = @Ano, " +
                "Quantidade = @Quantidade, ValorUnitario = @ValorUnitario, " +
                "Foto = @Foto, Ativo = @Ativo " +
                "WHERE Id = @IDProduto", vinil);

            // Atualiza Vinil
            var resp = banco.Execute(
                "UPDATE Vinil SET " +
                "Artista = @Artista, Gravadora = @Gravadora, IDGeneroVinil = @IDGeneroVinil " +
                "WHERE Id = @ID", vinil);

            return resp == 0 ? 0 : vinil.Id;
        }

        public Int32 Salvar(Vinil vinil)
        {
            if (vinil == null || vinil.Nome.Trim().Length == 0)
                return 0;

            if (vinil.Id == 0)
                return Inserir(vinil);
            else
                return Alterar(vinil);
        }
    }
}