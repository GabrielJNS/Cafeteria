
namespace Cafeteria_Carol
{
    partial class Tela_Gerenciar_Produtos
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
            this.bt_AdicionarProduto = new System.Windows.Forms.Button();
            this.bt_ExcluirProduto = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fotos_Enviar = new System.Windows.Forms.PictureBox();
            this.bt_ModificarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Fotos_Enviar)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AdicionarProduto
            // 
            this.bt_AdicionarProduto.Location = new System.Drawing.Point(31, 300);
            this.bt_AdicionarProduto.Name = "bt_AdicionarProduto";
            this.bt_AdicionarProduto.Size = new System.Drawing.Size(70, 38);
            this.bt_AdicionarProduto.TabIndex = 0;
            this.bt_AdicionarProduto.Text = "add";
            this.bt_AdicionarProduto.UseVisualStyleBackColor = true;
            this.bt_AdicionarProduto.Click += new System.EventHandler(this.bt_AdicionarProduto_Click);
            // 
            // bt_ExcluirProduto
            // 
            this.bt_ExcluirProduto.Location = new System.Drawing.Point(427, 240);
            this.bt_ExcluirProduto.Name = "bt_ExcluirProduto";
            this.bt_ExcluirProduto.Size = new System.Drawing.Size(112, 38);
            this.bt_ExcluirProduto.TabIndex = 1;
            this.bt_ExcluirProduto.Text = "Excluir";
            this.bt_ExcluirProduto.UseVisualStyleBackColor = true;
            this.bt_ExcluirProduto.Click += new System.EventHandler(this.bt_ExcluirProduto_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(31, 60);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(188, 20);
            this.txtNomeProduto.TabIndex = 2;
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(31, 132);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(188, 20);
            this.txtDescricaoProduto.TabIndex = 3;
            this.txtDescricaoProduto.TextChanged += new System.EventHandler(this.txtDescricaoProduto_TextChanged);
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(31, 203);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(188, 20);
            this.txtPrecoProduto.TabIndex = 4;
            this.txtPrecoProduto.TextChanged += new System.EventHandler(this.txtPrecoProduto_TextChanged);
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(427, 203);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(188, 20);
            this.txtIDProduto.TabIndex = 5;
            this.txtIDProduto.TextChanged += new System.EventHandler(this.txtIDProduto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            // 
            // Fotos_Enviar
            // 
            this.Fotos_Enviar.Location = new System.Drawing.Point(427, 31);
            this.Fotos_Enviar.Name = "Fotos_Enviar";
            this.Fotos_Enviar.Size = new System.Drawing.Size(100, 71);
            this.Fotos_Enviar.TabIndex = 10;
            this.Fotos_Enviar.TabStop = false;
            this.Fotos_Enviar.Click += new System.EventHandler(this.Fotos_Enviar_Click);
            // 
            // bt_ModificarProduto
            // 
            this.bt_ModificarProduto.Location = new System.Drawing.Point(133, 300);
            this.bt_ModificarProduto.Name = "bt_ModificarProduto";
            this.bt_ModificarProduto.Size = new System.Drawing.Size(75, 38);
            this.bt_ModificarProduto.TabIndex = 11;
            this.bt_ModificarProduto.Text = "Modificar";
            this.bt_ModificarProduto.UseVisualStyleBackColor = true;
            this.bt_ModificarProduto.Click += new System.EventHandler(this.bt_ModificarProduto_Click);
            // 
            // Tela_Gerenciar_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ModificarProduto);
            this.Controls.Add(this.Fotos_Enviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.bt_ExcluirProduto);
            this.Controls.Add(this.bt_AdicionarProduto);
            this.Name = "Tela_Gerenciar_Produtos";
            this.Text = "Tela_Gerenciar_Produtos";
            this.Load += new System.EventHandler(this.Tela_Gerenciar_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fotos_Enviar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_AdicionarProduto;
        private System.Windows.Forms.Button bt_ExcluirProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Fotos_Enviar;
        private System.Windows.Forms.Button bt_ModificarProduto;
    }
}