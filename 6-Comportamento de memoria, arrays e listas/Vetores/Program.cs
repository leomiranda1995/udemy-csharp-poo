using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for(int i = 0; i < n; i++)
            {
                soma += vet[i];
                Console.WriteLine($"Vet[{i}] = {vet[i]}");
            }

            double media = soma / n;

            Console.WriteLine($"Media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
