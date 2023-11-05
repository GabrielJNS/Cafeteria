using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Cafeteria_Carol
{
    public partial class Tela_Cardapio_Usuario : Form
    {
        private string connectionString = "Data Source=C:\\Users\\gabri\\source\\repos\\Projeto_Cafeteria\\Cafeteria_Carol\\Banco\\bd_cafeteria.db";
        private Sacola sacola = new Sacola();


        public Tela_Cardapio_Usuario()
        {
            InitializeComponent();
            CarregarItensCardapio();
        }

        private void CarregarItensCardapio()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, Nome, Descricao, Preco, Imagem FROM Cardapio";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable cardapioTable = new DataTable();
                    adapter.Fill(cardapioTable);

                    foreach (DataRow row in cardapioTable.Rows)
                    {
                        int id = Convert.ToInt32(row["ID"]);
                        string nome = row["Nome"].ToString();
                        string descricao = row["Descricao"].ToString();
                        double preco = Convert.ToDouble(row["Preco"]);

                        dataGridViewMenu1.Rows.Add(id, nome, descricao, preco);

                        var btnAdicionarAoCarrinho = new Button();
                        btnAdicionarAoCarrinho.Text = "Adicionar ao Carrinho";
                        btnAdicionarAoCarrinho.Click += (sender, e) => AdicionarAoCarrinhoClick(id, nome, descricao, preco);
                        dataGridViewMenu1.Controls.Add(btnAdicionarAoCarrinho);
                    }
                }
            }
        }

        private void AdicionarAoCarrinhoClick(int id, string nome, string descricao, double preco)
        {
            int itemID = id; 
            ItemSacola item = new ItemSacola(id, nome, descricao, preco);
            sacola.AdicionarItem(item);
            AtualizarTotal();
            
        }
    

        private void AtualizarTotal()
        {
            double total = 0;

            foreach (var itemNaSacola in sacola.Itens)
            {
                total += itemNaSacola.Preco;
            }

            lblTotal.Text = $"Total: R$ {total.ToString("F2")}";
        }

        private void dataGridViewMenu1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tela_Cardapio_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            List<ItemSacola> itensCarrinho = sacola.Itens;

            string connectionString = "Data Source=C:\\Users\\gabri\\source\\repos\\Projeto_Cafeteria\\Cafeteria_Carol\\Banco\\bd_cafeteria.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in itensCarrinho)
                        {
                            string insertQuery = "INSERT INTO Pedidos (ClienteID, ItemID, Quantidade, HoraPedido, Status) " +
                                                "VALUES (@ClienteID, @ItemID, @Quantidade, @HoraPedido, @Status)";

                            using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ClienteID", 1);
                                command.Parameters.AddWithValue("@ItemID", item);
                                command.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                                command.Parameters.AddWithValue("@HoraPedido", DateTime.Now);
                                command.Parameters.AddWithValue("@Status", "Pendente");

                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        sacola.Limpar();
                        AtualizarTotal();

                        MessageBox.Show("Pedido realizado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show("Erro ao fazer o pedido: " + ex.Message);
                    }
                }
            }
        }

    }
}


