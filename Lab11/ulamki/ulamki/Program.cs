using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ulamki
{
    public class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            List<Fraction> fractList = new List<Fraction>();
            for (int i = 0; i < 1000; i++)
            {
                fractList.Add(GenerateRandomFraction());
            }
            var stopwatch = new Stopwatch();
            Fraction a = new Fraction(2, 1);
            Fraction b = new Fraction(2, 3);
            stopwatch.Start();
                //Console.Write($"Adding by overload operator {a} + {b} = ");
                //Console.WriteLine(a+b);
                    for (int i = 0; i < 999; i++)
                    {
                        var temp = fractList[i] + fractList[i + 1];
                    }
                stopwatch.Stop();
                Console.WriteLine("Time adding by overload operator = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            stopwatch.Start();
               // Console.Write($"Adding by function {a} + {b} = ");
                //Console.WriteLine(Fraction.Add(a,b));
                for (int i = 0; i < 999; i++)
                {
                    var temp = Fraction.Add(fractList[i], fractList[i + 1]);
                }
                stopwatch.Stop();
                Console.WriteLine("Time adding by function = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            Console.WriteLine();
            stopwatch.Start();
                //Console.Write($"Multiply by overload operator {a} * {b} = ");
                //Console.WriteLine(a * b);
                for (int i = 0; i < 1000; i++)
                {
                    var temp = GenerateRandomFraction() * GenerateRandomFraction();
                }
                stopwatch.Stop();
                Console.WriteLine("Time Multiply by overload operator = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            stopwatch.Start();
                //Console.Write($"Multiply by function {a} * {b} = ");
                //Console.WriteLine(Fraction.Multiply(a, b));
                for (int i = 0; i < 1000; i++)
                {
                    var temp = Fraction.Multiply(GenerateRandomFraction(), GenerateRandomFraction());
                }
                stopwatch.Stop();
                Console.WriteLine("Time Multiply by function = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            Console.WriteLine();
            stopwatch.Start();
                //Console.Write($"Division by overload operator {a} / {b} = ");
                //Console.WriteLine(a / b);
                for (int i = 0; i < 1000; i++)
                {
                    var temp = GenerateRandomFraction() / GenerateRandomFraction();
                }
                stopwatch.Stop();
                Console.WriteLine("Time Division by overload operator = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            stopwatch.Start();
                //Console.Write($"Division by function {a} / {b} = ");
                //Console.WriteLine(Fraction.Division(a, b));
                for (int i = 0; i < 1000; i++)
                {
                    var temp = Fraction.Division(GenerateRandomFraction(), GenerateRandomFraction());
                }
                stopwatch.Stop();
                Console.WriteLine("Time Division by function = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            Console.WriteLine();
            Console.WriteLine();
            stopwatch.Start();
                for (int i = 0; i < 100; i++)
                {
                    var temp = GenerateRandomFraction() - GenerateRandomFraction();
                }
                stopwatch.Stop();
                Console.WriteLine("Time Subtraction by overload operator = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            stopwatch.Start();
                for (int i = 0; i < 100; i++)
                {
                    var temp = Fraction.Subtraction(GenerateRandomFraction(), GenerateRandomFraction());
                }
                stopwatch.Stop();
                Console.WriteLine("Time Subtraction by function = " + stopwatch.ElapsedMilliseconds + " ms");
                stopwatch.Reset();
            Console.WriteLine();
            Console.WriteLine("EuklidesNWD = " + EuklidesNWD(3, 9));
            Console.WriteLine("RND test = " + GenerateRandomFraction() + ", " + GenerateRandomFraction() + ", " + GenerateRandomFraction());
            Console.ReadKey();
        }

        public static Fraction GenerateRandomFraction()
        {    
            int a = rnd.Next(1, 25);
            int b = rnd.Next(1, 100);
            do
            {
                 b = rnd.Next(1, 100);
            }
            while (EuklidesNWD(a, b) > 1);
            return new Fraction(a, b);
        }

        public static int EuklidesNWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }
}
