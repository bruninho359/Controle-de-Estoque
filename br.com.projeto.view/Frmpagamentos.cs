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
    public partial class Frmpagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;

        public Frmpagamentos(Cliente cliente, DataTable carrinho, DateTime dataatual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataatual = dataatual;

            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmpagamentos_Load(object sender, EventArgs e)
        {
            //Carregar Tela
            txtTroco.Text = "0,00";
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Botao Finalizar Venda
                decimal v_dinheiro, v_cartao, troco, totalpago, total;
                ProdutoDAO dao_produto = new ProdutoDAO();   

                int qtd_estoque, qtd_comprada, estoque_atualizado;

                v_dinheiro = decimal.Parse(txtDinheiro.Text);
                v_cartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);

                //Calcular Total Pago
                totalpago = v_dinheiro + v_cartao;

                if (totalpago < total) 
                {
                    MessageBox.Show("Total pago é menor que o valor Total da Venda!");
                }
                else
                {
                    //Calcular Troco
                    troco = totalpago - total;

                    Venda vendas = new Venda();

                    //Pegando o ID do Cliente
                    vendas.cliente_id = cliente.codigo;
                    vendas.data_venda = dataatual;
                    vendas.total_venda = total;

                    VendaDAO vdao = new VendaDAO();
                    txtTroco.Text = troco.ToString();

                    vdao.cadastrarVenda(vendas);

                    //Cadastrar Itens da Venda
                    foreach (DataRow linha in carrinho.Rows)
                    {
                        ItemVenda item = new ItemVenda();

                        item.venda_id = vdao.retornaIdUltimaVenda();
                        item.produto_id = int.Parse(linha["Código"].ToString());
                        item.qtd = int.Parse(linha["Qtd"].ToString());
                        item.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        //Baixa no Estoque
                        qtd_estoque = dao_produto.retornaEstoqueAtual(item.produto_id);
                        qtd_comprada = item.qtd;
                        estoque_atualizado = qtd_estoque - qtd_comprada;

                        dao_produto.baixaEstoque(item.produto_id, estoque_atualizado);

                        ItemVendaDAO itemdao = new ItemVendaDAO();
                        itemdao.cadastrarItem(item);
                       
                    }
                    MessageBox.Show("Venda finalizada com sucesso!");
                    this.Dispose();
                    
                    //Possivel Erro - nao fecha a tela
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is Frmvendas)
                        {
                            form.Dispose();
                            break;
                        }
                    }
                    
                    new Frmvendas().ShowDialog();
                }

                //Calcular Troco
                troco = totalpago - total;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
    }
}
