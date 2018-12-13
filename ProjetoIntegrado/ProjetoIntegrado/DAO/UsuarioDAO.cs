using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ProjetoIntegrado.DAO
{
    public class UsuarioDAO
    {
        public static bool CheckUser(string login, string senha)
        {
            bool retorno = false;
            using(var con = new SqlConnection(StringConnection()))
            {
                string sql = "SELECT COUNT(*) FROM Usuario WHERE Login = @login and Senha = @senha";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                try
                {
                    con.Open();
                    retorno = ((int)cmd.ExecuteScalar() > 0);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return retorno;
        }

        public static string StringConnection()
        {
            return WebConfigurationManager.ConnectionStrings["workstation"].ConnectionString;
        }
    }
}