using Pedido.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Pedido.Entidades
{
    class Pedidos
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public List<ItemPedido> ListaItens { get; set; } = new List<ItemPedido>();
        public Cliente cliente { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(DateTime momento, StatusPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            this.cliente = cliente;
        }

        public void AddItem(ItemPedido item)
        {
            ListaItens.Add(item);
        }

        public void RemoveItem(ItemPedido item)
        {
            ListaItens.Remove(item);
        }

        public double Total()
        {
            double soma =0.0;
            foreach(ItemPedido novo in ListaItens)
            {
             
               soma += novo.SubTotal();
               
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Data do pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + cliente);
            sb.AppendLine("Itens do pedido:");

            foreach(ItemPedido novo in ListaItens)
            {
                sb.AppendLine(novo.ToString());
            }

            sb.AppendLine("Valor Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
