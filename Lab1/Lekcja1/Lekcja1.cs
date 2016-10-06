using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lekcja1
{
    class Program
    {
        private static int _number;
        static void Main(string[] args)
        {
            //Zad 1
            //List<int> randomInts = RandomInt(5);
            //List<float> randomFloats = RandomFloat(5);

            //Zad 2 b
            //Console.WriteLine("Sum = " + ReadNumbers(2, 0));
            //Zad 2 c
            //Console.WriteLine("Short Sum = " + ShortSum());
            
            //Zad 3
            //GotoLoops();

            //Zad 4
            //Console.WriteLine("");
            //Console.WriteLine("Silnia zwykła = " + Silnia(6));
            //_number = 6;
            //Console.WriteLine("Silnia bezparametrowa = " + SilniaBezparam());

            Console.ReadKey();
        }

        static void GotoLoops()
        {
            int i = 5, j = 10;
            Loop1:
            Console.WriteLine("");
            Console.WriteLine("Loop1:");
            Loop2:
            Console.Write("- ");
            j--;
            if (j > 0) goto Loop2;
            j = 10;
            i--;
            if (i>0) goto Loop1;
        }
        static int SilniaBezparam()
        {
            Stack stos = new Stack();
            int result = 1;
            for (int i = 1; i <= _number; i++)
            {
                stos.Push(i); 
            }
            while ((int) stos.Peek() > 1)
            {
                result *= (int)stos.Pop();
            }
            return result;
        }
        static int Silnia(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        static int ShortSum()
        {
            Console.Write("Amount = ");
            int i = ReadInt(); //88 znaków do końca
            List<int> a = new List<int>();
            while (i > 0)
            {
                a.Add(ReadInt());
                i--;
            }
            return a.Sum();
        }

        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static int ReadNumbers(int amount, int sum)
        {
            sum += ReadInt();
            if (amount == 1) return sum;
            return ReadNumbers(amount - 1, sum);
        }
        static List<int> RandomInt(int count)
        {
            List<int> randomNumbers = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int number = rnd.Next(0, 500);
                randomNumbers.Add(number);
            }
            return randomNumbers;
        }
        static List<float> RandomFloat(int count)
        {
            List<float> randomNumbers = new List<float>();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                double number = Math.Round(rnd.NextDouble() * rnd.Next(0,500),3);
                randomNumbers.Add((float)number);
            }
            return randomNumbers;
        }
    }
}

