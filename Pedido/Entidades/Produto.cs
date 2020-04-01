using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entidades
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string name, double price)
        {
            Nome = name;
            Preco = price;
        }
    }




}
