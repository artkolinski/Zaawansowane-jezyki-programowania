using System;

namespace aba09
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputItem = "102aba104";
            string lexem = "";
            string state = "S"; // S, A, AB, Numb
            Console.WriteLine($"Input: {inputItem}");
            inputItem = inputItem.ToLower();
            for (int i=0; i<inputItem.Length; i++)
            {
                if (Char.IsNumber(inputItem[i]))
                {
                    if (state == "S" | state == "Numb")
                    {
                        lexem += inputItem[i];
                        state = "Numb";
                    }
                    else
                    {
                        Console.WriteLine($"Blad mialo byc aba, a przyszlo {lexem}");
                        lexem = "";
                        lexem += inputItem[i];
                        state = "Numb";
                    }
                }
                else
                {
                    switch (state)
                    {
                        case "S":
                            if (inputItem[i] == 'a')
                            {
                                lexem += inputItem[i];
                                state = "A";
                            }
                            else
                            {   if (inputItem[i] != ' ')
                                {
                                    Console.WriteLine($"Blad mialo byc aba, a przyszlo {lexem}");
                                    lexem = "";
                                }
                                state = "S";
                            }
                            break;
                        case "A":
                            if (inputItem[i] == 'b')
                            {
                                lexem += inputItem[i];
                                state = "AB";
                            }
                            else
                            {
                                Console.WriteLine($"Blad mialo byc aba, a przyszlo {lexem}");
                                state = "S";
                                lexem = "";
                            }
                            break;
                        case "AB":
                            if (state == "AB" & inputItem[i] == 'a')
                            {
                                lexem += inputItem[i];
                                state = "S";
                                Console.WriteLine($"{lexem} Lexem");
                                lexem = "";
                            }
                            else
                            {
                                Console.WriteLine($"Blad mialo byc aba, a przyszlo {lexem}");
                                state = "S";
                                lexem = "";
                            }
                            break;
                        case "Numb":
                            Console.WriteLine($"{lexem} Lexem cyfra");
                            lexem = "";
                            state = "S";
                            i--;
                            break;
                    }
                }
            }
            if (state == "Numb")
            {
                Console.WriteLine($"{lexem} Lexem");
                state = "S";
            }
            if(state != "S") Console.WriteLine($"Blad mialo byc aba, a przyszlo {lexem}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
