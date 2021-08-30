using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
using xadrez;

namespace ProjetoXadrez
{
    class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i<tab.Linhas;i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j<tab.Colunas;j++)
                {
                    if (tab.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Peca(i, j));
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
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
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
