using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Pedido.Entidades
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto produto { get; set; }

        public ItemPedido()
        {
        }

        public ItemPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            this.produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return produto.Nome
                + ", R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Subtotal: R$"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
