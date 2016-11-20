using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine("-----------------------------");
            Console.Write("Podaj wejście: ");
            string inputItem = Console.ReadLine();
            string lexem = "";
            string state = "S";
            Console.WriteLine($"Input: {inputItem}");
            Console.WriteLine("-------Output-------");
            inputItem = inputItem.ToLower();
            for (int i = 0; i < inputItem.Length; i++)
            {
                    switch (state)
                    {
                        case "S":
                            lexem += inputItem[i];
                            if (inputItem[i] == 'a')
                            {
                                state = "A";
                            }
                            else
                            {
                                if (inputItem[i] == 'k')
                                {
                                    state = "K";
                                }
                                else
                                {
                                    if (inputItem[i] != ' ')
                                    {
                                        Console.WriteLine($"Blad mialo byc 'a' lub 'k' , a przyszlo {lexem}");
                                        state = "END";
                                    }
                                }    
                            }
                            break;
                        case "A":
                            lexem += inputItem[i];
                            if (inputItem[i] == 'd')
                            {
                                state = "AD";
                            }
                            else
                            {
                                if (inputItem[i] == 's') //->asia
                                {
                                    state = "KAS";
                                }
                                else
                                {
                                    Console.WriteLine($"Blad mialo byc ad albo as, a przyszlo {lexem}");
                                    state = "END";
                                }
                            }
                            break;
                        case "AD":
                            lexem += inputItem[i];
                            if (inputItem[i] == 'a')
                            {
                                state = "ADA";
                            }
                            else
                            {
                                Console.WriteLine($"Blad mialo byc ada, a przyszlo {lexem}");
                                state = "END";
                            }
                            break;
                        case "ADA":
                            if (inputItem[i] == 'm') //adam
                            {
                                lexem += inputItem[i];
                                Console.WriteLine($"Meżczyzna: {lexem}");
                                state = "S";
                                lexem = "";
                            }
                            else //ada
                            {
                                Console.WriteLine($"Kobieta: {lexem}");
                                state = "S";
                                lexem = "";
                                i--; // litera różna od 'm' trzeba ją sprawdzić
                            }
                            break;
                        case "K":
                            lexem += inputItem[i];
                            if (inputItem[i] == 'a')
                            {
                                state = "KA";
                            }
                            else
                            {
                                Console.WriteLine($"Blad mialo byc ka, a przyszlo {lexem}");
                                state = "END";
                            }
                            break;
                        case "KA":
                            lexem += inputItem[i];
                            if (inputItem[i] == 'm') //->kamil
                            {
                                state = "KAM";
                            }
                            else
                            {
                                if (inputItem[i] == 's') //->kasia
                                { 
                                    state = "KAS";
                                }
                                else
                                {
                                    Console.WriteLine($"Blad mialo byc ada, a przyszlo {lexem}");
                                    state = "END";
                                } 
                            }
                            break;
                        case "KAM":
                            lexem += inputItem[i];
                            if (inputItem[i] == 'i')
                            {
                                state = "KAMI";
                            }
                            else
                            {
                                Console.WriteLine($"Blad mialo byc kami, a przyszlo {lexem}");
                                state = "END";
                            }
                            break;
                        case "KAS":
                            lexem += inputItem[i];
                            if (inputItem[i] == 'i')
                            {
                                state = "KASI";
                            }
                            else
                            {
                                Console.WriteLine($"Blad mialo byc kasi albo asi, a przyszlo {lexem}");
                                state = "END";
                            }
                            break;
                        case "KASI":
                            lexem += inputItem[i];
                            if (inputItem[i] == 'a')
                            {
                                Console.WriteLine($"Kobieta: {lexem}");
                                state = "S";
                                lexem = "";
                            }
                            else
                            {
                                Console.WriteLine($"Blad mialo byc kasia albo asia, a przyszlo {lexem}");
                                state = "END";
                            }
                            break;
                        case "KAMI":
                            lexem += inputItem[i];
                            if (inputItem[i] == 'l')
                            {
                                state = "KAMIL";
                            }
                            else
                            {
                                Console.WriteLine($"Blad mialo byc kamil, a przyszlo {lexem}");
                                state = "END";
                            }
                            break;
                        case "KAMIL":
                            if (inputItem[i] == 'a')
                            {
                                lexem += inputItem[i];
                                Console.WriteLine($"Kobieta: {lexem}");
                                state = "S";
                                lexem = "";
                            }
                            else
                            {
                                Console.WriteLine($"Meżczyzna: {lexem}");
                                state = "S";
                                lexem = "";
                                i--; // litera różna od 'a' trzeba ją sprawdzić
                            }
                            break;
                        case "END":
                            while (i < inputItem.Length)
                            {
                                lexem += inputItem[i];
                                i++;
                            }
                            break;
                    }
            }
                switch (state)
                {
                    case "KAMIL":
                        Console.WriteLine($"Meżczyzna: {lexem}");
                        break;
                    case "ADA":
                        Console.WriteLine($"Kobieta: {lexem}");
                        break;
                    case "S":
                        break;
                    default:
                        Console.WriteLine($"Blad to żaden z lexemów, przyszlo {lexem}, stan {state}");
                        break;
                }
            Console.WriteLine();
        }
      }
   }
}
