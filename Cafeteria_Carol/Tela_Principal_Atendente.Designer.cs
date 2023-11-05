
namespace Cafeteria_Carol
{
    partial class Tela_Principal_Atendente
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
            this.bt_Pedidos = new System.Windows.Forms.Button();
            this.bt_Menu = new System.Windows.Forms.Button();
            this.bt_Comanda = new System.Windows.Forms.Button();
            this.bt_User_Atendente = new System.Windows.Forms.Button();
            this.lb_User = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Área do atendente ";
            // 
            // bt_Pedidos
            // 
            this.bt_Pedidos.Location = new System.Drawing.Point(529, 72);
            this.bt_Pedidos.Name = "bt_Pedidos";
            this.bt_Pedidos.Size = new System.Drawing.Size(200, 78);
            this.bt_Pedidos.TabIndex = 2;
            this.bt_Pedidos.Text = "Pedidos";
            this.bt_Pedidos.UseVisualStyleBackColor = true;
            this.bt_Pedidos.Click += new System.EventHandler(this.bt_Pedidos_Click);
            // 
            // bt_Menu
            // 
            this.bt_Menu.Location = new System.Drawing.Point(529, 156);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(200, 78);
            this.bt_Menu.TabIndex = 3;
            this.bt_Menu.Text = "Menu";
            this.bt_Menu.UseVisualStyleBackColor = true;
            // 
            // bt_Comanda
            // 
            this.bt_Comanda.Location = new System.Drawing.Point(529, 240);
            this.bt_Comanda.Name = "bt_Comanda";
            this.bt_Comanda.Size = new System.Drawing.Size(200, 78);
            this.bt_Comanda.TabIndex = 4;
            this.bt_Comanda.Text = "Comanda";
            this.bt_Comanda.UseVisualStyleBackColor = true;
            this.bt_Comanda.Click += new System.EventHandler(this.bt_Comanda_Click);
            // 
            // bt_User_Atendente
            // 
            this.bt_User_Atendente.Location = new System.Drawing.Point(3, 55);
            this.bt_User_Atendente.Name = "bt_User_Atendente";
            this.bt_User_Atendente.Size = new System.Drawing.Size(204, 78);
            this.bt_User_Atendente.TabIndex = 5;
            this.bt_User_Atendente.Text = "Usuário";
            this.bt_User_Atendente.UseVisualStyleBackColor = true;
            this.bt_User_Atendente.Click += new System.EventHandler(this.bt_User_Atendente_Click);
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(127, 170);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(35, 13);
            this.lb_User.TabIndex = 6;
            this.lb_User.Text = "label1";
            this.lb_User.Click += new System.EventHandler(this.lb_User_Click);
            // 
            // Tela_Principal_Atendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.bt_User_Atendente);
            this.Controls.Add(this.bt_Comanda);
            this.Controls.Add(this.bt_Menu);
            this.Controls.Add(this.bt_Pedidos);
            this.Controls.Add(this.label2);
            this.Name = "Tela_Principal_Atendente";
            this.Text = "Tela_Principal_Atendente";
            this.Load += new System.EventHandler(this.Tela_Principal_Atendente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Pedidos;
        private System.Windows.Forms.Button bt_Menu;
        private System.Windows.Forms.Button bt_Comanda;
        private System.Windows.Forms.Button bt_User_Atendente;
        private System.Windows.Forms.Label lb_User;
    }
}