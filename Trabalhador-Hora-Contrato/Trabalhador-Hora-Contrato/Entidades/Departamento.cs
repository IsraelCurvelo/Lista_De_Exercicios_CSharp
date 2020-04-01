using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalhador_Hora_Contrato.Entidades
{
    public class Departamento
    {
        public string Nome { get; set; }

        public Departamento()
        {
        }

        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}
