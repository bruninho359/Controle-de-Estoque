namespace Controle_de_Estoque.br.com.projeto.view
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocarDeUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSairDoSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuProdutos,
            this.menuVenda,
            this.menuConfiguracoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.menuStrip1.Size = new System.Drawing.Size(1316, 92);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeClientes,
            this.menuConsultaDeClientes});
            this.menuCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCliente.Image = global::Controle_de_Estoque.Properties.Resources.Clientes;
            this.menuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(142, 52);
            this.menuCliente.Text = "Clientes";
            // 
            // menuCadastroDeClientes
            // 
            this.menuCadastroDeClientes.Image = global::Controle_de_Estoque.Properties.Resources._10758976_user_plus_icon;
            this.menuCadastroDeClientes.Name = "menuCadastroDeClientes";
            this.menuCadastroDeClientes.Size = new System.Drawing.Size(276, 32);
            this.menuCadastroDeClientes.Text = "Cadastro de Clientes";
            this.menuCadastroDeClientes.Click += new System.EventHandler(this.menuCadastroDeClientes_Click);
            // 
            // menuConsultaDeClientes
            // 
            this.menuConsultaDeClientes.Image = global::Controle_de_Estoque.Properties.Resources._10758957_user_search_icon;
            this.menuConsultaDeClientes.Name = "menuConsultaDeClientes";
            this.menuConsultaDeClientes.Size = new System.Drawing.Size(276, 32);
            this.menuConsultaDeClientes.Text = "Consulta de Clientes";
            this.menuConsultaDeClientes.Click += new System.EventHandler(this.menuConsultaDeClientes_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeProdutos,
            this.menuConsultaDeProdutos});
            this.menuProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProdutos.Image = global::Controle_de_Estoque.Properties.Resources.Package;
            this.menuProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(154, 52);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadastroDeProdutos
            // 
            this.menuCadastroDeProdutos.Image = global::Controle_de_Estoque.Properties.Resources._10353936;
            this.menuCadastroDeProdutos.Name = "menuCadastroDeProdutos";
            this.menuCadastroDeProdutos.Size = new System.Drawing.Size(288, 32);
            this.menuCadastroDeProdutos.Text = "Cadastro de Produtos";
            this.menuCadastroDeProdutos.Click += new System.EventHandler(this.menuCadastroDeProdutos_Click);
            // 
            // menuConsultaDeProdutos
            // 
            this.menuConsultaDeProdutos.Image = global::Controle_de_Estoque.Properties.Resources._10353970__1_;
            this.menuConsultaDeProdutos.Name = "menuConsultaDeProdutos";
            this.menuConsultaDeProdutos.Size = new System.Drawing.Size(288, 32);
            this.menuConsultaDeProdutos.Text = "Consulta de Produtos";
            this.menuConsultaDeProdutos.Click += new System.EventHandler(this.menuConsultaDeProdutos_Click);
            // 
            // menuVenda
            // 
            this.menuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaVenda});
            this.menuVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVenda.Image = global::Controle_de_Estoque.Properties.Resources.Market;
            this.menuVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVenda.Name = "menuVenda";
            this.menuVenda.Size = new System.Drawing.Size(136, 52);
            this.menuVenda.Text = "Vendas";
            // 
            // menuNovaVenda
            // 
            this.menuNovaVenda.Image = global::Controle_de_Estoque.Properties.Resources._8664948_cart_plus_icon;
            this.menuNovaVenda.Name = "menuNovaVenda";
            this.menuNovaVenda.Size = new System.Drawing.Size(204, 32);
            this.menuNovaVenda.Text = "Nova Venda";
            this.menuNovaVenda.Click += new System.EventHandler(this.menuNovaVenda_Click);
            // 
            // menuConfiguracoes
            // 
            this.menuConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocarDeUsuario,
            this.menuSairDoSistema});
            this.menuConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuConfiguracoes.Image = global::Controle_de_Estoque.Properties.Resources.Config;
            this.menuConfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuConfiguracoes.Name = "menuConfiguracoes";
            this.menuConfiguracoes.Size = new System.Drawing.Size(199, 52);
            this.menuConfiguracoes.Text = "Configurações";
            // 
            // menuTrocarDeUsuario
            // 
            this.menuTrocarDeUsuario.Image = global::Controle_de_Estoque.Properties.Resources._9023869_user_fill_icon;
            this.menuTrocarDeUsuario.Name = "menuTrocarDeUsuario";
            this.menuTrocarDeUsuario.Size = new System.Drawing.Size(250, 32);
            this.menuTrocarDeUsuario.Text = "Trocar de Usuário";
            this.menuTrocarDeUsuario.Click += new System.EventHandler(this.menuTrocarDeUsuario_Click);
            // 
            // menuSairDoSistema
            // 
            this.menuSairDoSistema.Image = global::Controle_de_Estoque.Properties.Resources._3005766_account_door_exit_logout_icon;
            this.menuSairDoSistema.Name = "menuSairDoSistema";
            this.menuSairDoSistema.Size = new System.Drawing.Size(250, 32);
            this.menuSairDoSistema.Text = "Sair do Sistema";
            this.menuSairDoSistema.Click += new System.EventHandler(this.menuSairDoSistema_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtData,
            this.toolStripStatusLabel3,
            this.txtHora,
            this.toolStripStatusLabel6,
            this.txtUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 829);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1316, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 20);
            this.toolStripStatusLabel1.Text = "   Data Atual:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(117, 20);
            this.txtData.Text = "DD/MM/AAAA";
            this.txtData.Click += new System.EventHandler(this.txtData_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(96, 20);
            this.toolStripStatusLabel3.Text = "   Hora Atual:";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(63, 20);
            this.txtHora.Text = "HH:MM";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(129, 20);
            this.toolStripStatusLabel6.Text = "   Usuário Logado:";
            this.toolStripStatusLabel6.Click += new System.EventHandler(this.toolStripStatusLabel6_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(56, 20);
            this.txtUsuario.Text = "Admin";
            this.txtUsuario.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Controle_de_Estoque.Properties.Resources.bvb4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1316, 855);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroDeClientes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeClientes;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroDeProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuVenda;
        private System.Windows.Forms.ToolStripMenuItem menuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem menuTrocarDeUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSairDoSistema;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        public System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.Timer timer1;
    }
}