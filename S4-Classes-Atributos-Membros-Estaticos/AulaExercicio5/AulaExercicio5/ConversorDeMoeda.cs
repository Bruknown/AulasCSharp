using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExercicio5
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + (total * IOF / 100.0);
        }
    }
}
