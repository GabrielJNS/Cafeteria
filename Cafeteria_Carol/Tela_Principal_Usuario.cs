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

    public partial class Tela_Principal_Usuario : Form
    {
        string nomeUsuario = Tela_Cadastro.NomeUsuarioCadastrado;

        private List<Pedido> ListaDePedidos = new List<Pedido>(); 


        public Tela_Principal_Usuario(string nomeUsuario)
        {
            InitializeComponent();

            lb_User.Text = "Bem-vindo, " + nomeUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cardápio_Click(object sender, EventArgs e)
        {
            Tela_Cardapio_Usuario novo = new Tela_Cardapio_Usuario();
            novo.Show();
        }

        private void bt_Comanda_Click(object sender, EventArgs e)
        {
            Tela_Comandas novo = new Tela_Comandas();
            novo.Show();
        }

        private void bt_ResumoPedido_Click(object sender, EventArgs e)
        {
            Tela_Resumo_Pedido novo = new Tela_Resumo_Pedido(ListaDePedidos);
            novo.Show();
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lb_User_Click(object sender, EventArgs e)
        {

        }
        private void Tela_Principal_Usuario_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
