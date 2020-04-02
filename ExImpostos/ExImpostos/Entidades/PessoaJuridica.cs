using System;
using System.Collections.Generic;
using System.Text;

namespace ExImpostos.Entidades
{
    class PessoaJuridica : Pessoa
    {
        public int NumFuncionarios { get; set; }

        public PessoaJuridica(string nome,double ganhoAnual,int numFuncionarios) : base (nome, ganhoAnual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double CalculoImposto()
        {
            double total = 0;
            if (NumFuncionarios > 10)
            {
                total = (GanhoAnual * 0.14);

            }
            else
            {
                total = (GanhoAnual * 0.16);
            }

            return total;
        }
    }
}
