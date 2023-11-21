using System;
using System.Windows.Forms;
using System.Linq;


namespace Cafeteria_Carol
{
    public partial class Tela_Comandas : Form
    {
        public Sacola Sacola { get; set; }

        private double ConsultarValorAPagar()
        {
            double total = 0;

            foreach (var item in Sacola.Itens)
            {
                total += item.Subtotal;
            }

            return total;
        }
        public Tela_Comandas()
        {
            InitializeComponent();
        }

        private void Tela_Comandas_Load(object sender, EventArgs e)
        {
            dataGridViewComandas.Columns.Add("Nome", "Nome");
            dataGridViewComandas.Columns.Add("Descricao", "Descrição");
            dataGridViewComandas.Columns.Add("Preco", "Preço");
            dataGridViewComandas.Columns.Add("Quantidade", "Quantidade");

            dataGridViewComandas.Columns["Nome"].Width = 150;
            dataGridViewComandas.Columns["Descricao"].Width = 200;
            dataGridViewComandas.Columns["Preco"].Width = 80;
            dataGridViewComandas.Columns["Quantidade"].Width = 80;

            if (Sacola != null)
            {
                foreach (var item in Sacola.Itens)
                {
                    dataGridViewComandas.Rows.Add(item.Nome, item.Quantidade, item.Preco, item.Subtotal);
                }

                double total = Sacola.Itens.Sum(item => item.Subtotal);

                lblTotal.Text = $"Total: R$ {total.ToString("F2")}";
            }
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            double valorAPagar = ConsultarValorAPagar();

            MessageBox.Show($"Total a pagar: R$ {valorAPagar.ToString("F2")}", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridViewComandas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
