using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExercicio1
{
    struct Funcionario
    {
        public double Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public void aumentarSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }

        public void definirSalario(double salario)
        {
            Salario = salario;
        }

        public void definirId(double id)
        {
            Id = id;
        }

        public bool encontrarId(Funcionario[] func, double id)
        {
            for (int i = 0; i < func.Length; i++)
            {
                if (func[i].Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Funcionario: "
            + Id
            + ", Nome: "
            + Nome
            + ", Salario: "
            + Salario;
        }
    }
}
