
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
            this.bt_Pedidos = new System.Windows.Forms.Button();
            this.bt_Menu = new System.Windows.Forms.Button();
            this.bt_Comanda = new System.Windows.Forms.Button();
            this.lb_User = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Pedidos
            // 
            this.bt_Pedidos.BackColor = System.Drawing.Color.Transparent;
            this.bt_Pedidos.FlatAppearance.BorderSize = 0;
            this.bt_Pedidos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bt_Pedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Pedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_Pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Pedidos.Location = new System.Drawing.Point(675, 379);
            this.bt_Pedidos.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Pedidos.Name = "bt_Pedidos";
            this.bt_Pedidos.Size = new System.Drawing.Size(243, 62);
            this.bt_Pedidos.TabIndex = 2;
            this.bt_Pedidos.UseVisualStyleBackColor = false;
            this.bt_Pedidos.Click += new System.EventHandler(this.bt_Pedidos_Click);
            // 
            // bt_Menu
            // 
            this.bt_Menu.BackColor = System.Drawing.Color.Transparent;
            this.bt_Menu.FlatAppearance.BorderSize = 0;
            this.bt_Menu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bt_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Menu.Location = new System.Drawing.Point(675, 190);
            this.bt_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(243, 62);
            this.bt_Menu.TabIndex = 3;
            this.bt_Menu.UseVisualStyleBackColor = false;
            this.bt_Menu.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // bt_Comanda
            // 
            this.bt_Comanda.BackColor = System.Drawing.Color.Transparent;
            this.bt_Comanda.FlatAppearance.BorderSize = 0;
            this.bt_Comanda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bt_Comanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Comanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_Comanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Comanda.Location = new System.Drawing.Point(675, 286);
            this.bt_Comanda.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Comanda.Name = "bt_Comanda";
            this.bt_Comanda.Size = new System.Drawing.Size(243, 62);
            this.bt_Comanda.TabIndex = 4;
            this.bt_Comanda.UseVisualStyleBackColor = false;
            this.bt_Comanda.Click += new System.EventHandler(this.bt_Comanda_Click);
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.BackColor = System.Drawing.Color.Transparent;
            this.lb_User.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.ForeColor = System.Drawing.Color.Coral;
            this.lb_User.Location = new System.Drawing.Point(51, 9);
            this.lb_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(62, 23);
            this.lb_User.TabIndex = 6;
            this.lb_User.Text = "label1";
            this.lb_User.Click += new System.EventHandler(this.lb_User_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(941, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tela_Principal_Atendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cafeteria_Carol.Properties.Resources.AreaAtendente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.bt_Comanda);
            this.Controls.Add(this.bt_Menu);
            this.Controls.Add(this.bt_Pedidos);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tela_Principal_Atendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Principal_Atendente";
            this.Load += new System.EventHandler(this.Tela_Principal_Atendente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Pedidos;
        private System.Windows.Forms.Button bt_Menu;
        private System.Windows.Forms.Button bt_Comanda;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Button button1;
    }
}