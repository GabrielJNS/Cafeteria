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


namespace Cafeteria_Carol
{
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void Logar_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Bt_cadastrar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro nova = new Tela_Cadastro();
            nova.Show();
        }

        private void Bt_entrar_Click(object sender, EventArgs e)
        {
            string email = textbox_logemail.Text; 
            string senha = textBox_logsenha.Text; 

            string connectionString = "Data Source=C:\\Users\\gabri\\source\\repos\\Projeto_Cafeteria\\Cafeteria_Carol\\Banco\\bd_cafeteria.db";
           
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email AND Senha = @Senha";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);

                    int result = Convert.ToInt32(command.ExecuteScalar());


                    if (result > 0)
                    {
                        MessageBox.Show("Login bem-sucedido!");

                        Tela_Principal novo = new Tela_Principal();
                        novo.Show();

                        
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha incorretos. Tente novamente.");
                    }
                    
                }
            }
        
    }
    }
}
