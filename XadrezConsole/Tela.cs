using System;
using System.Text;
using tabuleiro;
namespace XadrezConsole
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Peca(i, j) == null) sb.Append("- ");
                    else sb.Append($"{tabuleiro.Peca(i, j)} ");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
