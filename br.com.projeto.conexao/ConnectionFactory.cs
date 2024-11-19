using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        //metodo que conecta o banco de dados

        public SqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new SqlConnection(conexao);
        }

    }
}
