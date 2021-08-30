using tabuleiro;
using System;
using xadrez;


namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine("Origem: ");

                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();


                    Console.WriteLine("Destino: ");

                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.executaMovimento(origem, destino);
                }

                Tela.ImprimirTabuleiro(partida.Tab);
                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
