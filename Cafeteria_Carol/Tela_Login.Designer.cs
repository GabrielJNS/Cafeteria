
namespace Cafeteria_Carol
{
    partial class Tela_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            this.bt_entrar = new System.Windows.Forms.Button();
            this.textbox_logemail = new System.Windows.Forms.TextBox();
            this.textBox_logsenha = new System.Windows.Forms.TextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_entrar
            // 
            this.bt_entrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_entrar.FlatAppearance.BorderSize = 0;
            this.bt_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_entrar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_entrar.Location = new System.Drawing.Point(135, 488);
            this.bt_entrar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(172, 39);
            this.bt_entrar.TabIndex = 0;
            this.bt_entrar.UseVisualStyleBackColor = false;
            this.bt_entrar.Click += new System.EventHandler(this.Bt_entrar_Click);
            // 
            // textbox_logemail
            // 
            this.textbox_logemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textbox_logemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_logemail.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.textbox_logemail.Location = new System.Drawing.Point(88, 326);
            this.textbox_logemail.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_logemail.Name = "textbox_logemail";
            this.textbox_logemail.Size = new System.Drawing.Size(266, 16);
            this.textbox_logemail.TabIndex = 2;
            this.textbox_logemail.Text = "jose@hotmail.com";
            this.textbox_logemail.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox_logsenha
            // 
            this.textBox_logsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox_logsenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_logsenha.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.textBox_logsenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_logsenha.Location = new System.Drawing.Point(88, 403);
            this.textBox_logsenha.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_logsenha.Name = "textBox_logsenha";
            this.textBox_logsenha.Size = new System.Drawing.Size(266, 16);
            this.textBox_logsenha.TabIndex = 5;
            this.textBox_logsenha.Text = "123";
            this.textBox_logsenha.TextChanged += new System.EventHandler(this.textBox_logsenha_TextChanged_1);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar.FlatAppearance.BorderSize = 0;
            this.bt_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cadastrar.Location = new System.Drawing.Point(135, 555);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(172, 36);
            this.bt_cadastrar.TabIndex = 0;
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.Bt_cadastrar_Click);
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cafeteria_Carol.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 749);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.textBox_logsenha);
            this.Controls.Add(this.textbox_logemail);
            this.Controls.Add(this.bt_entrar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logar";
            this.Load += new System.EventHandler(this.Logar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.TextBox textbox_logemail;
        private System.Windows.Forms.TextBox textBox_logsenha;
        private System.Windows.Forms.Button bt_cadastrar;
    }
}