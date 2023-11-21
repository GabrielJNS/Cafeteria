using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace Cafeteria_Carol
{
    public partial class Tela_Gerenciar_Produtos : Form
    {
        private string connectionString = ConfiguracaoBanco.CaminhoBanco;

        public Tela_Gerenciar_Produtos()
        {
            InitializeComponent();
        }

        private void bt_AdicionarProduto_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text;
            string descricao = txtDescricaoProduto.Text;
            decimal preco;

            if (decimal.TryParse(txtPrecoProduto.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out preco))
            {
                AdicionarProduto(nome, descricao, preco, null);
            }
            else
            {
                MessageBox.Show("Preço inválido. Certifique-se de inserir um valor numérico válido.");
            }
        }

        private void bt_ModificarProduto_Click(object sender, EventArgs e)
        {
            int produtoId;
            if (int.TryParse(txtIDProduto.Text, out produtoId))
            {
                string nome = txtNomeProduto.Text;
                string descricao = txtDescricaoProduto.Text;
                decimal preco;

                if (decimal.TryParse(txtPrecoProduto.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out preco))
                {
                    ModificarProduto(produtoId, nome, descricao, preco, null);
                }
                else
                {
                    MessageBox.Show("Preço inválido. Certifique-se de inserir um valor numérico válido.");
                }
            }
            else
            {
                MessageBox.Show("ID de produto inválido. Certifique-se de inserir um número inteiro válido.");
            }
        }

        private void bt_ExcluirProduto_Click(object sender, EventArgs e)
        {
            int produtoId;
            if (int.TryParse(txtIDProduto.Text, out produtoId))
            {
                ExcluirProduto(produtoId);
                MessageBox.Show("Produto excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("ID de produto inválido. Certifique-se de inserir um número inteiro válido.");
            }
        }

        private void AdicionarProduto(string nome, string descricao, decimal preco, byte[] imagem)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "INSERT INTO Cardapio (Nome, Descricao, Preco, Imagem) VALUES (@Nome, @Descricao, @Preco, @Imagem)";

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Descricao", descricao);
                        command.Parameters.AddWithValue("@Preco", preco);
                        command.Parameters.AddWithValue("@Imagem", imagem);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produto adicionado com sucesso!");

                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar o produto: " + ex.Message);
                }
            }
        }

        private void ModificarProduto(int produtoId, string nome, string descricao, decimal preco, byte[] imagem)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (ProdutoExiste(produtoId, connection))
                    {
                        string sql = "UPDATE Cardapio SET Nome = @Nome, Descricao = @Descricao, Preco = @Preco, Imagem = @Imagem WHERE ID = @ID";

                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@ID", produtoId);
                            command.Parameters.AddWithValue("@Nome", nome);
                            command.Parameters.AddWithValue("@Descricao", descricao);
                            command.Parameters.AddWithValue("@Preco", preco);
                            command.Parameters.AddWithValue("@Imagem", imagem);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Produto modificado com sucesso!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O produto com ID " + produtoId + " não existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao modificar o produto: " + ex.Message);
                }
            }
        }

        private void ExcluirProduto(int produtoId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (ProdutoExiste(produtoId, connection))
                    {
                        string sql = "DELETE FROM Cardapio WHERE ID = @ID";

                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@ID", produtoId);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Produto excluído com sucesso!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O produto com ID " + produtoId + " não existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o produto: " + ex.Message);
                }
            }
        }

        private bool ProdutoExiste(int produtoId, SQLiteConnection connection)
        {
            string sql = "SELECT COUNT(*) FROM Cardapio WHERE ID = @ID";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ID", produtoId);
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        private void LimparCampos()
        {
            txtNomeProduto.Text = string.Empty;
            txtDescricaoProduto.Text = string.Empty;
            txtPrecoProduto.Text = string.Empty;
            txtIDProduto.Text = string.Empty;
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricaoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoProduto_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtIDProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fotos_Enviar_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Gerenciar_Produtos_Load(object sender, EventArgs e)
        {

        }
    }
}
