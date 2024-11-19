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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Pegando a data atual
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Ver a hora pelo Timer
            txtHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuCadastroDeClientes_Click(object sender, EventArgs e)
        {
            //Abrir a tela de clientes
            Frmclientes tela = new Frmclientes();
            tela.ShowDialog();
        }

        private void menuConsultaDeClientes_Click(object sender, EventArgs e)
        {
            //Abrir tela de clientes aba de consulta
            Frmclientes tela = new Frmclientes();
            tela.tabClientes.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroDeProdutos_Click(object sender, EventArgs e)
        {
            //Abrir tela de produtos
            Frmprodutos tela = new Frmprodutos();
            tela.ShowDialog();
        }

        private void menuConsultaDeProdutos_Click(object sender, EventArgs e)
        {
            //Abrir tela de produtos aba consulta
            Frmprodutos tela = new Frmprodutos();
            tela.tabProdutos.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuNovaVenda_Click(object sender, EventArgs e)
        {
            Frmvendas tela = new Frmvendas();
            tela.ShowDialog();
        }

        private void txtData_Click(object sender, EventArgs e)
        {

        }

        private void menuSairDoSistema_Click(object sender, EventArgs e)
        {
            //Sair do programa
            DialogResult result = MessageBox.Show("Você deseja Sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }

        private void menuTrocarDeUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja alterar o usuário?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Frmlogin telaLogin = new Frmlogin();
                telaLogin.ShowDialog();
            }
        }
    }
}
