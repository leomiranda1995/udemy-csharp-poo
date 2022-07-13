using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Voume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
