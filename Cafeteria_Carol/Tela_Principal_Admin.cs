using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Cafeteria_Carol
{
    public partial class Tela_Principal_Admin : Form
    {

        string nomeUsuario = Tela_Cadastro.NomeUsuarioCadastrado;

        public Tela_Principal_Admin(string nomeUsuario)
        {
            InitializeComponent();

            
            lb_User.Text = "Bem-vindo, " + nomeUsuario;
        }


        private void bt_Gerenciar_Produtos_Click(object sender, EventArgs e)
        {
            Tela_Gerenciar_Produtos novo = new Tela_Gerenciar_Produtos();
            novo.Show();

        }

        private void lb_User_Click(object sender, EventArgs e)
        {


        }

        private void Tela_Principal_Admin_Load(object sender, EventArgs e)
        {

          
        }

        private void bt_Cadastro_Click(object sender, EventArgs e)
        {
            Tela_Add_E_Modificar_Cadastro_Admin novo = new Tela_Add_E_Modificar_Cadastro_Admin();
            novo.Show();
        }
        private void Tela_Principal_Usuario_Load(object sender, EventArgs e)
        {
        }

        private void bt_Gerenciar_Click(object sender, EventArgs e)
        {

        }

        private void bt_Gerenciar_Vendas_Click(object sender, EventArgs e)
        {

        }

        private void bt_Estoque_Click(object sender, EventArgs e)
        {

        }
    }
}

