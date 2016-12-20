
using System;
using System.Diagnostics;

namespace ulamki
{
    public class Program
    {
        static void Main()
        {
            var stopwatch = new Stopwatch();
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(2, 3);
            stopwatch.Start();
                Console.Write($"Adding by overload operator {a} + {b} = ");
                Console.WriteLine(a+b);
                stopwatch.Stop();
                Console.WriteLine("Time adding by overload operator = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            stopwatch.Start();
                Console.Write($"Adding by function {a} + {b} = ");
                Console.WriteLine(Fraction.Add(a,b));
                stopwatch.Stop();
                Console.WriteLine("Time adding by function = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            Console.ReadKey();
        }
    }
}
