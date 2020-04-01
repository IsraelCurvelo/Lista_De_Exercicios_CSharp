using System;
using System.Globalization;
using System.Text;

namespace ExerciciosCSharp
{
    class Funcionario
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += (Salario * porcentagem) / 100;
        }

        public override string ToString()
        {
            return ID + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
