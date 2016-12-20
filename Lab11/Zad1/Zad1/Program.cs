using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (i = 0; i < lim − 1 && (c = getchar()) != '\n' && c != EOF; ++i)
            
            string c ="tralala lala asdfsad";
            int lim = c.Length+1;
            for (int i = 0; i < lim - 1;)
            {
                if (c[i] != '\n')
                {
                    if (i < c.Length)
                    {
                        Console.Write(c[i]);
                        ++i;
                    }
                } 
            }
            Console.ReadKey();
        }
    }
}
