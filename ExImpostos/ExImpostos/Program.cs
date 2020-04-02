using ExImpostos.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Console.Write("Quantas pessoas serão cadastradas? :");
            int qtde = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtde; i++)
            {
                Console.WriteLine($"Entre com os dados da {i} pessoa");
                Console.Write("Pessoa Física ou Jurídica? (f/j)");
                char tipo = char.Parse(Console.ReadLine());

                if (tipo == 'f')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Ganho Anual: ");
                    double ganhoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Despesas com saúde: ");
                    double despesas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new PessoaFisica(nome, ganhoAnual, despesas));
                }
                else if (tipo == 'j')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Ganho Anual: ");
                    double ganhoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Número de funcionários: ");
                    int numeroF = int.Parse(Console.ReadLine());

                    lista.Add(new PessoaJuridica(nome, ganhoAnual, numeroF));
                }
            }

            Console.WriteLine();
            Console.WriteLine("VALOR DOS IMPOSTOS");
            double soma = 0;
            foreach (Pessoa nova in lista)
            {
                Console.WriteLine(nova);
                
                soma += nova.CalculoImposto();
            }

            Console.WriteLine();
            Console.WriteLine("VALOR TOTAL DE IMPOSTOS: $"+soma.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
