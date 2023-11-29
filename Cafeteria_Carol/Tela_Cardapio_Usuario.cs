using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Cafeteria_Carol
{
    public partial class Tela_Cardapio_Usuario : Form
    {
        private string connectionString = ConfiguracaoBanco.CaminhoBanco; 
        private Sacola sacola = new Sacola();
        string nomeDoUsuario = Tela_Login.NomeUsuarioLogado;
        string nomeUsuario = Tela_Cadastro.NomeUsuarioCadastrado;



        public Tela_Cardapio_Usuario()
        {
            InitializeComponent();
            this.nomeUsuario = nomeUsuario;
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

                    if (dataGridViewMenu1.Columns.Count == 0)
                    {
                        dataGridViewMenu1.Columns.Add("ID", "ID");
                        dataGridViewMenu1.Columns.Add("Nome", "Nome");
                        dataGridViewMenu1.Columns.Add("Descricao", "Descrição");
                        dataGridViewMenu1.Columns.Add("Preco", "Preço");
                        dataGridViewMenu1.Columns.Add(new DataGridViewButtonColumn() { Name = "Adicionar", Text = "Adicionar ao Carrinho", UseColumnTextForButtonValue = true });
                    }

                    foreach (DataRow row in cardapioTable.Rows)
                    {
                        int id = Convert.ToInt32(row["ID"]);
                        string nome = row["Nome"].ToString();
                        string descricao = row["Descricao"].ToString();
                        double preco = Convert.ToDouble(row["Preco"]);

                        dataGridViewMenu1.Rows.Add(id, nome, descricao, preco);
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
            MessageBox.Show($"Item '{nome}' adicionado à sacola!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        private void AtualizarTotal()
        {
            double total = 0;

            foreach (var itemNaSacola in sacola.Itens)
            {
                total += itemNaSacola.Preco * itemNaSacola.Quantidade;
            }

            lblTotal.Text = $"Total: R$ {total.ToString("F2")}";
        }

            private void dataGridViewMenu1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMenu1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.ColumnIndex == dataGridViewMenu1.Columns["Adicionar"].Index && e.RowIndex >= 0)
            {
                btnAdicionarSacola_Click(sender, e);
            }
        }
    

        private void Tela_Cardapio_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            List<ItemSacola> itensCarrinho = sacola.Itens;
            MessageBox.Show($"Nome do usuário ao clicar no botão 'Comanda': {nomeUsuario}");


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in itensCarrinho)
                        {
                            string insertQuery = "INSERT INTO Pedidos (NomeCliente, NomeProduto, Quantidade, HoraPedido, Status) " +
                                 "VALUES (@NomeCliente, @NomeProduto, @Quantidade, @HoraPedido, @Status)";

                            using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@NomeCliente", nomeDoUsuario);
                                command.Parameters.AddWithValue("@NomeProduto", item.Nome);
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

        private void btnAdicionarSacola_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewMenu1.CurrentCell.RowIndex;

            int id = Convert.ToInt32(dataGridViewMenu1.Rows[rowIndex].Cells[0].Value);
            string nome = dataGridViewMenu1.Rows[rowIndex].Cells[1].Value.ToString();
            string descricao = dataGridViewMenu1.Rows[rowIndex].Cells[2].Value.ToString();
            double preco = Convert.ToDouble(dataGridViewMenu1.Rows[rowIndex].Cells[3].Value);

            ItemSacola item = new ItemSacola(id, nome, descricao, preco);

            AdicionarAoCarrinhoClick(item);
        }
        private void AdicionarAoCarrinhoClick(ItemSacola item)
        {
            sacola.AdicionarItem(item);
            AtualizarTotal();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarAoCarrinho_Click(object sender, EventArgs e)
        {

        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            dataGridViewMenu1.Refresh();
        }
    }
    }



