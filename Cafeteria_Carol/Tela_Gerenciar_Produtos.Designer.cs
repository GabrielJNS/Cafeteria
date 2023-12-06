
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
            this.bt_ModificarProduto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.Fotos_Enviar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fotos_Enviar)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AdicionarProduto
            // 
            this.bt_AdicionarProduto.BackColor = System.Drawing.Color.Transparent;
            this.bt_AdicionarProduto.FlatAppearance.BorderSize = 0;
            this.bt_AdicionarProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bt_AdicionarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_AdicionarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_AdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AdicionarProduto.Location = new System.Drawing.Point(53, 455);
            this.bt_AdicionarProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_AdicionarProduto.Name = "bt_AdicionarProduto";
            this.bt_AdicionarProduto.Size = new System.Drawing.Size(196, 63);
            this.bt_AdicionarProduto.TabIndex = 0;
            this.bt_AdicionarProduto.UseVisualStyleBackColor = false;
            this.bt_AdicionarProduto.Click += new System.EventHandler(this.bt_AdicionarProduto_Click);
            // 
            // bt_ExcluirProduto
            // 
            this.bt_ExcluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.bt_ExcluirProduto.FlatAppearance.BorderSize = 0;
            this.bt_ExcluirProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bt_ExcluirProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_ExcluirProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_ExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ExcluirProduto.Location = new System.Drawing.Point(824, 455);
            this.bt_ExcluirProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_ExcluirProduto.Name = "bt_ExcluirProduto";
            this.bt_ExcluirProduto.Size = new System.Drawing.Size(184, 57);
            this.bt_ExcluirProduto.TabIndex = 1;
            this.bt_ExcluirProduto.UseVisualStyleBackColor = false;
            this.bt_ExcluirProduto.Click += new System.EventHandler(this.bt_ExcluirProduto_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Location = new System.Drawing.Point(69, 207);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(364, 15);
            this.txtNomeProduto.TabIndex = 2;
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(69, 306);
            this.txtDescricaoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(364, 15);
            this.txtDescricaoProduto.TabIndex = 3;
            this.txtDescricaoProduto.TextChanged += new System.EventHandler(this.txtDescricaoProduto_TextChanged);
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtPrecoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecoProduto.Location = new System.Drawing.Point(69, 409);
            this.txtPrecoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(364, 15);
            this.txtPrecoProduto.TabIndex = 4;
            this.txtPrecoProduto.TextChanged += new System.EventHandler(this.txtPrecoProduto_TextChanged);
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtIDProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDProduto.Location = new System.Drawing.Point(629, 409);
            this.txtIDProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(364, 15);
            this.txtIDProduto.TabIndex = 5;
            this.txtIDProduto.TextChanged += new System.EventHandler(this.txtIDProduto_TextChanged);
            // 
            // bt_ModificarProduto
            // 
            this.bt_ModificarProduto.BackColor = System.Drawing.Color.Transparent;
            this.bt_ModificarProduto.FlatAppearance.BorderSize = 0;
            this.bt_ModificarProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bt_ModificarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_ModificarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_ModificarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ModificarProduto.Location = new System.Drawing.Point(257, 455);
            this.bt_ModificarProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_ModificarProduto.Name = "bt_ModificarProduto";
            this.bt_ModificarProduto.Size = new System.Drawing.Size(195, 63);
            this.bt_ModificarProduto.TabIndex = 11;
            this.bt_ModificarProduto.UseVisualStyleBackColor = false;
            this.bt_ModificarProduto.Click += new System.EventHandler(this.bt_ModificarProduto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(497, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(531, 191);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(608, 455);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(199, 63);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Fotos_Enviar
            // 
            this.Fotos_Enviar.Location = new System.Drawing.Point(693, 57);
            this.Fotos_Enviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fotos_Enviar.Name = "Fotos_Enviar";
            this.Fotos_Enviar.Size = new System.Drawing.Size(133, 87);
            this.Fotos_Enviar.TabIndex = 10;
            this.Fotos_Enviar.TabStop = false;
            this.Fotos_Enviar.Click += new System.EventHandler(this.Fotos_Enviar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(953, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tela_Gerenciar_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cafeteria_Carol.Properties.Resources.GerenciarProd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_ModificarProduto);
            this.Controls.Add(this.Fotos_Enviar);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.bt_ExcluirProduto);
            this.Controls.Add(this.bt_AdicionarProduto);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tela_Gerenciar_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Gerenciar_Produtos";
            this.Load += new System.EventHandler(this.Tela_Gerenciar_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.PictureBox Fotos_Enviar;
        private System.Windows.Forms.Button bt_ModificarProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button1;
    }
}