
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_logemail = new System.Windows.Forms.TextBox();
            this.label_logemail = new System.Windows.Forms.Label();
            this.label_logsenha = new System.Windows.Forms.Label();
            this.textBox_logsenha = new System.Windows.Forms.TextBox();
            this.label_semcadastro = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_entrar
            // 
            this.bt_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_entrar.Location = new System.Drawing.Point(267, 195);
            this.bt_entrar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(50, 24);
            this.bt_entrar.TabIndex = 0;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.Bt_entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olá,entre com a sua conta para acessar nosso aplicativo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textbox_logemail
            // 
            this.textbox_logemail.Location = new System.Drawing.Point(202, 104);
            this.textbox_logemail.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_logemail.Name = "textbox_logemail";
            this.textbox_logemail.Size = new System.Drawing.Size(182, 20);
            this.textbox_logemail.TabIndex = 2;
            this.textbox_logemail.Text = "jose@hotmail.com";
            this.textbox_logemail.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label_logemail
            // 
            this.label_logemail.AutoSize = true;
            this.label_logemail.Location = new System.Drawing.Point(163, 104);
            this.label_logemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_logemail.Name = "label_logemail";
            this.label_logemail.Size = new System.Drawing.Size(38, 13);
            this.label_logemail.TabIndex = 3;
            this.label_logemail.Text = "E-mail:";
            this.label_logemail.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label_logsenha
            // 
            this.label_logsenha.AutoSize = true;
            this.label_logsenha.Location = new System.Drawing.Point(160, 150);
            this.label_logsenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_logsenha.Name = "label_logsenha";
            this.label_logsenha.Size = new System.Drawing.Size(41, 13);
            this.label_logsenha.TabIndex = 4;
            this.label_logsenha.Text = "Senha:";
            this.label_logsenha.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox_logsenha
            // 
            this.textBox_logsenha.Location = new System.Drawing.Point(202, 148);
            this.textBox_logsenha.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_logsenha.Name = "textBox_logsenha";
            this.textBox_logsenha.Size = new System.Drawing.Size(185, 20);
            this.textBox_logsenha.TabIndex = 5;
            this.textBox_logsenha.Text = "123";
            this.textBox_logsenha.TextChanged += new System.EventHandler(this.textBox_logsenha_TextChanged_1);
            // 
            // label_semcadastro
            // 
            this.label_semcadastro.AutoSize = true;
            this.label_semcadastro.Location = new System.Drawing.Point(200, 241);
            this.label_semcadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_semcadastro.Name = "label_semcadastro";
            this.label_semcadastro.Size = new System.Drawing.Size(100, 13);
            this.label_semcadastro.TabIndex = 6;
            this.label_semcadastro.Text = "Não tem cadastro ?\r\n";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar.Location = new System.Drawing.Point(302, 236);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(83, 28);
            this.bt_cadastrar.TabIndex = 7;
            this.bt_cadastrar.Text = "Cadastra-se";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.Bt_cadastrar_Click);
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 297);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.label_semcadastro);
            this.Controls.Add(this.textBox_logsenha);
            this.Controls.Add(this.label_logsenha);
            this.Controls.Add(this.label_logemail);
            this.Controls.Add(this.textbox_logemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_entrar);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_logemail;
        private System.Windows.Forms.Label label_logemail;
        private System.Windows.Forms.Label label_logsenha;
        private System.Windows.Forms.TextBox textBox_logsenha;
        private System.Windows.Forms.Label label_semcadastro;
        private System.Windows.Forms.Button bt_cadastrar;
    }
}