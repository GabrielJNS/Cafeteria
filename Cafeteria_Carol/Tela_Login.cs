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

        public static string NomeUsuarioLogado { get; private set; }

        public Tela_Login()
        {
            InitializeComponent();
            CriarTabelaCardapio();
            CriarTabelaPedidos();
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

        public void Bt_entrar_Click(object sender, EventArgs e)
        {
            string email = textbox_logemail.Text;
            string senha = textBox_logsenha.Text;

            string nomeUsuario = email;

            string connectionString = "Data Source=C:\\Users\\gabri\\source\\repos\\Projeto_Cafeteria\\Cafeteria_Carol\\Banco\\bd_cafeteria.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email AND Senha = @Senha";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);

                    int nivel = Convert.ToInt32(command.ExecuteScalar());

                    if (nivel > 0)
                    {
                        if (email.EndsWith("hotmail.com") || email.EndsWith("gmail.com"))
                        {
                            nivel = 1;
                            MessageBox.Show($"Usuário {email} login bem-sucedido!");
                            NomeUsuarioLogado = nomeUsuario; 

                            Tela_Principal_Usuario novo = new Tela_Principal_Usuario(nomeUsuario);
                            novo.Show();
                        }
                        else if (email.EndsWith("@atendente.com"))
                        {
                            nivel = 2;
                            MessageBox.Show($"Atendente {email} login bem-sucedido!");
                            NomeUsuarioLogado = nomeUsuario;

                            Tela_Principal_Atendente novo = new Tela_Principal_Atendente(nomeUsuario);
                            novo.Show();
                        }
                        else if (email.EndsWith("@admin.com"))
                        {
                            nivel = 3;
                            MessageBox.Show($"Admin {email} login bem-sucedido!");
                            NomeUsuarioLogado = nomeUsuario; 

                            Tela_Principal_Admin novo = new Tela_Principal_Admin(nomeUsuario);
                            novo.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha incorretos. Tente novamente.");
                    }
                    MessageBox.Show("Nível: " + nivel);
                }
            }
        }


        private void CriarTabelaCardapio()
        {
            string connectionString = "Data Source=C:\\Users\\gabri\\source\\repos\\Projeto_Cafeteria\\Cafeteria_Carol\\Banco\\bd_cafeteria.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Cardapio (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome TEXT,
                            Descricao TEXT,
                            Preco REAL,
                            Imagem BLOB
                        );
                    ";

                    command.ExecuteNonQuery();
                }
            }
        }
        
            public void CriarTabelaPedidos()
            {
                string connectionString = "Data Source=C:\\Users\\gabri\\source\\repos\\Projeto_Cafeteria\\Cafeteria_Carol\\Banco\\bd_cafeteria.db";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Pedidos (
                            PedidoID INTEGER PRIMARY KEY AUTOINCREMENT,
                            ClienteID INTEGER,
                            ItemID INTEGER,
                            Quantidade INTEGER,
                            HoraPedido DATETIME,
                            Status TEXT
                        );
                    ";

                        command.ExecuteNonQuery();
                    }
                }
            }
        

        private void textBox_logsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_logsenha_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}
