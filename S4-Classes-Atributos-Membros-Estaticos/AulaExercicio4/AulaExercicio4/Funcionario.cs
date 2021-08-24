using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AulaExercicio4
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += ((double)SalarioBruto / 100) * porcentagem;
        }

        public override string ToString()
        {
            return Nome
                + ", Salario: "
                + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Imposto
                + " de imposto, salario total: $"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
