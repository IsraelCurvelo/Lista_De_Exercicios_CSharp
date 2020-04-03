using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExContaTry.Entidades
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta(int numero, string titular, double saldo, double limiteEmprestimo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteEmprestimo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Saque (double valor)
        {          

            if (valor > LimiteSaque)
            {
                throw new Exception("Limite de saque excedido");
            }

            if (Saldo < valor)
            {
                throw new Exception("Saldo Insuficiente");
            }

            Saldo -= valor;

            Console.WriteLine("Novo Saldo: "+Saldo.ToString("F2",CultureInfo.InvariantCulture));
        }

        
    }
}
