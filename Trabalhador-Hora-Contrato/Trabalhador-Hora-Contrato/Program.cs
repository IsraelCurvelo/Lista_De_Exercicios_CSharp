using System;
using Trabalhador_Hora_Contrato.Entidades.Enums;
using Trabalhador_Hora_Contrato.Entidades;
using System.Globalization;

namespace Trabalhador_Hora_Contrato
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Dados do Funcionário");

            Console.WriteLine("Nome: ");
            string nomeFun = Console.ReadLine();

            Console.WriteLine("Nível:\nJunior, Pleno ou Senior ?");
            Nivel nivel1 = Enum.Parse<Nivel>(Console.ReadLine());

            Console.WriteLine("Qual o salario?");
            double salarioFun = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual o departamento do funcionário ? ");
            string nomeDpt = Console.ReadLine();

            Departamento nome = new Departamento(nomeDpt);
            Funcionario novo = new Funcionario(nomeFun, salarioFun, nome, nivel1);


            Console.WriteLine("Quantos contratos serão acrescentado a esse funcionario?");
            int numContratos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numContratos; i++)
            {
                Console.WriteLine("Contrato " + i + ":");
                Console.WriteLine("Data do contrato: (DD/MM/AAAA)");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Valor por hora:");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Duração em horas: ");
                double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Contratos novoContrato = new Contratos(data, valorHora, horas);
                novo.AdicionarContrato(novoContrato);

                Console.WriteLine();
            }

            Console.WriteLine("Entre com o mês e ano para calcular a renda total do funcionario: (MM/AAAA)");
            string mesAno = Console.ReadLine();

            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3, 4));

            Console.WriteLine("RESULTADO DA BUSCA");
            Console.WriteLine("Nome: " + novo.Nome);
            Console.WriteLine("Departamento: " + novo.Setor.Nome);
            Console.WriteLine("Ganhos no mês:" + mesAno + " : " + novo.ValorRecebidoMes(ano, mes).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
