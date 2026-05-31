using Dapper;
using SGC_Negocio.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGC_Negocio.DAO
{
    public class UsuarioDAO : Conexao
    {
        public Usuario Login(string login, string senha)
        {
            var usuario = banco.Query<Usuario>
                ("SELECT * FROM Usuarios " +
                "WHERE Login = @pLogin AND Senha = @pSenha",
                new
                {
                    pLogin = login.Trim(),
                    pSenha = senha.Trim()
                }).SingleOrDefault();

            if (usuario != null)
                usuario.Senha = "Senha não pode ser exposta";

            return usuario;
        }

        public List<Usuario> Listar()
        {
            return banco.Query<Usuario>(
                "SELECT ID, Nome, Login, TipoUsuario, DataCadastro, Ativo " +
                "FROM Usuarios " +
                "ORDER BY Nome").ToList();
        }

        public bool TrocarSenha(int id, string novaSenha)
        {
            return banco.Execute(
                "UPDATE Usuarios SET Senha = @pNovaSenha " +
                "WHERE ID = @pID",
                new
                {
                    pID = id,
                    pNovaSenha = novaSenha.Trim()
                }) == 1;
        }

        private Int32 Alterar(Usuario usuario)
        {
            string sql;

            // Se a senha foi preenchida, atualiza ela também
            if (!string.IsNullOrEmpty(usuario.Senha))
            {
                sql = "UPDATE Usuarios SET " +
                      "Nome = @Nome, Login = @Login, Senha = @Senha, " +
                      "TipoUsuario = @TipoUsuario, DataCadastro = @DataCadastro, Ativo = @Ativo " +
                      "WHERE ID = @ID";
            }
            else
            {
                // Se a senha está vazia, NÃO atualiza a senha (mantém a antiga)
                sql = "UPDATE Usuarios SET " +
                      "Nome = @Nome, Login = @Login, " +
                      "TipoUsuario = @TipoUsuario, DataCadastro = @DataCadastro, Ativo = @Ativo " +
                      "WHERE ID = @ID";
            }

            var resp = banco.Execute(sql, usuario);
            return resp == 0 ? 0 : usuario.ID;
        }

        private Int32 Inserir(Usuario usuario)
        {
            return banco.Query<Int32>(
                "INSERT INTO Usuarios " +
                "(Nome, Login, Senha, TipoUsuario, DataCadastro, Ativo) " +
                "VALUES " +
                "(@Nome, @Login, @Senha, @TipoUsuario, @DataCadastro, @Ativo) " +
                "SELECT @@IDENTITY", usuario).Single();
        }

        public Int32 Salvar(Usuario usuario)
        {
            if (usuario == null || usuario.Nome.Trim().Length == 0)
                return 0;

            if (usuario.ID == 0)
                return Inserir(usuario);
            else
                return Alterar(usuario);
        }

        public bool Excluir(int id)
        {
            try
            {
                var resp = banco.Execute(
                    "DELETE FROM Usuarios WHERE ID = @pID",
                    new { pID = id });
                return resp == 1;
            }
            catch
            {
                return false;
            }
        }

        public Usuario Buscar(int id)
        {
            return banco.Query<Usuario>
                ("SELECT * FROM Usuarios WHERE ID = @pID",
                new { pID = id }).SingleOrDefault();
        }
    }
}