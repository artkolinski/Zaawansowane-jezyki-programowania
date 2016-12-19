using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mnozenie_macierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = {1, 0, 2, -1 , 3, 1};
            int[] tab2 = {3,1,2,1,1,0 };
            int[,] tab11 = { {1,0,2},{ -1, 3, 1 } };
            int[,] tab22 = { {3, 1 }, { 2, 1 }, { 1, 0 } };
            Console.WriteLine("-----");
            MultiplyMatrix2(tab1,tab2,3,2);
            Console.WriteLine("-----");
            MultiplyMatrix(tab11,tab22);
            #region Stopwatches
            //var stopwatch4 = new Stopwatch();
            //stopwatch4.Start();
            //MultiplyMatrix2(FilledTableOneDimm(10), FilledTableOneDimm(10));
            //stopwatch4.Stop();
            //Console.WriteLine("Czas 10x10 = " + stopwatch4.ElapsedMilliseconds + " ms");
            //var stopwatch5 = new Stopwatch();
            //stopwatch5.Start();
            //MultiplyMatrix2(FilledTableOneDimm(100), FilledTableOneDimm(100));
            //stopwatch5.Stop();
            //Console.WriteLine("Czas 100x100 = " + stopwatch5.ElapsedMilliseconds + " ms");
            //var stopwatch6 = new Stopwatch();
            //stopwatch6.Start();
            //MultiplyMatrix2(FilledTableOneDimm(1000), FilledTableOneDimm(1000));
            //stopwatch6.Stop();
            //Console.WriteLine("Czas 1000x1000 = " + stopwatch6.ElapsedMilliseconds + " ms");
            //// ---------------------

            //var stopwatch3 = new Stopwatch();
            //stopwatch3.Start();
            //MultiplyMatrix(FilledTable(10), FilledTable(10));
            //stopwatch3.Stop();
            //Console.WriteLine("Czas 10x10 = " + stopwatch3.ElapsedMilliseconds + " ms");
            //var stopwatch = new Stopwatch();
            //stopwatch.Start();
            //MultiplyMatrix(FilledTable(100), FilledTable(100));
            //stopwatch.Stop();
            //Console.WriteLine("Czas 100x100 = " + stopwatch.ElapsedMilliseconds + " ms");
            //var stopwatch2 = new Stopwatch();
            //stopwatch2.Start();
            //MultiplyMatrix(FilledTable(1000), FilledTable(1000));
            //stopwatch2.Stop();
            //Console.WriteLine("Czas 1000x1000 = " + stopwatch2.ElapsedMilliseconds + " ms");
            #endregion
            Console.ReadKey();
        }

        static int[,] FilledTable(int n)
        {
            var tab = new int[n,n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tab[i,j] = rnd.Next(1, 13);
                }
            }
            return tab;
        }

        static int[] FilledTableOneDimm(int n)
        {
            var tab = new int[n*n];
            Random rnd = new Random();
            for (int i = 0; i < n*n; i++)
            {
                    tab[i] = rnd.Next(1, 13);
            }
            return tab;
        }
        


        static void MultiplyMatrix2(int[] a, int[] b, int columnsA, int columnsB)
        {
            int[] c = new int[columnsB * columnsB];
            int resultMatrIndex = 0;
            int j = 0;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length ; i++)
                {
                    if (i >= columnsA && resultMatrIndex + columnsB < columnsB*columnsB)
                    {
                        resultMatrIndex += columnsB;
                        j = 0;
                    }
                        for (int k = 0; k < columnsB; k++)
                        {
                            c[resultMatrIndex + k] += a[i] * b[j + k];
                        }
                        j += columnsB;
                }
            }
            else
            {
                Console.WriteLine("\n Zle wymiary tablicy");
                Environment.Exit(-1);
            }
            foreach (var i in c)
            {
                Console.WriteLine(i);
            }
        }


        static void MultiplyMatrix(int[,] a, int[,] b)
        {
            int[,] c = new int[1000, 1000];
            if (a.GetLength(1) == b.GetLength(0))
            {
                c = new int[a.GetLength(0), b.GetLength(1)];
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.GetLength(1); k++)
                            c[i, j] = c[i, j] + a[i, k] * b[k, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("\n Zle wymiary tablicy");
                Environment.Exit(-1);
            }
            foreach (var i in c)
            {
                Console.WriteLine(i);
            }
        }
    }
}
