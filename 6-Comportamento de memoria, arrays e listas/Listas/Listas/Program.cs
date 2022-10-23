using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //List<string> list = new List<string> { "Maria", "Alex" };

            List<string> list = new List<string>();

            // .Add() -> Adiciona ao final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Leonardo");
            list.Add("Marcia");
            list.Add("Catarina");
            list.Add("Leticia");
            list.Add("Nicolas");
            list.Add("Mariana");
            list.Add("Tailan");

            // .Insert() -> adiciona o novo valor em um índice específico
            list.Insert(2, "Marco");

            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"List.count = {list.Count}");

            //string s1 = list.Find(Test);
            string s1 = list.Find(x => x[0] == 'A'); // função anônima
            Console.WriteLine($"First 'A': {s1}");

            string s2 = list.FindLast(x => x[0] == 'A'); // função anônima
            Console.WriteLine($"Last 'A': {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First pos 'A': {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"First pos 'A': {pos2}");

            Console.WriteLine("-------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            
            foreach(string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            list.Remove("Alex");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            list.RemoveAt(1);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            list.RemoveRange(0, 2);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
