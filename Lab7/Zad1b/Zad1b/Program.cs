using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1b
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------Zad 1 b)----------------");
                Console.Write("Podaj wejście: ");
                string inputItem = Console.ReadLine();
                string state = "A";
                Console.WriteLine($"Input: {inputItem}");
                Console.WriteLine("-------Output-------");
                inputItem = inputItem.ToLower();
                for (int i = 0; i < inputItem.Length; i++)
                {
                    switch (inputItem[i])
                    {
                        case 'a':
                            if (state == "B")
                            {
                                state = "END";
                                i = inputItem.Length;
                            }
                            else
                            {
                                state = "A";
                            }
                            break;
                        case 'x':
                            if (state == "A")
                            {
                                state = "B";
                            }
                            else
                            {
                                if (i == inputItem.Length - 1)
                                {
                                    state = "ACCEPT";
                                }
                                else
                                {
                                    state = "END";
                                    i = inputItem.Length;
                                }
                            }
                            break;
                        case 'b':
                            if (state == "A")
                            {
                                state = "END";
                                i = inputItem.Length;
                            }
                            else
                            {
                                state = "B";
                            }
                            break;
                        default:
                            state = "END";
                            i = inputItem.Length;
                            break;
                    }
                }
                switch (state)
                {
                    case "ACCEPT":
                        Console.WriteLine("To porpawna gramatyka");
                        break;
                    case "END":
                        Console.WriteLine("Błąd to nie ta gramtyka");
                        break;
                    default:
                        Console.WriteLine("Błąd to zła gramtyka");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
