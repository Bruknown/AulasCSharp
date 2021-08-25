using System;

namespace AulaExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira quantos funcionários existem: ");
            Funcionario[] func = new Funcionario[int.Parse(Console.ReadLine())];

            for (int i = 0; i < func.Length; i++)
            {
                Console.WriteLine("Insira o ID do funcionário " + (i + 1) + ": ");
                double id = double.Parse(Console.ReadLine());
                while (func[i].encontrarId(func, id))
                {
                    Console.WriteLine("Insira um ID valido para o funcionário " + (i + 1) + ": ");
                    id = double.Parse(Console.ReadLine());
                }
                func[i].definirId(id);
                Console.WriteLine("Insira o nome do funcionário " + (i + 1) + ": ");
                func[i].Nome = Console.ReadLine();

                Console.WriteLine("Insira o salario do funcionário " + (i + 1) + ": ");
                func[i].definirSalario(double.Parse(Console.ReadLine()));
                Console.WriteLine("Funcionário " + (i + 1) + " concluido, carregando proximo... ");
            }
            bool isRunning = true;
            while (isRunning)
            {
                for (int i = 0; i < func.Length; i++)
                {
                    Console.WriteLine(func[i]);
                }
                Console.WriteLine("======================");
                Console.WriteLine("Options: ");
                Console.WriteLine("======================");
                Console.WriteLine("Aumentar Salario [1]: ");
                Console.WriteLine("Sair: [2] ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Qual Id do funcionario?: ");
                        double id = double.Parse(Console.ReadLine());
                        while (!func[0].encontrarId(func, id))
                        {
                            Console.WriteLine("Insira um ID valido: ");
                            id = double.Parse(Console.ReadLine());
                        }
                        for (int i = 0; i < func.Length; i++)
                        {
                            if (func[i].Id == id)
                            {
                                Console.WriteLine(func[i].Nome + " Selecionado");
                                Console.WriteLine("Quanto deseja aumentar em porcentagem?: ");
                                func[i].aumentarSalario(double.Parse(Console.ReadLine()));
                            }
                        }
                        break;
                    case 2:
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
