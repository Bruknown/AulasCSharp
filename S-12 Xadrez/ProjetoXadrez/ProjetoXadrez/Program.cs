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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida); 

                        Console.WriteLine();
                        Console.WriteLine("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);


                        Console.WriteLine("Destino: ");

                        Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
                        partida.validarPosicaoDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    
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
