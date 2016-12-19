using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            function();
            Console.ReadKey();
        }
        static void function()
        {
            int x = 5;
            int i = 1;
            while (i != 0)
            {
                int x = 4;
                Console.WriteLine("x = "+x);
                i--;
            }
            Console.WriteLine("x = " + x);
        }
    }
}
