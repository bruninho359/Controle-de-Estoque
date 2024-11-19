using Controle_de_Estoque.br.com.projeto.conexao;
using Controle_de_Estoque.br.com.projeto.model;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque.br.com.projeto.dao
{
    public class VendaDAO
    {
        private SqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método Cadastrar Venda
        public void cadastrarVenda(Venda obj)
        {
            try
            {
                //1 Passo - criar o sql
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda)
                               values(@cliente_id, @data_venda, @total_venda)";

                //2 Passo - organizar e executar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);

                //3 Passo - abrir a conexao e executar comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Venda cadastrada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Método Retornar ID Ultima Venda
        public int retornaIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;

                //1 Passo - Criar comando SQL
                String sql = "select max(id) id from tb_vendas;";
                SqlCommand executacmdsql = new SqlCommand(sql, conexao);

                conexao.Open();

                SqlDataReader rs = executacmdsql.ExecuteReader();

                if (rs.Read())
                {
                    idvenda = int.Parse(rs["id"].ToString());                    
                } 

                conexao.Close();   
                return idvenda;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao retornar: " + erro);
                conexao.Close();
                return 0;
            }
        } 

        #endregion

    }
}
