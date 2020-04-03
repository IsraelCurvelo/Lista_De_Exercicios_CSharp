using ExReservas.Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExReservas.Entidades
{
    class Reservas
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservas(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new PersonalizadoException("Data de check-out tem q ser maior que o check-in");
            }
            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;

        }

        public void AtualizarDatas(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin <now || checkout < now)
            {
                throw new PersonalizadoException("Data de reserva tem q ser maior que a data atual");
            }
            if (checkout<= checkin)
            {
                throw new PersonalizadoException("Data de check-out tem q ser maior que o check-in");
            }
            CheckIn = checkin;
            CheckOut = checkout;

        }

        public override string ToString()
        {
            return "Quarto "
                + NumeroQuarto
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duracao()
                + "Noite(s)";
        }
    }
}
