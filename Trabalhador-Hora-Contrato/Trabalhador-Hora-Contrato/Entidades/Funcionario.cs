using System;
using System.Collections.Generic;
using System.Text;
using Trabalhador_Hora_Contrato.Entidades.Enums;

namespace Trabalhador_Hora_Contrato.Entidades
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Departamento Setor { get; set; }
        public List<Contratos> ListaContratos { get; set; } = new List<Contratos>();
        public Nivel Level { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, double salario, Departamento setor, Nivel level)
        {
            Nome = nome;
            Salario = salario;
            Setor = setor;
            Level = level;
        }

        public void AdicionarContrato(Contratos contrato)
        {
            ListaContratos.Add(contrato);

        }

        public void RemoverContrato(Contratos contrato)
        {
            ListaContratos.Remove(contrato);

        }

        public double ValorRecebidoMes(int ano, int mes)
        {
            double soma = Salario;
            foreach (Contratos contratos in ListaContratos)
            {
                if (contratos.Data.Year == ano && contratos.Data.Month == mes)
                {
                    soma += contratos.ValorTotalContrato();
                                   }
                }
            return soma;
        }

    }
}
