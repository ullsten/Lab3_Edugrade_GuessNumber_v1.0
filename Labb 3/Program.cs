using Labb_3;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Labb3GuessNumber
    //Oskar Ullsten 19820304
    //SUT22-24
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool contiune = true;   //Bool to check if answer is right. Message if user use letters or wrong numbers.

            while (contiune)
            {
                Console.WriteLine(".----------------------------.");
                Console.WriteLine("|Welcome to the numbers game|");
                Console.WriteLine(".----------------------------.");
                Console.WriteLine("I´m thinking of a number in between 0-100 depending your choose of level.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("|Level[1]|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("|Level[2]|");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|Level[3]|");
                Console.ResetColor();

                    int levelAnswer;
                    if (Int32.TryParse(Console.ReadLine(), out levelAnswer))
                    switch (levelAnswer)
                    {
                        case 1:
                            GameLevels.Level1();
                            contiune = false;
                            break;

                        case 2:
                            GameLevels.Level2();
                            contiune = false;
                            break;

                        case 3:
                            GameLevels.Level3();
                            contiune = false;
                            break;     
                    }
                    if (contiune)
                    {
                    Console.WriteLine();
                    Console.WriteLine("Valid choice is between 1-3.");
                    Console.WriteLine();
                    }
            }     
        }
    }
}
