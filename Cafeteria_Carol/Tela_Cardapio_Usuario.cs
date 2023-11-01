using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Cafeteria_Carol
{
    public partial class Tela_Cardapio_Usuario : Form
    {
        public Tela_Cardapio_Usuario()
        {
            InitializeComponent();
            CarregarItensCardapio();
        }
        private Sacola sacola = new Sacola();

        private void CarregarItensCardapio()
        {
            string connectionString = "Data Source=C:\\Users\\gabri\\source\\repos\\Projeto_Cafeteria\\Cafeteria_Carol\\Banco\\bd_cafeteria.db";

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
                        byte[] imagemBytes = (byte[])row["Imagem"];
                        Image imagem = ByteArrayToImage(imagemBytes);

                        dataGridViewMenu1.Rows.Add(id, nome, descricao, preco, imagem);
                    }
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void btnAdicionarSacola_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMenu1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                string descricao = selectedRow.Cells["Descricao"].Value.ToString();
                double preco = Convert.ToDouble(selectedRow.Cells["Preco"].Value);

                ItemSacola item = new ItemSacola(id, nome, descricao, preco);

                bool itemExistente = false;

                foreach (var itemNaSacola in sacola.Itens)
                {
                    if (itemNaSacola.Id == item.Id)
                    {
                        itemNaSacola.Quantidade++;
                        itemExistente = true;
                        break;
                    }
                }

                if (!itemExistente)
                {
                    sacola.AdicionarItem(item);
                }

                double total = 0;

                foreach (var itemNaSacola in sacola.Itens)
                {
                    total += itemNaSacola.Preco * itemNaSacola.Quantidade;
                }

                lblTotal.Text = $"Total: R$ {total.ToString("F2")}";
            }
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            
            Tela_Comandas telaComanda = new Tela_Comandas();

            telaComanda.Sacola = sacola;

            telaComanda.ShowDialog();
        }
    }
    }
