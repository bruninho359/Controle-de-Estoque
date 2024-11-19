using Controle_de_Estoque.br.com.projeto.conexao;
using Controle_de_Estoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque.br.com.projeto.dao
{
    public class ProdutoDAO
    {
        private SqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método Cadastrar Produto
        public void cadastraProduto(Produto obj)
        {
            try
            {
                //1 Passo - criar o sql
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, validade) 
                               values (@descricao, @preco, @qtd, @validade)";

                //2 Passo - organizar e executar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@validade", obj.validade);

                //executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                //REMOVI O FOR ID DE TUDO

                //3 Passo - abrir a conexao e executar comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucessso!");
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Alterar Produto
        public void alterarProduto(Produto obj)
        {
            try
            {
                //1 Passo - criar o sql
                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, qtd_estoque=@qtd, validade=@validade where id = @id";


                //2 Passo - organizar e executar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@validade", obj.validade);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                //REMOVI O FOR ID DE TUDO

                //3 Passo - abrir a conexao e executar comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucessso!");
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Excluir Produto
        public void excluirProduto(Produto obj)
        {
            try
            {
                //1 Passo - criar o sql
                string sql = @"delete from tb_produtos where id = @id";


                //2 Passo - organizar e executar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                //executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                //REMOVI O FOR ID DE TUDO

                //3 Passo - abrir a conexao e executar comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucessso!");
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Método Listar Produtos
        public DataTable listarProdutos()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabelaProduto = new DataTable();

                string sql = @"select tb_produtos.id as 'Código',
                                      tb_produtos.descricao as 'Descrição',
                                      tb_produtos.preco as 'Preço',
                                      tb_produtos.qtd_estoque as 'Qtd Estoque',
                                      tb_produtos.validade as 'Validade' from tb_produtos;";

                //2 passo - Organizar o comando SQL e executar
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable
                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                //fechar conexao
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);

                return null;
            }
        }

        #endregion

        #region Método Listar Produtos Por Nome
        public DataTable listarProdutosPorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabelaProduto = new DataTable();

                string sql = @"select tb_produtos.id as 'Código',
                                      tb_produtos.descricao as 'Descrição',
                                      tb_produtos.preco as 'Preço',
                                      tb_produtos.qtd_estoque as 'Qtd Estoque',
                                      tb_produtos.validade as 'Validade' from tb_produtos where tb_produtos.descricao like @nome;";

                //2 passo - Organizar o comando SQL e executar
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable
                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                //fechar conexao
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);

                return null;
            }
        }

        #endregion

        #region Método Buscar Produtos Por Nome
        public DataTable BuscarProdutosPorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabelaProduto = new DataTable();

                string sql = @"select tb_produtos.id as 'Código',
                                      tb_produtos.descricao as 'Descrição',
                                      tb_produtos.preco as 'Preço',
                                      tb_produtos.qtd_estoque as 'Qtd Estoque',
                                      tb_produtos.validade as 'Validade' from tb_produtos where tb_produtos.descricao = @nome;";

                //2 passo - Organizar o comando SQL e executar
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable
                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                //fechar conexao
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);

                return null;
            }
        }



        #endregion

        #region Retornar Produto Por Codigo
        public Produto retornaProdutoPorCodigo(int id)
        {
            try
            {
                //1 Passo - Criar o comando SQL
                string sql = @"select * from tb_produtos where id = @id";

                //2 passo - Organizar e executar
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);
                conexao.Open();

                //3 passo - criar o  SqlDataReader
                SqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    Produto p = new Produto();

                    p.id = int.Parse(rs["id"].ToString());
                    p.descricao = rs["descricao"].ToString();
                    p.preco = decimal.Parse(rs["preco"].ToString());

                    conexao.Close();
                    return p;
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado");
                    conexao.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                return null;
            }
        }

        #endregion

        #region Método Baixa no Estoque
        public void baixaEstoque(int idproduto, int qtdestoque)
        {
            try
            {
                //1 Passo - criar o sql
                string sql = @"update tb_produtos set qtd_estoque=@qtd where id = @id";

                //2 Passo - organizar e executar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@qtd", qtdestoque);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                //3 Passo - abrir a conexao e executar comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }
        }

        #endregion

        #region Método Retorna Estoque Atual
        public int retornaEstoqueAtual(int idproduto)
        {
            try
            {
                string sql = @"select qtd_estoque from tb_produtos where id = @id";
                int qtd_estoque = 0;

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                conexao.Open();

                SqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    qtd_estoque = int.Parse(rs["qtd_estoque"].ToString());
                    conexao.Close();
                }
                return qtd_estoque;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return 0;
            }
        }

        #endregion
    }


}
