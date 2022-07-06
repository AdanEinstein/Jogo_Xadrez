using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine(new Posicao(3,4));
                    //Console.WriteLine(new Tabuleiro(8,8));
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 9));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tabuleiro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}