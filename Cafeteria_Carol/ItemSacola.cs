using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria_Carol
{
    public class ItemSacola
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
   

        public ItemSacola(int id, string nome, string descricao, double preco)
        {
            ID = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Quantidade = 1;
        }
    }
}