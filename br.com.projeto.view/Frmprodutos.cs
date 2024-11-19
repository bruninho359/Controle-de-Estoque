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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //EVITAR ERRO
            if (string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                // Exibir mensagem de erro se o campo estiver vazio
                MessageBox.Show("Sem dados para adicionar", "Erro");
                return;
            }

            //1 Passo - receber todos os dados da tla
            Produto obj = new Produto();

            obj.descricao = txtDesc.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdestoque = int.Parse(txtQtd.Text);
            obj.validade = txtValidade.Text;
            
            //2 Passo - Criar o objeto DAO
            ProdutoDAO dao = new ProdutoDAO();
            dao.cadastraProduto(obj);

            
            //Limpar tela apos cadastro
            new Helpers().LimparTela(this);

            //recarregar o datagridview com os dados dos produtos
            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO(); 
            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void tabelaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtValidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabelaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados de um produto selecionado
            txtCodigo.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txtQtd.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();
            txtValidade.Text = tabelaProdutos.CurrentRow.Cells[4].Value.ToString();

            //Alterar para a guia Dados Pessoais
            tabProdutos.SelectedTab = tabPage1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //EVITAR ERRO 
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                // Exibir mensagem de erro se o campo estiver vazio
                MessageBox.Show("Sem dados para editar", "Erro");
                return;
            }

            //Botao Editar Produto
            //1 Passo - receber todos os dados da tla
            Produto obj = new Produto();

            obj.descricao = txtDesc.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdestoque = int.Parse(txtQtd.Text);
            obj.validade = txtValidade.Text;
            obj.id = int.Parse(txtCodigo.Text);

            //2 Passo - Criar o objeto DAO
            ProdutoDAO dao = new ProdutoDAO();
            dao.alterarProduto(obj);


            //Limpar tela apos cadastro
            new Helpers().LimparTela(this);

            //recarregar o datagridview com os dados dos produtos
            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //EVITAR ERRO 
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                // Exibir mensagem de erro se o campo estiver vazio
                MessageBox.Show("Sem dados para excluir", "Erro");
                return;
            }

            //Botao Editar Produto
            //1 Passo - receber todos os dados da tla
            Produto obj = new Produto();
            
            obj.id = int.Parse(txtCodigo.Text);

            //2 Passo - Criar o objeto DAO
            ProdutoDAO dao = new ProdutoDAO();
            dao.excluirProduto(obj);


            //Limpar tela apos cadastro
            new Helpers().LimparTela(this);

            //recarregar o datagridview com os dados dos produtos
            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.listarProdutosPorNome(nome);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.BuscarProdutosPorNome(nome);

            if (tabelaProdutos.Rows.Count == 0) 
            {
                MessageBox.Show("Nenhum produto encontrado com esse nome");
                //Recarregar DataGridView
                tabelaProdutos.DataSource = dao.listarProdutos();
            }
        }
    }
}
