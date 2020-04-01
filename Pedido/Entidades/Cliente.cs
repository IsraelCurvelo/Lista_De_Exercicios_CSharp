using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {
        }

        public Cliente(string name, string email, DateTime data)
        {
            Nome = name;
            Email = email;
            DataNascimento = data;
        }

        public override string ToString()
        {

            return Nome + ", ("
                + DataNascimento.ToString("dd/MM/yyyy")
                + "), " + Email;
        }
    }
}
