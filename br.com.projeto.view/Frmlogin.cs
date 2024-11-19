using Controle_de_Estoque.br.com.projeto.dao;
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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Botao Entrar
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            if(dao.EfetuarLogin(email, senha))
            {
                FrmMenu telamenu = new FrmMenu();
                telamenu.Show();
                this.Hide();
            }
        }
    }
}
