using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Cafeteria_Carol
{
    public partial class Tela_Menu_Atendente : Form
    {
        public Tela_Menu_Atendente()
        {
            InitializeComponent();
        }

        private void CarregarItensCardapio()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfiguracaoBanco.CaminhoBanco))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, Nome, Descricao, Preco, Imagem FROM Cardapio";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable cardapioTable = new DataTable();
                        adapter.Fill(cardapioTable);

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();

                        if (dataGridView1.Columns.Count == 0)
                        {
                            dataGridView1.Columns.Add("ID", "ID");
                            dataGridView1.Columns.Add("Nome", "Nome");
                            dataGridView1.Columns.Add("Descricao", "Descrição");
                            dataGridView1.Columns.Add("Preco", "Preço");
                        }

                        foreach (DataRow row in cardapioTable.Rows)
                        {
                            int id = Convert.ToInt32(row["ID"]);
                            string nome = row["Nome"].ToString();
                            string descricao = row["Descricao"].ToString();
                            double preco = Convert.ToDouble(row["Preco"]);

                            dataGridView1.Rows.Add(id, nome, descricao, preco);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar itens do cardápio: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void Tela_Menu_Atendente_Load(object sender, EventArgs e)
        {
            CarregarItensCardapio();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
