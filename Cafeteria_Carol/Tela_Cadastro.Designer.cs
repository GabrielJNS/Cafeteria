namespace Cafeteria_Carol
{
    partial class Tela_Cadastro
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
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.campo_Nome = new System.Windows.Forms.TextBox();
            this.cadastro_email = new System.Windows.Forms.Label();
            this.cadastro_confirmar_email = new System.Windows.Forms.Label();
            this.cadastro_senha = new System.Windows.Forms.Label();
            this.cadastro_confirmar_senha = new System.Windows.Forms.Label();
            this.campo_Email = new System.Windows.Forms.TextBox();
            this.campo_Conf_Email = new System.Windows.Forms.TextBox();
            this.campo_Senha = new System.Windows.Forms.TextBox();
            this.campo_Conf_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campo_Tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.campo_Data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(297, 309);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(102, 25);
            this.bt_cadastrar.TabIndex = 0;
            this.bt_cadastrar.Text = "Cadastrar-se";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(53, 78);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(45, 17);
            this.label_nome.TabIndex = 2;
            this.label_nome.Text = "Nome";
            // 
            // campo_Nome
            // 
            this.campo_Nome.Location = new System.Drawing.Point(104, 78);
            this.campo_Nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campo_Nome.Name = "campo_Nome";
            this.campo_Nome.Size = new System.Drawing.Size(89, 22);
            this.campo_Nome.TabIndex = 3;
            this.campo_Nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cadastro_email
            // 
            this.cadastro_email.AutoSize = true;
            this.cadastro_email.Location = new System.Drawing.Point(53, 117);
            this.cadastro_email.Name = "cadastro_email";
            this.cadastro_email.Size = new System.Drawing.Size(47, 17);
            this.cadastro_email.TabIndex = 4;
            this.cadastro_email.Text = "E-mail";
            // 
            // cadastro_confirmar_email
            // 
            this.cadastro_confirmar_email.AutoSize = true;
            this.cadastro_confirmar_email.Location = new System.Drawing.Point(53, 154);
            this.cadastro_confirmar_email.Name = "cadastro_confirmar_email";
            this.cadastro_confirmar_email.Size = new System.Drawing.Size(112, 17);
            this.cadastro_confirmar_email.TabIndex = 5;
            this.cadastro_confirmar_email.Text = "Confirmar E-mail";
            // 
            // cadastro_senha
            // 
            this.cadastro_senha.AutoSize = true;
            this.cadastro_senha.Location = new System.Drawing.Point(53, 188);
            this.cadastro_senha.Name = "cadastro_senha";
            this.cadastro_senha.Size = new System.Drawing.Size(49, 17);
            this.cadastro_senha.TabIndex = 6;
            this.cadastro_senha.Text = "Senha";
            // 
            // cadastro_confirmar_senha
            // 
            this.cadastro_confirmar_senha.AutoSize = true;
            this.cadastro_confirmar_senha.Location = new System.Drawing.Point(53, 225);
            this.cadastro_confirmar_senha.Name = "cadastro_confirmar_senha";
            this.cadastro_confirmar_senha.Size = new System.Drawing.Size(112, 17);
            this.cadastro_confirmar_senha.TabIndex = 7;
            this.cadastro_confirmar_senha.Text = "Confirmar senha";
            // 
            // campo_Email
            // 
            this.campo_Email.Location = new System.Drawing.Point(107, 117);
            this.campo_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campo_Email.Name = "campo_Email";
            this.campo_Email.Size = new System.Drawing.Size(89, 22);
            this.campo_Email.TabIndex = 8;
            this.campo_Email.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // campo_Conf_Email
            // 
            this.campo_Conf_Email.Location = new System.Drawing.Point(171, 151);
            this.campo_Conf_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campo_Conf_Email.Name = "campo_Conf_Email";
            this.campo_Conf_Email.Size = new System.Drawing.Size(89, 22);
            this.campo_Conf_Email.TabIndex = 9;
            // 
            // campo_Senha
            // 
            this.campo_Senha.Location = new System.Drawing.Point(109, 188);
            this.campo_Senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campo_Senha.Name = "campo_Senha";
            this.campo_Senha.Size = new System.Drawing.Size(89, 22);
            this.campo_Senha.TabIndex = 10;
            // 
            // campo_Conf_Senha
            // 
            this.campo_Conf_Senha.Location = new System.Drawing.Point(172, 225);
            this.campo_Conf_Senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campo_Conf_Senha.Name = "campo_Conf_Senha";
            this.campo_Conf_Senha.Size = new System.Drawing.Size(89, 22);
            this.campo_Conf_Senha.TabIndex = 11;
            this.campo_Conf_Senha.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Telefone";
            // 
            // campo_Tel
            // 
            this.campo_Tel.Location = new System.Drawing.Point(455, 80);
            this.campo_Tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campo_Tel.Name = "campo_Tel";
            this.campo_Tel.Size = new System.Drawing.Size(89, 22);
            this.campo_Tel.TabIndex = 13;
            this.campo_Tel.TextChanged += new System.EventHandler(this.campo_Tel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data de Nascimento";
            // 
            // campo_Data
            // 
            this.campo_Data.Location = new System.Drawing.Point(527, 139);
            this.campo_Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campo_Data.Name = "campo_Data";
            this.campo_Data.Size = new System.Drawing.Size(89, 22);
            this.campo_Data.TabIndex = 15;
            this.campo_Data.TextChanged += new System.EventHandler(this.campo_Data_TextChanged);
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.campo_Data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.campo_Tel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campo_Conf_Senha);
            this.Controls.Add(this.campo_Senha);
            this.Controls.Add(this.campo_Conf_Email);
            this.Controls.Add(this.campo_Email);
            this.Controls.Add(this.cadastro_confirmar_senha);
            this.Controls.Add(this.cadastro_senha);
            this.Controls.Add(this.cadastro_confirmar_email);
            this.Controls.Add(this.cadastro_email);
            this.Controls.Add(this.campo_Nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cadastrar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tela_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox campo_Nome;
        private System.Windows.Forms.Label cadastro_email;
        private System.Windows.Forms.Label cadastro_confirmar_email;
        private System.Windows.Forms.Label cadastro_senha;
        private System.Windows.Forms.Label cadastro_confirmar_senha;
        private System.Windows.Forms.TextBox campo_Email;
        private System.Windows.Forms.TextBox campo_Conf_Email;
        private System.Windows.Forms.TextBox campo_Senha;
        private System.Windows.Forms.TextBox campo_Conf_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campo_Tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campo_Data;
    }
}