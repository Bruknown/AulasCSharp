using System;

namespace AulaExercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar?");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dolares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine());

            double res = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("O quanto você terá de pagar em reais: " + res.ToString());
        }
    }
}
