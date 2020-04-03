using System;
using System.Collections.Generic;
using System.Text;

namespace ExReservas.Entidades.Exceptions
{
    class PersonalizadoException : Exception
    {
        public PersonalizadoException(string message) : base(message)
        {

        }
    }
}
