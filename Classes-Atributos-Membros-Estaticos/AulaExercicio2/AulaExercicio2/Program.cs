using System;

namespace AulaExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");

            Console.WriteLine("Nome: ");
            x.nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            x.idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("Salário: ");
            x.salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");

            Console.WriteLine("Nome: ");
            y.nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            y.idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("Salário: ");
            y.salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Pessoa mais velha: " + calculoIdade(x, y));
            Console.WriteLine("Salário Medio: " + calculoSalario(x, y));
        }
        private static string calculoIdade(Pessoa x, Pessoa y)
        {
            if (x.idade > y.idade)
            {
                return x.nome;
            }
            else
            {
                return y.nome;
            }
        }

        private static float calculoSalario(Pessoa x, Pessoa y)
        {
            return (x.salario + y.salario) / 2;
        }
    }

}
