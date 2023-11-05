
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
            this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComandas
            // 
            this.dataGridViewComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandas.Location = new System.Drawing.Point(30, 28);
            this.dataGridViewComandas.Name = "dataGridViewComandas";
            this.dataGridViewComandas.Size = new System.Drawing.Size(673, 150);
            this.dataGridViewComandas.TabIndex = 0;
            this.dataGridViewComandas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComandas_CellContentClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(232, 237);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label1";
            // 
            // Tela_Comandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 366);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridViewComandas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tela_Comandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Comandas";
            this.Load += new System.EventHandler(this.Tela_Comandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComandas;
        private System.Windows.Forms.Label lblTotal;
    }
}