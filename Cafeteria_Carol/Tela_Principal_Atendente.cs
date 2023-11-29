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
    public partial class Tela_Principal_Atendente : Form
    {

        string nomeUsuario = Tela_Cadastro.NomeUsuarioCadastrado;

        public Tela_Principal_Atendente(string nomeUsuario)
        {
            InitializeComponent();
        lb_User.Text = "Bem-vindo, " + nomeUsuario;
            }
        public Tela_Principal_Atendente()
        {
            InitializeComponent();
        }

        private void Tela_Principal_Atendente_Load(object sender, EventArgs e)
        {

        }

        private void bt_Comanda_Click(object sender, EventArgs e)
        {

        }

        private void bt_Pedidos_Click(object sender, EventArgs e)
        {
            Tela_Pedido_Atendente novo = new Tela_Pedido_Atendente();
            novo.Show();
        }

        private void lb_User_Click(object sender, EventArgs e)
        {

        }
        private void Tela_Principal_Usuario_Load(object sender, EventArgs e)
        {
        }

        private void bt_User_Atendente_Click(object sender, EventArgs e)
        {

        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            Tela_Menu_Atendente novo = new Tela_Menu_Atendente();
            novo.Show();
        }
    }
}
