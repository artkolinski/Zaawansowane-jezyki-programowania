using System;
using System.Diagnostics;

namespace Zad1
{
    class Program
    {
        //static Random _rnd = new Random();
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
           // for (int i = 0; i < 10000; i++)
           // {
                 int[] tab = new int[10000];
           // }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + "");
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                int[] tab2 = new int[100000];
            }
            stopwatch2.Stop();
            Console.WriteLine(stopwatch2.ElapsedMilliseconds + "");
            Stopwatch stopwatch3 = Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                int[] tab3 = new int[1000000];
            }
            stopwatch3.Stop();
            Console.WriteLine(stopwatch3.ElapsedMilliseconds+"");
            Console.ReadKey();
        }
    }
}
