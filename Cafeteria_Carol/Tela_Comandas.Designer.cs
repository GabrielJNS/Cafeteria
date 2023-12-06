
namespace Cafeteria_Carol
{
    partial class Tela_Comandas
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(309, 292);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label1";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(624, 304);
            this.btnPagamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(177, 39);
            this.btnPagamento.TabIndex = 2;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            // 
            // dataGridViewComandas
            // 
            this.dataGridViewComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandas.Location = new System.Drawing.Point(40, 34);
            this.dataGridViewComandas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewComandas.Name = "dataGridViewComandas";
            this.dataGridViewComandas.RowHeadersWidth = 51;
            this.dataGridViewComandas.Size = new System.Drawing.Size(803, 185);
            this.dataGridViewComandas.TabIndex = 0;
            this.dataGridViewComandas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComandas_CellContentClick);
            // 
            // Tela_Comandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridViewComandas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tela_Comandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Comandas";
            this.Load += new System.EventHandler(this.Tela_Comandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.DataGridView dataGridViewComandas;
    }
}