using Controle_de_Estoque.br.com.projeto.conexao;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private SqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Login
        public bool EfetuarLogin(string email, string senha)
        {
            try
            {
                //1 Passo - Criar comando SQL
                string sql = @"select * from tb_funcionarios
                               where email = @email and senha = @senha";

                //2 Passo - Organizar e Executar
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                SqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    //Login Realizado
                    MessageBox.Show("Login realizado com sucesso!");
                    return true;
                }
                else
                {
                    //Email ou senha errado
                    MessageBox.Show("Senha ou email incorreto");
                    return false;
                }
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return false;
            }
        }

        #endregion
    }
}
