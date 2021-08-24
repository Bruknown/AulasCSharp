using System;
using System.Globalization;

namespace AulaExercicio1
{
    class Program
    {

        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre as medidas do triangulo X aqui:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre as medidas do triangulo Y aqui:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalculoArea();

            double areaY = y.CalculoArea();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area é do triangulo X");
            }
            else
            {
                Console.WriteLine("Maior area é do triangulo Y");
            }
        }
    }
}




//***********************************************************************************************************
//sem orientação a objeto
//***********************************************************************************************************
/*
static void Main(string[] args)
{
    double xA, xB, xC, yA, yB, yC;

    Console.WriteLine("Entre as medidas do triangulo X aqui:");
    xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Entre as medidas do triangulo Y aqui:");
    yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double p = (xA + xB + xC) / 2;
    double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

    p = (yA + yB + yC) / 2;
    double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

    Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
    Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

    if (areaX > areaY)
    {
        Console.WriteLine("Maior area é do triangulo X");
    }
    else
    {
        Console.WriteLine("Maior area é do triangulo Y");
    }
}
*/