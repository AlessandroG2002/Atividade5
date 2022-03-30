using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5.DAO
{
    public class LoginDao
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            command.CommandText = "select * from usuario " +
                "where login = @login and senha = @senha";

            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@senha", senha);

            Conexao con = new Conexao();

            try
            {
                command.Connection = con.conectar();
                dr = command.ExecuteReader();

                if (dr.HasRows)
                    tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados! ";
            }

            return tem;
        }

        public bool Cadastrar(String login, String senha, string confirmarSenha)
        {
            return tem;
        }
    }
}
