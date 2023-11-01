
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.bt_Cadastro.Text = "Cadastrar Funcionário";
            this.bt_Cadastro.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "Usuário";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tela_Principal_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Gerenciar_Vendas);
            this.Controls.Add(this.bt_Gerenciar);
            this.Controls.Add(this.bt_Cadastro);
            this.Controls.Add(this.bt_Estoque);
            this.Controls.Add(this.label2);
            this.Name = "Tela_Principal_Admin";
            this.Text = "Tele_Principal_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Estoque;
        private System.Windows.Forms.Button bt_Cadastro;
        private System.Windows.Forms.Button bt_Gerenciar;
        private System.Windows.Forms.Button bt_Gerenciar_Vendas;
        private System.Windows.Forms.Button button1;
    }
}