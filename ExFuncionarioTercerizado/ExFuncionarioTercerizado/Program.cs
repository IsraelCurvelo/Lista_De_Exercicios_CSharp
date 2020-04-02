using ExFuncionarioTercerizado.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExFuncionarioTercerizado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de funcionarios");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do #{i} funcionario");
                Console.Write("Tercerizado? : ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int hora = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor por hora: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'y')
                {
                    Console.Write("Despesa Adicional: ");
                    double aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new FuncTercerizado(nome, hora, valor, aux));
                }
                else
                {
                    lista.Add(new Funcionario(nome, hora, valor));
                }

            }
            Console.WriteLine();

            Console.WriteLine("PAGAMENTO");

            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj.Nome + " - $" + obj.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
