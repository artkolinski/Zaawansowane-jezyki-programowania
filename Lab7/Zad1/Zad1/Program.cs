using System;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------Zad 1 a)----------------");
                Console.Write("Podaj wejście: ");
                string inputItem = Console.ReadLine();
                //string inputItem = "aabecdd";
                string state = "S";
                Console.WriteLine($"Input: {inputItem}");
                Console.WriteLine("-------Output-------");
                inputItem = inputItem.ToLower();
                int endOfInputItem = inputItem.Length - 1;
                for (int i = 0; i < inputItem.Length; i++)
                {
                    
                    switch (state)
                    {
                        case "S":
                            if (inputItem[i] == 'a' && inputItem[endOfInputItem - i] == 'd')
                            {
                                state = "S";
                            }
                            else
                            {
                                state = "B";
                                i--;
                            }
                            break;
                        case "B":
                            if (inputItem[i] == 'b' && inputItem[endOfInputItem - i] == 'c')
                            {
                                state = "B";
                                if (i+1 >= inputItem.Length/2) state = "ACCEPT";
                            }
                            else
                            {
                                if (inputItem[i] == 'e' & inputItem.Length / 2 == i | i == Convert.ToInt32(Math.Ceiling((double)inputItem.Length / 2)))
                                {
                                    state = "ACCEPT";
                                }
                                else
                                {
                                    state = "END";
                                }
                            }
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
