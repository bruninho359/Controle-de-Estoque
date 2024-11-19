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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Controle_de_Estoque.br.com.projeto.view
{
    public partial class Frmvendas : Form
    {
        //Objetos Cliente e ClienteDAO
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        //Objetos de Produtos
        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        //Variaveis
        int qtd;
        decimal preco;
        decimal subtotal, total;

        //Carrinho
        DataTable carrinho = new DataTable();

        public Frmvendas()
        {
            InitializeComponent();

            txtTotal.ReadOnly = true;

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Começar da esquerda
            txtCpf.SelectionStart = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cliente = cdao.retornaClientePorCpf(txtCpf.Text);

                if(cliente != null)
                { 
                   txtNome.Text = cliente.nome;
                }
                else
                {
                    txtCpf.Clear();
                    txtCpf.Focus();
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                p = pdao.retornaProdutoPorCodigo(int.Parse(txtCodigo.Text));

                if (p != null) 
                { 
                    txtDesc.Text = p.descricao;
                    txtPreco.Text = p.preco.ToString();
                }
                else
                {
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Botao Adicionar Item
                qtd = int.Parse(txtQtd.Text);
                preco = decimal.Parse(txtPreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                //Adicionar produto
                carrinho.Rows.Add(int.Parse(txtCodigo.Text), txtDesc.Text, qtd, preco, subtotal);

                txtTotal.Text = total.ToString();

                //Limpar os campos
                txtCodigo.Clear();
                txtDesc.Clear();
                txtQtd.Clear();
                txtPreco.Clear();
                txtCodigo.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Digite o codigo do produto!");
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //EVITAR ERRO 
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                // Exibir mensagem de erro se o campo estiver vazio
                MessageBox.Show("Sem dados para remover", "Erro");
                return;
            }

            //Botao Remover Item
            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());

            int indice = tabelaProdutos.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;

            txtTotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho");
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            //Botao Pagamento
            DateTime dataatual = DateTime.Parse(txtData.Text);
            Frmpagamentos tela = new Frmpagamentos(cliente, carrinho, dataatual);

            //Passando total para tela de pagamentos
            tela.txtTotal.Text = total.ToString();
            tela.ShowDialog();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_Click(object sender, EventArgs e)
        {
            txtCpf.SelectionStart = 0;
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            //Pegando a data atual
            txtData.Text = DateTime.Now.ToShortDateString();
        }
    }
}
