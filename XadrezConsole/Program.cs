using System;
using tabuleiro;

namespace XadrezConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new Posicao(3,4));
            Console.WriteLine(new Tabuleiro(8,8));
        }
    }
}