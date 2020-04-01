using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalhador_Hora_Contrato.Entidades
{
    public class Contratos
    {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public double Horas { get; set; }

        public Contratos()
        {
        }

        public Contratos(DateTime data, double valorHora, double horas)
        {
            Data = data;
            ValorHora = valorHora;
            Horas = horas;
        }

        public double ValorTotalContrato()
        {
            return ValorHora * Horas;
        }
    }
}
