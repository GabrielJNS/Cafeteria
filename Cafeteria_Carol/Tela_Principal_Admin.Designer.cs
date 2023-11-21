
namespace Cafeteria_Carol
{
    partial class Tela_Principal_Admin
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
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Estoque = new System.Windows.Forms.Button();
            this.bt_Cadastro = new System.Windows.Forms.Button();
            this.bt_Gerenciar = new System.Windows.Forms.Button();
            this.bt_Gerenciar_Vendas = new System.Windows.Forms.Button();
            this.bt_Gerenciar_Produtos = new System.Windows.Forms.Button();
            this.lb_User = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " área de administração";
            // 
            // bt_Estoque
            // 
            this.bt_Estoque.Location = new System.Drawing.Point(533, 61);
            this.bt_Estoque.Name = "bt_Estoque";
            this.bt_Estoque.Size = new System.Drawing.Size(189, 74);
            this.bt_Estoque.TabIndex = 3;
            this.bt_Estoque.Text = "Estoque";
            this.bt_Estoque.UseVisualStyleBackColor = true;
            // 
            // bt_Cadastro
            // 
            this.bt_Cadastro.Location = new System.Drawing.Point(533, 141);
            this.bt_Cadastro.Name = "bt_Cadastro";
            this.bt_Cadastro.Size = new System.Drawing.Size(189, 74);
            this.bt_Cadastro.TabIndex = 4;
            this.bt_Cadastro.Text = "Cadastrar e Modificar Funcionário";
            this.bt_Cadastro.UseVisualStyleBackColor = true;
            this.bt_Cadastro.Click += new System.EventHandler(this.bt_Cadastro_Click);
            // 
            // bt_Gerenciar
            // 
            this.bt_Gerenciar.Location = new System.Drawing.Point(533, 221);
            this.bt_Gerenciar.Name = "bt_Gerenciar";
            this.bt_Gerenciar.Size = new System.Drawing.Size(189, 74);
            this.bt_Gerenciar.TabIndex = 5;
            this.bt_Gerenciar.Text = "Gerenciar Cadastro";
            this.bt_Gerenciar.UseVisualStyleBackColor = true;
            // 
            // bt_Gerenciar_Vendas
            // 
            this.bt_Gerenciar_Vendas.Location = new System.Drawing.Point(533, 301);
            this.bt_Gerenciar_Vendas.Name = "bt_Gerenciar_Vendas";
            this.bt_Gerenciar_Vendas.Size = new System.Drawing.Size(189, 74);
            this.bt_Gerenciar_Vendas.TabIndex = 6;
            this.bt_Gerenciar_Vendas.Text = "Gerenciar Vendas";
            this.bt_Gerenciar_Vendas.UseVisualStyleBackColor = true;
            // 
            // bt_Gerenciar_Produtos
            // 
            this.bt_Gerenciar_Produtos.Location = new System.Drawing.Point(12, 301);
            this.bt_Gerenciar_Produtos.Name = "bt_Gerenciar_Produtos";
            this.bt_Gerenciar_Produtos.Size = new System.Drawing.Size(189, 74);
            this.bt_Gerenciar_Produtos.TabIndex = 8;
            this.bt_Gerenciar_Produtos.Text = "Gerenciar Produtos";
            this.bt_Gerenciar_Produtos.UseVisualStyleBackColor = true;
            this.bt_Gerenciar_Produtos.Click += new System.EventHandler(this.bt_Gerenciar_Produtos_Click);
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(220, 31);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(29, 13);
            this.lb_User.TabIndex = 9;
            this.lb_User.Text = "User";
            this.lb_User.Click += new System.EventHandler(this.lb_User_Click);
            // 
            // Tela_Principal_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.bt_Gerenciar_Produtos);
            this.Controls.Add(this.bt_Gerenciar_Vendas);
            this.Controls.Add(this.bt_Gerenciar);
            this.Controls.Add(this.bt_Cadastro);
            this.Controls.Add(this.bt_Estoque);
            this.Controls.Add(this.label2);
            this.Name = "Tela_Principal_Admin";
            this.Text = "Tele_Principal_Admin";
            this.Load += new System.EventHandler(this.Tela_Principal_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Estoque;
        private System.Windows.Forms.Button bt_Cadastro;
        private System.Windows.Forms.Button bt_Gerenciar;
        private System.Windows.Forms.Button bt_Gerenciar_Vendas;
        private System.Windows.Forms.Button bt_Gerenciar_Produtos;
        private System.Windows.Forms.Label lb_User;
    }
}