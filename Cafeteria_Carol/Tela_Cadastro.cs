using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;


namespace Cafeteria_Carol
{

    public partial class Tela_Cadastro : Form
    {


        public Tela_Cadastro()
        {
            InitializeComponent();
            CriarTabelaUsuarios();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void campo_Tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void campo_Data_TextChanged(object sender, EventArgs e)
        {
        }

        public void bt_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = campo_Nome.Text;
            string email = campo_Email.Text;
            string senha = campo_Senha.Text;
            string telefone = campo_Tel.Text;
            string dataNascimento = campo_Data.Text;
            string verifSenha = campo_Conf_Senha.Text;
            string verificarEmail = campo_Conf_Email.Text;



            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(dataNascimento))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar.");
                return;
            }

            if (!IsValidEmail(email) || !IsValidEmail(verificarEmail))
            {
                MessageBox.Show("Insira um endereço de email válido e verifique o campo de confirmação de email.");
                return;
            }

            if (!IsTelefoneValido(telefone))
            {
                MessageBox.Show("Formato de telefone inválido. Use (00) 00000-0000.");
                return;
            }

            if (!IsDataValida(dataNascimento))
            {
                MessageBox.Show("Formato de data inválido. Use 00/00/0000.");
                return;
            }

            if (email != verificarEmail)
            {
                MessageBox.Show("Os campos de email e verificação de email não coincidem.");
                return;
            }

            if (senha != verifSenha)
            {
                MessageBox.Show("Os campos de senha e verificação de senha não coincidem.");
                return;
            }
           
            int nivel = 1;

            if (email.EndsWith("@atendente.com"))
            {
                nivel = 2; 
            }
            else if (email.EndsWith("@admin.com"))
            {
                nivel = 3; 
            }


            //Conector

            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco)) 
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
                        INSERT INTO Usuarios (Nome, Email, Senha, Telefone, DataNascimento, Nivel)
                        VALUES (@Nome, @Email, @Senha, @Telefone, @DataNascimento, @Nivel)
                    ";

                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    command.Parameters.AddWithValue("@Nivel", nivel);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!");
                    Close();
                }
            }
        }

        public void CriarTabelaUsuarios()
        {

            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco)) 
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Usuarios (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome TEXT,
                            Email TEXT,
                            Senha TEXT,
                            Telefone TEXT,
                            DataNascimento DATE,
                            Nivel INTEGER

                        );
                    ";

                    command.ExecuteNonQuery();
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsTelefoneValido(string telefone)
        {
            string pattern = @"^\(\d{2}\)\s\d{5}-\d{4}$";
            return Regex.IsMatch(telefone, pattern);
        }

        private bool IsDataValida(string data)
        {
            string pattern = @"^\d{2}/\d{2}/\d{4}$";
            return Regex.IsMatch(data, pattern);
        }

        private void Tela_Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
        
            

