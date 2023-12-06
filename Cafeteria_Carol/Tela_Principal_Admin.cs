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
using System.Drawing.Drawing2D;


namespace Cafeteria_Carol
{
    public partial class Tela_Principal_Admin : Form
    {

        string nomeUsuario = Tela_Cadastro.NomeUsuarioCadastrado;

        public Tela_Principal_Admin(string nomeUsuario)
        {
            InitializeComponent();

            
            lb_User.Text = "Bem-vindo, " + nomeUsuario;
            InicializarBordasArredondadas();


        }

        public void InicializarBordasArredondadas()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 30;
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Top, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

