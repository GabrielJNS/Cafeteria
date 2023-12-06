
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarAoCarrinho
            // 
            this.btnAdicionarAoCarrinho.Location = new System.Drawing.Point(75, 218);
            this.btnAdicionarAoCarrinho.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarAoCarrinho.Name = "btnAdicionarAoCarrinho";
            this.btnAdicionarAoCarrinho.Size = new System.Drawing.Size(100, 28);
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
            this.dataGridViewMenu1.GridColor = System.Drawing.Color.Black;
            this.dataGridViewMenu1.Location = new System.Drawing.Point(16, 208);
            this.dataGridViewMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMenu1.Name = "dataGridViewMenu1";
            this.dataGridViewMenu1.RowHeadersWidth = 51;
            this.dataGridViewMenu1.Size = new System.Drawing.Size(841, 320);
            this.dataGridViewMenu1.TabIndex = 6;
            this.dataGridViewMenu1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nome";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "descricao";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "preco";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "imagem";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 86;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Coral;
            this.lblTotal.Location = new System.Drawing.Point(31, 548);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 24);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "label1";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnAdicionarSacola
            // 
            this.btnAdicionarSacola.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarSacola.FlatAppearance.BorderSize = 0;
            this.btnAdicionarSacola.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarSacola.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarSacola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarSacola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarSacola.Location = new System.Drawing.Point(900, 267);
            this.btnAdicionarSacola.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarSacola.Name = "btnAdicionarSacola";
            this.btnAdicionarSacola.Size = new System.Drawing.Size(287, 66);
            this.btnAdicionarSacola.TabIndex = 8;
            this.btnAdicionarSacola.UseVisualStyleBackColor = false;
            this.btnAdicionarSacola.Click += new System.EventHandler(this.btnAdicionarSacola_Click);
            // 
            // btnComanda
            // 
            this.btnComanda.BackColor = System.Drawing.Color.Transparent;
            this.btnComanda.FlatAppearance.BorderSize = 0;
            this.btnComanda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnComanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnComanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComanda.Location = new System.Drawing.Point(900, 400);
            this.btnComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(287, 66);
            this.btnComanda.TabIndex = 9;
            this.btnComanda.UseVisualStyleBackColor = false;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecarregar.FlatAppearance.BorderSize = 0;
            this.btnRecarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRecarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarregar.Location = new System.Drawing.Point(483, 570);
            this.btnRecarregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(285, 78);
            this.btnRecarregar.TabIndex = 10;
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1113, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tela_Cardapio_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cafeteria_Carol.Properties.Resources.Cardapio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1253, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.btnAdicionarSacola);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridViewMenu1);
            this.Controls.Add(this.btnAdicionarAoCarrinho);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
    }
}