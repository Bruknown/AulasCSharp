using System;

namespace AulaExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco conta;

            Console.WriteLine("Entre o numero da conta: ");
            int ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicial? (s/n) ");
            string deposito = Console.ReadLine();
            if (deposito.Equals("s"))
            {
                Console.WriteLine("Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());

                conta = new ContaBanco(ID, nome, depositoInicial);
                Console.WriteLine("Dados da conta: " + conta);
            }
            else
            {
                conta = new ContaBanco(ID, nome);
                Console.WriteLine("Dados da conta: " + conta);
            }


            Console.WriteLine("Entre um valor para deposito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta: " + conta);

            Console.WriteLine("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta: " + conta);

        }
    }
}
