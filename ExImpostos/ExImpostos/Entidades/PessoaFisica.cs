using System;
using System.Collections.Generic;
using System.Text;

namespace ExImpostos.Entidades
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double ganhoAnual,double gastoSaude) : base(nome, ganhoAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalculoImposto()
        {
            double total=0;
            if (GanhoAnual < 20000.00)
            {
                total = (GanhoAnual * 0.15) - (GastoSaude * 0.50);
            }
            else
            {
                total = (GanhoAnual * 0.25) - (GastoSaude * 0.50);
            }
            return total;
        }
    }
}
