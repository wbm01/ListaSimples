using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimples
{
    internal class Item
    {
        public int Valor { get; set; }
        public Item Proximo{ get; set; }

        public Item(int x) {

            Valor = x;
            Proximo = null;
        }
    }
}
