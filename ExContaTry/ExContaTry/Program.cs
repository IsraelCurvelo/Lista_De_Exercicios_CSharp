using ExContaTry.Entidades;
using ExContaTry.Entidades.Exceptions;
using System;
using System.Globalization;

namespace ExContaTry
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta: ");
                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Saldo Inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de Saque: ");
                double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta nova = new Conta(numero, titular, saldo, limite);

                Console.Write("Qual valor a sacar? ");
                double valorSacar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                nova.Saque(valorSacar);
            }

            catch (SemSaldoException e)
            {
                Console.WriteLine("Erro! "+ e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("Erro! " +e.Message);
            }



        }
    }
}
