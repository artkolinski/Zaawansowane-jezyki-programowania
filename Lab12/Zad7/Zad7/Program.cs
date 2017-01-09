using System;
namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zad7 a)");
            int[] A = {5,1,3,4};
            for (int n = A.Length; n > 0; n--)
                for (int i = 0; i < n - 1; i++)
                    A = A[i] > A[i + 1] ? Exchange(A, i, i + 1) : A;              
            foreach (var a in A)
                Console.WriteLine(a);
            Console.WriteLine("Zad7 b)");
                Console.WriteLine($"NWD = {NWD(70,15)}");
            Console.ReadKey();
        }

        static int[] Exchange(int[] tab, int a, int b)
        {
            int temp = tab[a];
            tab[a] = tab[b];
            tab[b] = temp;
            return tab;
        }

        static int NWD(int a, int b)
        {
            while (a != b)
            {
                a = a > b ? a -= b : b -= a;
            }
            return a;
        }
    }
}
