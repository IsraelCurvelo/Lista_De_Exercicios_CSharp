using System;
using System.Collections.Generic;
using System.Text;

namespace ExContaTry.Entidades.Exceptions
{
    class SemSaldoException : Exception
    {
        public SemSaldoException(string message) : base(message)
        {

        }
    }
}
