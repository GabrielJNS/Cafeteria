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
    public partial class Tela_Resumo_Pedido : Form
    {
        private List<Pedido> pedidos; 

        public Tela_Resumo_Pedido(List<Pedido> pedidos)
        {
            InitializeComponent();
            this.pedidos = pedidos;
        }

        private void Tela_Resumo_Pedido_Load(object sender, EventArgs e)
        {
            foreach (var pedido in pedidos)
            {
                string resumo = $"Compra de {string.Join(", ", pedido.Itens.Select(item => $"{item.Quantidade} {item.Nome}"))}, Dia {pedido.HoraPedido.ToString("dd/MM/yyyy")} às {pedido.HoraPedido.ToString("hh:mm")}";
                listBoxResumo.Items.Add(resumo);
            }
        }

        private void listBoxResumo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
