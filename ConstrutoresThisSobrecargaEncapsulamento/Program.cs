using System;
using System.Globalization;

namespace ConstrutoresThisSobrecargaEncapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900, 5);

            p.Nome = "tv 4k";

            Console.WriteLine(p);
        }
    }
}
