using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace lab2
{
    class Program
    {
        static Random _rnd = new Random();
        static void Main(string[] args)
        {
            // Zad 1 a) d) f)
            long[,] elapsedTime = new long[10, 10];
            for (int testCount = 0; testCount < 10; testCount++)
            {
                int count = 0;
                for (int i = 100; i < 100000000; i *= 10)
                {
                    long elapsedMilliseconds = ScalarProduct(RandomDoubleTable(i-1), RandomDoubleTable(i)).ElapsedMilliseconds;
                    Console.WriteLine("data = " + i + ", time: " + elapsedMilliseconds*0.001 + " s");
                    elapsedTime[count, testCount] = elapsedMilliseconds;
                    count++;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                float average = 0;
                for (int j = 0; j < 10; j++)
                {
                    average += elapsedTime[i, j];
                }
                average /= 10;
                Console.WriteLine("data = " + i + ", avg time: " + average*0.001 + " s");
            }
            Console.ReadKey();
        }

        static Stopwatch ScalarProduct(double[] a, double[] b)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            double product = 0;
            if (a.Length > b.Length)
            {
                double[] c = new double[a.Length];
                Array.Copy(b, c, b.Length);
                for(int i = b.Length; i<a.Length; i++)
                {
                    c[i]= 0;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    product += (c[i] * a[i]);
                }
            }
            else
            {
                double[] c = new double[b.Length];
                Array.Copy(a, c, a.Length);
                for (int i = a.Length; i < b.Length; i++)
                {
                    c[i] = 0;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    product += (b[i] * c[i]);
                }
            }    
            //Console.WriteLine("ScalarProduct = " + product);
            stopwatch.Stop();
            return stopwatch;
        }


        static int[] RandomIntsTable(int count)
        {
            int[] randomNumbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                int number = _rnd.Next(0, 1000);
                randomNumbers[i] = number;
            }
            return randomNumbers;
        }
        static double[] RandomDoubleTable(int count)
        {
            double[] randomNumbers = new double[count];
            for (int i = 0; i < count; i++)
            {
                randomNumbers[i] = NextFloat();
            }
            return randomNumbers;
        }
        static float NextFloat()
        {
            double mantissa = (_rnd.NextDouble() * 2.0) - 1.0;
            double exponent = Math.Pow(2.0, _rnd.Next(-126, 128));
            return (float)(mantissa * exponent);
        }
    }
}
