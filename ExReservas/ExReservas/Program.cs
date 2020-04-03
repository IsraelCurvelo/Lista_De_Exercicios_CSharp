using ExReservas.Entidades;
using ExReservas.Entidades.Exceptions;
using System;

namespace ExReservas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Numero do Quarto: ");
                int numeroQ = int.Parse(Console.ReadLine());
                Console.Write("Data de Check-In (DD/MM/AAAA): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-Out (DD/MM/AAAA): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservas novo = new Reservas(numeroQ, checkIn, checkOut);
                novo.AtualizarDatas(checkIn, checkOut);
                Console.WriteLine("Reserva: " + novo);

            }
            catch (PersonalizadoException e)
            {
                Console.WriteLine("Erro de reserva!: "+ e.Message);
            }

            catch (FormatException e)
            {
                Console.WriteLine("Erro de formato: "+e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine( "Erro Insesperado "+e.Message);
            }
        }
    }
}
