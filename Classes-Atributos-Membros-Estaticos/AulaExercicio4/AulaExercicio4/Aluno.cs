using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExercicio4
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double CalcularNota(double x, double y, double z)
        {
            return x + y + z;
        }

        public string Aprovar(double notaFinal)
        {
            if (notaFinal >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO " + Environment.NewLine + "Faltam: " + (60 - notaFinal) + " pontos";
            }
        }
    }
}
