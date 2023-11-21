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
        private string connectionString = ConfiguracaoBanco.CaminhoBanco;

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


            {
                string email = textbox_logemail.Text;
                string senha = textBox_logsenha.Text;
                string nomeUsuario = email;
                MessageBox.Show($"Nome do usuário ao entrar: {nomeUsuario}");

                using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
                {
                    connection.Open();

                    string query = "SELECT Nivel FROM Usuarios WHERE Email = @Email AND Senha = @Senha";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int nivel = Convert.ToInt32(result);
                            MessageBox.Show($"Login bem-sucedido! Nível: {nivel}");

                            switch (nivel)
                            {
                                case 1:
                                    NomeUsuarioLogado = email;
                                    Tela_Principal_Usuario novoCliente = new Tela_Principal_Usuario(email);
                                    novoCliente.Show();
                                    break;
                                case 2:
                                    NomeUsuarioLogado = email;
                                    Tela_Principal_Atendente novoAtendente = new Tela_Principal_Atendente(email);
                                    novoAtendente.Show();
                                    break;
                                case 3:
                                    NomeUsuarioLogado = email;
                                    Tela_Principal_Admin novoAdmin = new Tela_Principal_Admin(email);
                                    novoAdmin.Show();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos. Tente novamente.");
                        }
                    }
                }
            }
        }


        private void CriarTabelaCardapio()
        {

            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
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

            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
                   CREATE TABLE IF NOT EXISTS Pedidos (
                    PedidoID INTEGER PRIMARY KEY AUTOINCREMENT,
                    NomeCliente TEXT,
                    NomeProduto TEXT, 
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
        private string ObterNomeUsuario(string nome)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
            {
                connection.Open();

                string query = "SELECT Nome FROM Usuarios WHERE Nome = @Nome";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
        }
    }
}
