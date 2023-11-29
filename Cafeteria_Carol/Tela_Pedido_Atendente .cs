using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Cafeteria_Carol
{
    public partial class Tela_Pedido_Atendente : Form
    {
        public Tela_Pedido_Atendente()
        {
            InitializeComponent();
            CarregarPedidosPendentes();
            
        }

        private string connectionString = ConfiguracaoBanco.CaminhoBanco;
        private Sacola sacola = new Sacola();

        private void CarregarPedidosPendentes()
        {

            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
            {
                connection.Open();
                string query = "SELECT PedidoID, NomeCliente, NomeProduto, Quantidade, HoraPedido, Status FROM Pedidos WHERE Status = 'Pendente'";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable pedidosTable = new DataTable();
                    adapter.Fill(pedidosTable);

                    dataGridViewPedidos.Rows.Clear();

                    foreach (DataRow row in pedidosTable.Rows)
                    {
                        int pedidoID = Convert.ToInt32(row["PedidoID"]);
                        string NomeCliente = row["NomeCliente"].ToString();
                        string nomeProduto = row["NomeProduto"].ToString();
                        int quantidade = Convert.ToInt32(row["Quantidade"]);
                        DateTime horaPedido = Convert.ToDateTime(row["HoraPedido"]);

                        dataGridViewPedidos.Rows.Add(pedidoID, NomeCliente, nomeProduto, quantidade, horaPedido);
                    }
                }
            }
        }

        
        private void MarcarPedidoComoPendente(int pedidoID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
            {
                connection.Open();
                string updateQuery = "UPDATE Pedidos SET Status = 'Pendente' WHERE PedidoID = @PedidoID";

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@PedidoID", pedidoID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pedido marcado como Pendente!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao marcar o pedido como Pendente.");
                    }
                }
            }
        }
        private void MarcarPedidoComoConcluido(int pedidoID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
            {
                connection.Open();
                string updateQuery = "UPDATE Pedidos SET Status = 'Concluído' WHERE PedidoID = @PedidoID";

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@PedidoID", pedidoID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pedido marcado como concluído!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao marcar o pedido como concluído.");
                    }
                }
            }
        }
    


        private void Tela_Pedido_Atendente_Load(object sender, EventArgs e)
        {

        }
        private void AtualizarTotal()
        {
            double total = 0;

            foreach (var itemNaSacola in sacola.Itens)
            {
                total += itemNaSacola.Preco * itemNaSacola.Quantidade;
            }

        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            CarregarPedidosPendentes();
        }

        private void txtPedidoID_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnMarcarConcluido_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtPedidoID.Text, out int pedidoID))
                {
                    RemoverPedidoDoBanco(pedidoID);

                    CarregarPedidosPendentes();

                    sacola.Limpar();
                    AtualizarTotal();

                    MessageBox.Show("Pedido marcado como concluído!");
                }
                else
                {
                    MessageBox.Show("Digite um valor válido para o PedidoID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao marcar o pedido como concluído: " + ex.Message);
            }
        }
        private void RemoverPedidoDoBanco(int pedidoID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Pedidos WHERE PedidoID = @PedidoID";

                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@PedidoID", pedidoID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Falha ao excluir o pedido do banco.");
                    }
                }
            }
        }

        private void btnPedidoAtendido_Click(object sender, EventArgs e)
        {

        }
    }
}
