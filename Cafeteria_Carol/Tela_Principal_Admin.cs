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
    public partial class Tela_Principal_Admin : Form
    {
        public Tela_Principal_Admin()
        {
            InitializeComponent();
        }

        private void bt_Gerenciar_Produtos_Click(object sender, EventArgs e)
        {
            Tela_Gerenciar_Produtos novo = new Tela_Gerenciar_Produtos();
            novo.Show();

        }
    }
}
