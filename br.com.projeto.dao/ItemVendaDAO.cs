using Controle_de_Estoque.br.com.projeto.conexao;
using Controle_de_Estoque.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque.br.com.projeto.dao
{
    public class ItemVendaDAO
    {
        private SqlConnection conexao;

        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método Cadastrar Item de Venda
        public void cadastrarItem(ItemVenda obj)
        {
            try
            {
                //1 Passo - criar o sql
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
                               values (@venda_id, @produto_id, @qtd, @subtotal)";

                //2 Passo - organizar e executar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                //3 Passo - abrir a conexao e executar comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Item cadastrado com sucessso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Acontece o erro: " + erro);
            }
        }

        #endregion
    }
}
