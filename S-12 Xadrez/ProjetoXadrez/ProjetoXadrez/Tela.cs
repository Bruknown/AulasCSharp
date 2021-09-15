using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
using xadrez;

namespace ProjetoXadrez
{
    class Tela
    {
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimirTabuleiro(partida.Tab);

            ImprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.Turno);
            Console.WriteLine("aguardando jogada: " + partida.JogadorAtual);
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.Write("Pecas Capturadas: ");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.Write(" Pretas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
        }

        public static void imprimirConjunto(HashSet<Peca> pecas)
        {
            Console.Write("[");
            foreach(Peca x in pecas)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i<tab.Linhas;i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j<tab.Colunas;j++)
                {
                    ImprimirPeca(tab.Peca(i, j)); 
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }
        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (posicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tab.Peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }


        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }

            }
        }
    }
}
