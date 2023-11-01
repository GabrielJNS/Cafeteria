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
    public partial class Tela_Comandas : Form
    {
        public Sacola Sacola { get; set; }
        public Tela_Comandas()
        {
            InitializeComponent();
        }

        private void TelaComanda_Load(object sender, EventArgs e)
        {
            if (Sacola != null)
            {
                foreach (var item in Sacola.Itens)
                {
                }
            }
        }
    }
}