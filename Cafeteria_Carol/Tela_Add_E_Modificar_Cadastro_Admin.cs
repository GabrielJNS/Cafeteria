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
    }
}
