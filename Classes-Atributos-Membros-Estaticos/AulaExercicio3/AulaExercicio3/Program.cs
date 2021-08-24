using System;

namespace AulaExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");

            Console.WriteLine("Nome do produto: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade do produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade do produto a ser adicionado");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade do produto a ser removido");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}
