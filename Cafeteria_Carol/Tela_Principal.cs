using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria_Carol
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cardápio_Click(object sender, EventArgs e)
        {
            Tela_Cardapio novo = new Tela_Cardapio();
            novo.Show();
        }

        private void bt_Comanda_Click(object sender, EventArgs e)
        {
            Tela_Comandas novo = new Tela_Comandas();
            novo.Show();
        }

        private void bt_ResumoPedido_Click(object sender, EventArgs e)
        {
            Tela_Resumo_Pedido novo = new Tela_Resumo_Pedido();
            novo.Show();
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
