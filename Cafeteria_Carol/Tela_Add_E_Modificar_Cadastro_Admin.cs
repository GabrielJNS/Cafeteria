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
    public partial class Tela_Add_E_Modificar_Cadastro_Admin : Form
    {

        private bool modoAdicionar = true;
        private int usuarioID;

        public Tela_Add_E_Modificar_Cadastro_Admin()
        {
            InitializeComponent();
        }

        public void ConfigurarModoModificar(int idUsuario)
        {
            modoAdicionar = false;
            usuarioID = idUsuario;
            CarregarInformacoesUsuarioParaEditar();
        }

        private void Tela_Add_E_Modificar_Cadastro_Admin_Load(object sender, EventArgs e)
        {
            if (!modoAdicionar)
            {
                CarregarInformacoesUsuarioParaEditar();
            }
        }

        private void CarregarInformacoesUsuarioParaEditar()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
            {
                connection.Open();

                string query = "SELECT * FROM Usuarios WHERE ID = @ID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", usuarioID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            campo_Nome.Text = reader["Nome"].ToString();
                            campo_Email.Text = reader["Email"].ToString();
                            campo_Senha.Text = reader["Senha"].ToString();
                            campo_Tel.Text = reader["Telefone"].ToString();
                            campo_Data.Text = reader["DataNascimento"].ToString();
                        }
                    }
                }
            }
        }

        private void campo_Nome_TextChanged(object sender, EventArgs e)
        {
        }

        private void campo_Email_TextChanged(object sender, EventArgs e)
        {
        }

        private void campo_Senha_TextChanged(object sender, EventArgs e)
        {
        }

        private void campo_Tel_TextChanged(object sender, EventArgs e)
        {
        }

        private void campo_Data_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modoAdicionar)
                {
                    AdicionarUsuario();
                }
                else
                {
                    ModificarUsuario();
                }

                MessageBox.Show("Operação concluída com sucesso!");
                Close();
            }
        }

        private void AdicionarUsuario()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {


                    command.CommandText = @"
                    INSERT INTO Usuarios (Nome, Email, Senha, Telefone, DataNascimento, Nivel)
                    VALUES (@Nome, @Email, @Senha, @Telefone, @DataNascimento, @Nivel)
                ";

                    PreencherParametros(command);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void ModificarUsuario()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
                        UPDATE Usuarios
                        SET Nome = @Nome, Email = @Email, Senha = @Senha, Telefone = @Telefone, 
                            DataNascimento = @DataNascimento
                        WHERE ID = @ID
                    ";

                    command.Parameters.AddWithValue("@ID", usuarioID);

                    PreencherParametros(command);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void PreencherParametros(SQLiteCommand command)
        {

            command.Parameters.AddWithValue("@Nome", campo_Nome.Text);
            command.Parameters.AddWithValue("@Email", campo_Email.Text);
            command.Parameters.AddWithValue("@Senha", campo_Senha.Text);
            command.Parameters.AddWithValue("@Telefone", campo_Tel.Text);
            command.Parameters.AddWithValue("@DataNascimento", campo_Data.Text);

            int nivel = 1;
            if (Box_Nivel != null && !string.IsNullOrEmpty(Box_Nivel.Text))
            {
                if (int.TryParse(Box_Nivel.Text, out int nivelEscolhido))
                {
                    nivel = nivelEscolhido;
                }
                else
                {
                    MessageBox.Show("Digite um número válido para o nível.");
                    return;
                }
            }
            command.Parameters.AddWithValue("@Nivel", nivel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Box_Nivel_TextChanged(object sender, EventArgs e)
        {

        }
        

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(campo_Nome.Text) || string.IsNullOrEmpty(campo_Email.Text) || string.IsNullOrEmpty(campo_Senha.Text) || string.IsNullOrEmpty(campo_Tel.Text) || string.IsNullOrEmpty(campo_Data.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar.");
                return false;
            }

            if (!Validacao.IsEmailValido(campo_Email.Text))
            {
                MessageBox.Show("Insira um endereço de email válido.");
                return false;
            }

            if (!Validacao.IsTelefoneValido(campo_Tel.Text))
            {
                MessageBox.Show("Formato de telefone inválido. Use (00) 00000-0000.");
                return false;
            }

            if (!Validacao.IsDataValida(campo_Data.Text))
            {
                MessageBox.Show("Formato de data inválido. Use 00/00/0000.");
                return false;
            }

                return true;
        }

        public static class Validacao
        {
            public static bool IsEmailValido(string email)
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

            public static bool IsTelefoneValido(string telefone)
            {
                string pattern = @"^\(\d{2}\)\s\d{5}-\d{4}$";
                return Regex.IsMatch(telefone, pattern);
            }

            public static bool IsDataValida(string data)
            {
                string pattern = @"^\d{2}/\d{2}/\d{4}$";
                return Regex.IsMatch(data, pattern);
            }
        }
    }
}
            