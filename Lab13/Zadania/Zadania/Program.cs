using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Zad1");
            List<int> tab = new List<int>{13,2,3,4,10,-5};
            int min, max;
            zad1(tab,tab.Count,out min,out max);
            Console.WriteLine($"Min={min}, Max={max}");
            Console.WriteLine();
            Console.WriteLine("Zad2");
            List<int> tab2 = new List<int>{ 13, 2, 3, 4, 10, -5 };
            List<int> zad2tab = zad2(tab, tab.Count, tab2, tab2.Count, dodaj);
            foreach (var a in zad2tab)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("Zad3");
            Console.ReadKey();
        }

        static void zad1(List<int> tab, int length,out int min ,out int max)
        {
            min = 0;
            max = 0;
            foreach (var a in tab)
            {
                min = Math.Min(min, a);
                max = Math.Max(max, a);
            } 
        }

        static List<int> zad2(List<int> tab, int length, List<int> tab2, int length2, Func<int,int,int> myFunction)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < tab.Count; i++)
            {
                output.Add( myFunction(tab[i], tab2[i]));
            }
            return output;
        }

        static int dodaj(int a, int b)
        {
            return a + b;
        }

    }

}
