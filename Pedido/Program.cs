using Pedido.Entidades;
using Pedido.Entidades.Enums;
using System;
using System.Globalization;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.WriteLine();
            Console.Write("Nome: ");
            string snome = Console.ReadLine();
            Console.Write("Email: ");
            string semail = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            DateTime sdata = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Entre com os dados do pedido");
            Console.Write("Status - (AguardandoPagamento / Processando / Enviado / Entregue): ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());
            Console.WriteLine();
            Cliente cliente = new Cliente(snome, semail, sdata);
            Pedidos order = new Pedidos(DateTime.Now, status, cliente);

            Console.Write("Quantos itens tem nessa ordem?");
            int itenPedido = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i =1; i<= itenPedido; i++)
            {
                Console.WriteLine("Entre com os dados do pedido #"+i);
                Console.Write("Nome do produto: ");
                string nomeP = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoP = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int qtde = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeP, precoP);
                ItemPedido ordem = new ItemPedido(qtde, precoP, produto);

                order.AddItem(ordem);
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("DADOS GERAL");
            Console.WriteLine(order);

        }
    }
}
