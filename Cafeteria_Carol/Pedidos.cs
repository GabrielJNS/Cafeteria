using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cafeteria_Carol
{
    public class ItemPedido
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }

        public double Subtotal
        {
            get { return Quantidade * PrecoUnitario; }
        }
    }


    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public DateTime HoraPedido { get; set; }
        public string Cliente { get; set; }
        public string Status { get; set; }
    }

}