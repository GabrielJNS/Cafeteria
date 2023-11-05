using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Cafeteria_Carol
{
    public partial class Tela_Pedido_Atendente : Form
    {
        public Tela_Pedido_Atendente()
        {
            InitializeComponent();
            CarregarPedidosPendentes();
        }

        private string connectionString = "Data Source=C:\\Users\\gabri\\source\\repos\\Projeto_Cafeteria\\Cafeteria_Carol\\Banco\\bd_cafeteria.db";

        private void CarregarPedidosPendentes()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PedidoID, ClienteID, ItemID, Quantidade, HoraPedido FROM Pedidos WHERE Status = 'Pendente'";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable pedidosTable = new DataTable();
                    adapter.Fill(pedidosTable);

                    dataGridViewPedidos.Rows.Clear();

                    foreach (DataRow row in pedidosTable.Rows)
                    {
                        int pedidoID = Convert.ToInt32(row["PedidoID"]);
                        int clienteID = Convert.ToInt32(row["ClienteID"]);
                        int itemID = Convert.ToInt32(row["ItemID"]);
                        int quantidade = Convert.ToInt32(row["Quantidade"]);
                        DateTime horaPedido = Convert.ToDateTime(row["HoraPedido"]);

                        dataGridViewPedidos.Rows.Add(pedidoID, clienteID, itemID, quantidade, horaPedido);
                    }
                }
            }
        }

        private void dataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewPedidos.Rows[e.RowIndex];
                int pedidoID = Convert.ToInt32(selectedRow.Cells["PedidoID"].Value);

                MarcarPedidoComoConcluido(pedidoID);

                CarregarPedidosPendentes();
            }
        }

        private void MarcarPedidoComoConcluido(int pedidoID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
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
        private void btnPedidoAtendido_Click(object sender, EventArgs e)
        {

            if (dataGridViewPedidos.SelectedRows.Count > 0)
            {
                int pedidoID = (int)dataGridViewPedidos.SelectedRows[0].Cells["PedidoID"].Value;
                MarcarPedidoComoConcluido(pedidoID);
                CarregarPedidosPendentes();
            }
        }
    }
}
