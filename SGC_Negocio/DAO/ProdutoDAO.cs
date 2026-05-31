using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SGC_Negocio.Mapeamento;
//SÓ VAI SERVIR PARA LISTAR
namespace SGC_Negocio.DAO
{
    public class ProdutoDAO : Conexao
    {
        //SERVE PARA LISTAR TODOS SEM DISTINÇÃO DE CATEGORIA
        //USA UNION ALL PARA JUNTAR VINIS E JOGOS NUMA LISTA SÓ
        public List<Produto> ListarTodos()
        {
            string sql = @"
                SELECT p.*, v.Artista, NULL AS Estudio, 'Vinil' AS TipoProduto
                FROM Produto p
                INNER JOIN Vinil v ON v.IDProduto = p.Id
                WHERE p.Ativo = 1

                UNION ALL

                SELECT p.*, NULL AS Artista, j.Estudio, 'Jogo' AS TipoProduto
                FROM Produto p
                INNER JOIN Jogo j ON j.IDProduto = p.Id
                WHERE p.Ativo = 1

                ORDER BY Nome";

            return banco.Query<Produto>(sql).ToList();
        }

        //SERVE PARA LISTAR POR TIPO VAMOS USAR NA VITRINE
        public List<Produto> ListarPorTipo(string tipo)
        {
            // tipo = "Vinil" ou "Jogo"
            string sql;

            if (tipo == "Vinil")
            {
                sql = @"
                    SELECT p.*, v.Artista, NULL AS Estudio, 'Vinil' AS TipoProduto
                    FROM Produto p
                    INNER JOIN Vinil v ON v.IDProduto = p.Id
                    WHERE p.Ativo = 1
                    ORDER BY p.Nome";
            }
            else
            {
                sql = @"
                    SELECT p.*, NULL AS Artista, j.Estudio, 'Jogo' AS TipoProduto
                    FROM Produto p
                    INNER JOIN Jogo j ON j.IDProduto = p.Id
                    WHERE p.Ativo = 1
                    ORDER BY p.Nome";
            }

            return banco.Query<Produto>(sql).ToList();
        }
    }
}