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
        
        public partial class Tela_Gerenciar_Produtos : Form
        {
            private string connectionString = "Data Source=C:\\Users\\gabri\\source\\repos\\Projeto_Cafeteria\\Cafeteria_Carol\\Banco\\bd_cafeteria.db";

            public Tela_Gerenciar_Produtos()
            {
                InitializeComponent();
            }

            private void bt_AdicionarProduto_Click(object sender, EventArgs e)
            {
                string nome = txtNomeProduto.Text;
                string descricao = txtDescricaoProduto.Text;
                decimal preco;

                if (decimal.TryParse(txtPrecoProduto.Text, out preco))
                {
                    AdicionarProduto(nome, descricao, preco, null);
                    MessageBox.Show("Produto adicionado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Preço inválido. Certifique-se de inserir um valor numérico válido.");
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao adicionar o produto: " + ex.Message);
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

                        string sql = "DELETE FROM Cardapio WHERE ID = @ID";

                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@ID", produtoId);

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o produto: " + ex.Message);
                    }
                }
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

    }
}
