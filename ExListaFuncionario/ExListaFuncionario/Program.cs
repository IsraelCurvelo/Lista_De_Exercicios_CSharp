using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario novo;
            List<Funcionario> lista = new List<Funcionario>();
            Console.WriteLine("Quantos funcionarios serão cadastrados?");
            int qtde = int.Parse( Console.ReadLine());
            for (int i = 1; i <= qtde; i++)
            {    
                int id = i;
                Console.WriteLine("Funcionario "+ i);
                Console.WriteLine("Digite o Nome do Funcionário");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o Salario do Funcionário");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine("Digite o Nome do Funcionario ao qual quer aumentar o salario");
            string pesquisa = Console.ReadLine();
            
            Funcionario filtrado = lista.Find(x => x.Nome == pesquisa);
            if (filtrado != null)
            {
                Console.WriteLine("Digite a porcentagem de aumento de salário");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                filtrado.AumentarSalario(porcentagem);

            }
            else
            {
                Console.WriteLine("Funcionário não encontrado");
            }

            Console.WriteLine();
            Console.WriteLine("Atualização da lista de funcionários");
            foreach (Funcionario ex in lista)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
