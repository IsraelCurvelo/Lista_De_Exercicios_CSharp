using System;
using System.Collections.Generic;
using System.Text;

namespace ExFuncionarioTercerizado.Entidades
{
    class FuncTercerizado : Funcionario
    {
        public double DespesaAdd { get; set; }

        public FuncTercerizado()
        {
        }

        public FuncTercerizado(string nome, int horas, double valorHora, double despesaAdd) : base(nome, horas, valorHora)
        {
            DespesaAdd = despesaAdd;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdd;
        }
    }
}
