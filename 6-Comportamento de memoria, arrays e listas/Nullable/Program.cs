using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operador Nullable

            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x é nullo");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y é nullo");

            // Operador do coalescência
            double? z = x ?? y;
            Console.WriteLine(z);
        }
    }
}
