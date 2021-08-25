using System;

namespace AulaExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Insira o Y da matriz: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o X da matriz: ");
            int x = int.Parse(Console.ReadLine());
            int[,] matriz = new int[y, x];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matriz[i, j] = r.Next(1, 50);
                }
            }

            Console.WriteLine("preenchendo com numeros aleatorios.....");
            Console.WriteLine("mostrando a array.....");
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("==========================");
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write("{0} ", matriz[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("==========================");
                Console.WriteLine("qual X deseja consultar?");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("qual Y deseja consultar?");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero escolhido: " + matriz[y, x]);
                if (++y < matriz.GetLength(1))
                {
                    Console.WriteLine("DOWN: " + matriz[y, x]);
                }
                if (--y > 0)
                {
                    Console.WriteLine("UP: " + matriz[--y, x]);
                    ++y;
                }
                if (++x < matriz.GetLength(0))
                {
                    Console.WriteLine("RIGHT: " + matriz[y, x]);
                }
                if (--x > 0)
                {

                    Console.WriteLine("LEFT: " + matriz[y, --x]);
                }
            }



        }
    }
}
