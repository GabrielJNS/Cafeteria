using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria_Carol
{
    public class Sacola
    {
        public List<ItemSacola> Itens { get; }

        public Sacola()
        {
            Itens = new List<ItemSacola>();
        }

        public void AdicionarItem(ItemSacola item)
        {
            var itemExistente = Itens.FirstOrDefault(i => i.ID == item.ID);

            if (itemExistente != null)
            {
                itemExistente.Quantidade++;
            }
            else
            {
                Itens.Add(item);
            }
        }

        public void Limpar()
        {
            Itens.Clear();
        }
    }
}