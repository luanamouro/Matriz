using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[2,2];
            double somat = 0;

            Console.WriteLine("Projeto soma matriz\n\n");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine("Digite o elemento [{0},{1}], da matriz A.", linha.ToString(), coluna.ToString());
                    a[linha, coluna] = Convert.ToDouble(Console.ReadLine());
                    somat += [linha, coluna];
                }
            }
            Console.WriteLine("Soma: {0}", somat.ToString());
        }
    }
}
