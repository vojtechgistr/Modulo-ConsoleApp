using System;
using System.Threading.Tasks;

namespace Modulo
{
    class Program
    {
        public static int pauseTime = 50;


        static void Main(string[] args)
        {
            int vysledek;
           pokracovani:
            Console.Clear();

           start:
            Console.WriteLine("Enter the number you want to work with: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string AasString = Console.ReadLine();
            int a;


            if (int.TryParse(AasString, out a))
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter the divisor:");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string BasString = Console.ReadLine();
                int b;

                if (int.TryParse(BasString, out b))
                {
                    if (b == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The divisor can't be 0!");
                        Console.ForegroundColor = ConsoleColor.White;

                        goto start;
                    } 

                    vysledek = a % b;
                    if (vysledek > 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Number ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(a);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" is not divisible by number ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(b);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;


                        // opakovat
                        Console.WriteLine("Do you want to try this application again? A / N");
                        while (true)
                        {
                            switch (Console.ReadKey().KeyChar.ToString().ToLower())
                            {
                                case "a":
                                    goto pokracovani;
                                case "n":
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid selection");

                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Do you want to try this application again? A / N");
                                    break;
                            }
                        }
                    }
                       

                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Number ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(a);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" is divisible by number ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(b);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;


                        // opakovat
                        Console.WriteLine("Do you want to try this application again? A / N");
                        while (true)
                        {
                            switch (Console.ReadKey().KeyChar.ToString().ToLower())
                            {
                                case "a":
                                    goto pokracovani;
                                case "n":
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid selection");

                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Do you want to try this application again? A / N");
                                    break;
                            }
                        }

                    }
                        

                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The divisor must be a number!");
                    Console.ForegroundColor = ConsoleColor.White;

                    goto start;
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The input must be a number!");
                Console.ForegroundColor = ConsoleColor.White;

                goto start;
            }
            
        }
    }
}
