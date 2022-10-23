using System;
using System.Collections.Generic;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double[,] matriz = new double[2, 3];

            Console.WriteLine(matriz.Length);
            Console.WriteLine(matriz.Rank); // qauntidade de linhas
            Console.WriteLine(matriz.GetLength(0)); // quantidade de linhas
            Console.WriteLine(matriz.GetLength(1)); // quantidade de colunas

            */

            Console.Write("Informe a ordem da matriz: ");
            int ordemMatriz = int.Parse(Console.ReadLine());

            int[,] matriz = new int[ordemMatriz, ordemMatriz];

            List<int> diagonalPrincipal = new List<int>();
            List<int> numerosNegativos = new List<int>();
            int totalNumerosNegativos = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"\nInforme o valor da matriz na posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());


                    if (matriz[i, j] < 0)
                    {
                        numerosNegativos.Add(matriz[i, j]);
                        totalNumerosNegativos++;
                    }

                    if (i == j)
                    {
                        diagonalPrincipal.Add(matriz[i, j]);
                    }
                }
            }

            Console.WriteLine("\n--------------------------------");

            Console.Write("\nDiagonal Principal: ");
            foreach (int diagonal in diagonalPrincipal)
            {
                Console.Write($"{diagonal}, ");
            }

            Console.Write($"\n\nTotal Números negativos: {totalNumerosNegativos}");

            if (totalNumerosNegativos > 0)
            {
                Console.Write($"\nLista de números negativos:");
                foreach (int numero in numerosNegativos)
                {
                    Console.Write($"{numero}, ");
                }
            }
        }
    }
}
