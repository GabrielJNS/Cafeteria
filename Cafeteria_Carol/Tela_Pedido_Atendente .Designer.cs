
namespace Cafeteria_Carol
{
    partial class Tela_Pedido_Atendente
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
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.txtPedidoID = new System.Windows.Forms.TextBox();
            this.btnMarcarConcluido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewPedidos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.Size = new System.Drawing.Size(543, 388);
            this.dataGridViewPedidos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PedidoID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NomeCliente";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ItemID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantidade";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "HoraPedido";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Location = new System.Drawing.Point(630, 169);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(113, 51);
            this.btnRecarregar.TabIndex = 2;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // txtPedidoID
            // 
            this.txtPedidoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPedidoID.Location = new System.Drawing.Point(630, 35);
            this.txtPedidoID.Name = "txtPedidoID";
            this.txtPedidoID.Size = new System.Drawing.Size(116, 20);
            this.txtPedidoID.TabIndex = 3;
            this.txtPedidoID.TextChanged += new System.EventHandler(this.txtPedidoID_TextChanged);
            // 
            // btnMarcarConcluido
            // 
            this.btnMarcarConcluido.BackColor = System.Drawing.Color.Transparent;
            this.btnMarcarConcluido.FlatAppearance.BorderSize = 4;
            this.btnMarcarConcluido.Location = new System.Drawing.Point(645, 61);
            this.btnMarcarConcluido.Name = "btnMarcarConcluido";
            this.btnMarcarConcluido.Size = new System.Drawing.Size(82, 36);
            this.btnMarcarConcluido.TabIndex = 4;
            this.btnMarcarConcluido.Text = "Marcar como Concluido";
            this.btnMarcarConcluido.UseVisualStyleBackColor = false;
            this.btnMarcarConcluido.Click += new System.EventHandler(this.btnMarcarConcluido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o ID do pedido apos finalizar o pedido";
            // 
            // Tela_Pedido_Atendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMarcarConcluido);
            this.Controls.Add(this.txtPedidoID);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Name = "Tela_Pedido_Atendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Pedido_Atendente";
            this.Load += new System.EventHandler(this.Tela_Pedido_Atendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.TextBox txtPedidoID;
        private System.Windows.Forms.Button btnMarcarConcluido;
        private System.Windows.Forms.Label label1;
    }
}