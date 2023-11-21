
namespace Cafeteria_Carol
{
    partial class Tela_Cardapio_Usuario
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
            this.btnAdicionarAoCarrinho = new System.Windows.Forms.Button();
            this.dataGridViewMenu1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdicionarSacola = new System.Windows.Forms.Button();
            this.btnComanda = new System.Windows.Forms.Button();
            this.btnRecarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarAoCarrinho
            // 
            this.btnAdicionarAoCarrinho.Location = new System.Drawing.Point(610, 388);
            this.btnAdicionarAoCarrinho.Name = "btnAdicionarAoCarrinho";
            this.btnAdicionarAoCarrinho.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarAoCarrinho.TabIndex = 5;
            this.btnAdicionarAoCarrinho.Text = "Adicionar";
            this.btnAdicionarAoCarrinho.UseVisualStyleBackColor = true;
            this.btnAdicionarAoCarrinho.Click += new System.EventHandler(this.btnAdicionarAoCarrinho_Click);
            // 
            // dataGridViewMenu1
            // 
            this.dataGridViewMenu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewMenu1.Location = new System.Drawing.Point(31, 47);
            this.dataGridViewMenu1.Name = "dataGridViewMenu1";
            this.dataGridViewMenu1.Size = new System.Drawing.Size(608, 163);
            this.dataGridViewMenu1.TabIndex = 6;
            this.dataGridViewMenu1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "descricao";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "preco";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "imagem";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 68;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(744, 245);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "label1";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnAdicionarSacola
            // 
            this.btnAdicionarSacola.Location = new System.Drawing.Point(713, 77);
            this.btnAdicionarSacola.Name = "btnAdicionarSacola";
            this.btnAdicionarSacola.Size = new System.Drawing.Size(123, 54);
            this.btnAdicionarSacola.TabIndex = 8;
            this.btnAdicionarSacola.Text = "add item";
            this.btnAdicionarSacola.UseVisualStyleBackColor = true;
            this.btnAdicionarSacola.Click += new System.EventHandler(this.btnAdicionarSacola_Click);
            // 
            // btnComanda
            // 
            this.btnComanda.Location = new System.Drawing.Point(679, 165);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(157, 45);
            this.btnComanda.TabIndex = 9;
            this.btnComanda.Text = "Confirmar";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Location = new System.Drawing.Point(713, 273);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(90, 38);
            this.btnRecarregar.TabIndex = 10;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // Tela_Cardapio_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 497);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.btnAdicionarSacola);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridViewMenu1);
            this.Controls.Add(this.btnAdicionarAoCarrinho);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tela_Cardapio_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Cardapio";
            this.Load += new System.EventHandler(this.Tela_Cardapio_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionarAoCarrinho;
        private System.Windows.Forms.DataGridView dataGridViewMenu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAdicionarSacola;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Button btnRecarregar;
    }
}