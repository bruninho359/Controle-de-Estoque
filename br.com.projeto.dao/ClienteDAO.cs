using Controle_de_Estoque.br.com.projeto.conexao;
using Controle_de_Estoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using Mysqlx;
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
    public class ClienteDAO
    {
        private SqlConnection conexao;

        public ClienteDAO() 
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o comando sql - insert into
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                               values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado )";

                //2 passo - organizar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //3 passo - Abrir a conexao e executar comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");

                //fechar conexao
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro);
                throw;
            }
        }
        #endregion

        #region AlterarCliente
        public void alterarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o comando sql
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep,
                             endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                             where id=@id";
                               
                //2 passo - organizar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //3 passo - Abrir a conexao e executar comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com sucesso!");

                //fechar conexao
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar dados: " + erro);
                throw;
            }
        }


        #endregion

        #region ExcluirCliente
        public void excluirCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o comando sql
                string sql = @"delete from tb_clientes where id = @id";

                //2 passo - organizar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passo - Abrir a conexao e executar comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com sucesso!");

                //fechar conexao
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir dados: " + erro);
                throw;
            }
        }


        #endregion

        #region ListarClientes
        public DataTable listarClientes()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabelacliente = new DataTable();

                string sql = "select * from tb_clientes";

                //2 passo - Organizar o comando SQL e executar
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable
                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //fechar conexao
                conexao.Close();

                return tabelacliente;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);

                return null;
            }
        }


        #endregion

        #region BuscarClientesPorNome
        public DataTable BuscarClientesPorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabelacliente = new DataTable();

                string sql = "select * from tb_clientes where nome = @nome";

                //2 passo - Organizar o comando SQL e executar
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable
                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //fechar conexao
                conexao.Close();

                return tabelacliente;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);

                return null;
            }
        }

        #endregion

        #region ListarClientesPorNome
        public DataTable ListarClientesPorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabelacliente = new DataTable();

                string sql = "select * from tb_clientes where nome like @nome";

                //2 passo - Organizar o comando SQL e executar
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable
                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //fechar conexao
                conexao.Close();

                return tabelacliente;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);

                return null;
            }
        }
        #endregion

        #region Retornar Cliente Por CPF
        public Cliente retornaClientePorCpf(string cpf)
        {
            try
            {
                //1 passo - Criar o comando sql e o objeto Cliente
                Cliente obj = new Cliente();
                string sql = @"select * from tb_clientes where cpf = @cpf";

                //2 passo - Organizar o comando sql e executar
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();

                SqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    //BUG NAO TA PEGANDO
                    //CHAT GPT POCOU AQUI,
                    obj.codigo = int.Parse(rs["id"].ToString()); // Conversão para int
                    obj.nome = rs["nome"].ToString(); // Conversão para string

                    conexao.Close();
                    return obj;
                }
                else
                {
                    MessageBox.Show("Cliente nao encontrado");

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

        

        //metodo buscarClientePorCpf
    }
}
