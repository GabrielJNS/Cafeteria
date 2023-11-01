using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria_Carol
{
    public class Sacola
    {
        public List<ItemSacola> Itens { get; set; }

        public Sacola()
        {
            Itens = new List<ItemSacola>();
        }

        public void AdicionarItem(ItemSacola item)
        {
            Itens.Add(item);
        }

        public double CalcularTotal()
        {
            double total = 0;

            foreach (var item in Itens)
            {
                total += item.Preco * item.Quantidade;
            }

            return total;
        }
    }
}