using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExImpostos.Entidades
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double GanhoAnual { get; set; }

        protected Pessoa(string nome, double ganhoAnual)
        {
            Nome = nome;
            GanhoAnual = ganhoAnual;
        }

        public abstract double CalculoImposto();

        public override string ToString()
        {
            return Nome + ": $" + CalculoImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
