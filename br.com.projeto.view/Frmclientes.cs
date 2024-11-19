using Controle_de_Estoque.br.com.projeto.dao;
using Controle_de_Estoque.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque.br.com.projeto.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            tabelaCliente.DefaultCellStyle.ForeColor = Color.Black;
            ClienteDAO dao = new ClienteDAO();   
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            txtRg.SelectionStart = 0;
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            txtRg.SelectionStart = 0;
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            txtCpf.SelectionStart = 0;
        }

        private void maskedTextBox2_Enter(object sender, EventArgs e)
        {
            txtCpf.SelectionStart = 0;
        }

        private void maskedTextBox4_Click(object sender, EventArgs e)
        {
            txtCelular.SelectionStart = 0;
        }

        private void maskedTextBox4_Enter(object sender, EventArgs e)
        {
            txtCelular.SelectionStart = 0;
        }

        private void maskedTextBox3_Click(object sender, EventArgs e)
        {
            txtTelefone.SelectionStart = 0;
        }

        private void maskedTextBox3_Enter(object sender, EventArgs e)
        {
            txtTelefone.SelectionStart = 0;
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_Click(object sender, EventArgs e)
        {
            txtCep.SelectionStart = 0;
        }

        private void maskedTextBox5_Enter(object sender, EventArgs e)
        {
            txtCep.SelectionStart = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botao Pesquisar
            string nome = txtPesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.BuscarClientesPorNome(nome);

            if(tabelaCliente.Rows.Count == 0)
            {
                //Recarregar o DataGridView
                tabelaCliente.DataSource = dao.listarClientes();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //EVITAR ERRO CASO NAO TENHA O NUMERO
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                // Exibir mensagem de erro se o campo estiver vazio
                MessageBox.Show("Sem dados para adicionar", "Erro");
                return; 
            }

            // 1 passo - receber os dados dentro do objeto modelo de clientes
            Cliente obj = new Cliente();

            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
            obj.email = txtEmail.Text;
            obj.telefone = txtTelefone.Text;
            obj.celular = txtCelular.Text;
            obj.cep = txtCep.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbUf.Text;

            //2 passo - Criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente 
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada
            txtCodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbUf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            //Alterar para a guia Dados Pessoais
            tabClientes.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                // Exibir mensagem de erro se o campo estiver vazio
                MessageBox.Show("Por favor, insira um código de cliente antes de excluir.", "Erro", MessageBoxButtons.OK);
                return; // Sair da função sem tentar excluir
            }
            //Bota Excluir
            Cliente obj = new Cliente();

            //pegar o codigo
            obj.codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();  

            //recarregar o DataGridView
            dao.excluirCliente(obj);
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //EVITAR ERRO CASO NAO TENHA O NUMERO
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                // Exibir mensagem de erro se o campo estiver vazio
                MessageBox.Show("Sem dados para editar", "Erro");
                return; // Sair da função sem tentar excluir
            }

            //EVITAR ERRO CASO NAO TENHA O NUMERO
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                // Exibir mensagem de erro se o campo estiver vazio
                MessageBox.Show("Ocorreu um erro");
                return;
            }

            // 1 passo - receber os dados dentro do objeto modelo de clientes
            Cliente obj = new Cliente();

            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
            obj.email = txtEmail.Text;
            obj.telefone = txtTelefone.Text;
            obj.celular = txtCelular.Text;
            obj.cep = txtCep.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbUf.Text;

            obj.codigo = int.Parse(txtCodigo.Text);

            //2 passo - Criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente 
            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
           
            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.ListarClientesPorNome(nome);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Botao consultar CEP API
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente");
            }
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
