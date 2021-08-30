using ProjetoXadrez.tabuleiro;
using System;
using tabuleiro;
using xadrez;


namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 7));

                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 3));


                Tela.imprimirTabuleiro(tabuleiro);

                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
