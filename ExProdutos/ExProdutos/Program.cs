using ExProdutos.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            Console.Write("Entre com a quantidade de produtos: ");
            int qtde = int.Parse(Console.ReadLine());

            for(int i = 1; i<= qtde; i++)
            {
                Console.Write("Comum, Usado ou Importado? (c/u/i): ");
                char tipo = char.Parse(Console.ReadLine());

                if(tipo == 'c')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new Produto(nome, preco));
                }
                else if (tipo == 'u')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Data de fabricação (DD/MM/AAAA): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, data));
                }
                else if (tipo == 'i')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Taxa Alfandega: ");
                    double taxa = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome, preco, taxa));
                }
                else
                {
                    Console.WriteLine("Caractere Inválido!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL");
            foreach(Produto novo in lista)
            {
                Console.WriteLine(novo.EtiquetaPreco());
            }
        }
    }
}
