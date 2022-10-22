using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vet[i] = new Product { Name = name, Price = price };
            }

            double soma = 0.0;

            for (int i = 0; i < vet.Length; i++)
            {
                soma += vet[i].Price;
            }

            double media = soma / vet.Length;

            Console.WriteLine($"Media R$ {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
