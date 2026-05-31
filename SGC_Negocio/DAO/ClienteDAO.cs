using SGC_Negocio.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
namespace SGC_Negocio.DAO
{
    public class ClienteDAO:Conexao
    {
        public Cliente Buscar(int id)
        {
            var resp = banco.Query<Cliente>
                ("select * " +
                "from Clientes " +
                "where ID = @pID",
                new { pID = id }).SingleOrDefault();
            return resp;
        }
        public List<Cliente> Listar()
        {
            var lista = banco.Query <Cliente>
                ("select * from Clientes").ToList();
            lista = lista.OrderBy(o => o.NomeCompleto).ToList();
            return lista;
        }
        public bool Excluir(int id)
        {
            try
            {
                var resp = banco.Execute(
                    "delete from Clientes where id = @pID",
                    new { pID = id });
                return resp == 1;
            }
            catch
            {
                return false;
            }
        }

        private int Inserir(Cliente cliente)
        {
            return banco.Query<Int32>
                ("Insert into Clientes " +
                "(CPF, NomeCompleto, DataNascimento, Sexo, Endereco, Telefone, Email, Ativo) " +
                "VALUES " +
                "(@CPF, @NomeCompleto, @DataNascimento, @Sexo, @Endereco, @Telefone, @Email, @Ativo) " +
                "select @@IDENTITY",
                cliente).Single();
        }

        private int Alterar(Cliente cliente)
        {
            var resp = banco.Execute(
                "Update Clientes SET " +
                "CPF = @CPF, NomeCompleto = @NomeCompleto,DataNascimento = @DataNascimento, " +
                "Sexo = @Sexo, Endereco = @Endereco, Telefone = @Telefone, Email = @Email, " +
                "Ativo = @Ativo " +
                "Where ID = @ID",
                cliente);

            return resp == 0 ? 0 : cliente.ID;
        }

        public Int32 Salvar(Cliente cliente)
        {
            if (cliente == null || cliente.NomeCompleto.Trim().Length == 0)
                return 0;

            if (cliente.ID == 0)
                return Inserir(cliente);
            else
                return Alterar(cliente);
        }
    }
}

