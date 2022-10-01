using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace Labb_3
    //Oskar Ullsten 19820304
    //SUT 22-24
{
    class GameLevels
    {
        public static void Level1() 
        {
                int guesses1 = 6;           
            
                Random rnd = new Random();
                int level1 = rnd.Next(0, 20);
                bool right = false;             //Bool to check for right or wrong answer.

                Console.WriteLine();
                Console.WriteLine("I´m now thinking of a number between 0-20.");
                Console.WriteLine("You have " + guesses1 + " attempts!");
                Console.Write("Enter guess: ");                                  
                do
                {
                    int userGuess;
                    while (!int.TryParse(Console.ReadLine(), out userGuess)) //Check if user uses numbers, letters give message.
                    {
                        Console.Write("Enter a number: ");
                    }  
                    
                    if (guesses1 == 1)
                    {
                        Console.WriteLine("Thanks for playing! But now your attempts is out!");
                        Console.WriteLine();
                        PlayAgain();

                        right = true;
                        break;
                    }
                    if (userGuess == level1 - 2 || userGuess == level1 + 2) // Check if number in range with +-2 from rnd.number
                    {
                        guesses1--;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Whoo! It Burns!");
                        Console.ResetColor();
                        Console.Write("Enter guess: ");                                      
                    }
                    else if (userGuess == level1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("*** Congratulation! That was a hit ***");
                        Console.WriteLine();
                        PlayAgain();
                        break;
                    }
                    else if (userGuess > level1)
                    {
                        guesses1--;
                        AnswerToHigh();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have " + guesses1 + " attempts left!");
                        Console.Write("Enter guess: ");
                        Console.ResetColor();
                    }
                    else if (userGuess < level1)
                    {
                        guesses1--;
                        AnswerToLow();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have " + guesses1 + " attempts left!");
                        Console.Write("Enter guess: ");
                        Console.ResetColor();
                    }
                   
                } while (right == false);
        }
        //----------------------------------------------------------------------------------
        public static void Level2()
        {
            int guesses2 = 5;

            
            
                Random rnd = new Random();
                int level2 = rnd.Next(0, 50);
                bool right = false;

                Console.WriteLine();
                Console.WriteLine("I´m now thinking of a number between 0-50.");
                Console.WriteLine("You have " + guesses2 + " attempts!");
                Console.Write("Enter guess: ");
                do
                {
                    int userGuess;
                    while (!int.TryParse(Console.ReadLine(), out userGuess)) //Check if user uses numbers, letters give message.
                    {
                        Console.Write("Enter a number: ");
                    }

                    if (guesses2 == 1)
                    {
                        Console.WriteLine("Thanks for playing. But now your attempts it out!");
                        Console.WriteLine();
                        PlayAgain();

                        right = true;
                        break;
                    }
                    if (userGuess == level2 - 2 || userGuess == level2 + 2)
                    {
                        guesses2--;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Whoo! It Burns!");
                        Console.ResetColor();
                        Console.Write("Enter guess: ");
                    }
                    else if (userGuess == level2)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("*** Congratulation! That was a hit ***");
                        Console.ResetColor();
                        Console.WriteLine();
                        PlayAgain();
                        break;
                    }
                    else if (userGuess > level2)
                    {
                        guesses2--;
                        AnswerToHigh();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have " + guesses2 + " attempts left!");
                        Console.Write("Enter guess: ");
                        Console.ResetColor();
                    }
                    else if (userGuess < level2)
                    {
                        guesses2--;
                        AnswerToLow();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have " + guesses2 + " attempts left!");
                        Console.Write("Enter guess: ");
                        Console.ResetColor();
                    }
                } while (right == false);             
        }
        //----------------------------------------------------------------------------------
        public static void Level3()
        {
                int guesses3 = 3;

                Random rnd = new Random();
                int level3 = rnd.Next(0, 100);
                bool right = false;

                Console.WriteLine();
                Console.WriteLine("I´m now thinking of a number between 0-100.");
                Console.WriteLine("You get " + guesses3 + " attempt.");
                Console.Write("Enter guess: ");

                do
                {
                    int userGuess;
                    while (!int.TryParse(Console.ReadLine(), out userGuess)) //Check if user uses numbers, letters give message.
                    {
                        Console.Write("Enter a number: ");
                    }
                    if (guesses3 == 1)
                    {
                        Console.WriteLine("Thanks for playing. But now your attempts it out!");
                        Console.WriteLine();
                        PlayAgain();                 
                        right = true;
                        break;
                    }
                    if (userGuess == level3 - 2 || userGuess == level3 + 2)
                    {
                        guesses3--;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Whoo! It Burns!");
                        Console.ResetColor();
                        Console.Write("Enter guess: ");
                    }
                    else if (userGuess == level3)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("*** Congratulation! That was a hit ***");
                        Console.ResetColor();
                        Console.WriteLine();
                        PlayAgain();
                        break;
                    }
                    else if (userGuess > level3)
                    {                       
                        guesses3--;
                        AnswerToHigh();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have " + guesses3 + " attempts left!");
                        Console.Write("Enter guess: ");
                        Console.ResetColor();
                    }
                    else if (userGuess < level3)
                    {
                        guesses3--;
                        AnswerToLow();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have " + guesses3 + " attempts left!");
                        Console.Write("Enter guess: ");
                        Console.ResetColor();
                    }

                } while (right == false);           
        }   
            //--------------------------------------------------------------------------------------
                //Method to check if guess is near. Message to user if guess in range.
             static void GuessInRange(int level, int d)
             {

                if (d == level - 2 || d == level + 2)
                {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Whoo! It Burns!");
                Console.ResetColor();
                }
             }

        //--------------------------------------------------------------------------------------

        //Method to give user random answers.
            static void AnswerToLow() 
            {
                Console.WriteLine();
                 string[] randomAnswerLow = { "Sorry, number is to low!", "Oh no, To low!", "Are you scubadiving?!",
                 "Thats deep under surface!", "You´re halfway to China!"};
                       
                Random rnd = new Random();
                int answer = rnd.Next(0, randomAnswerLow.Length);
                Console.WriteLine($"{randomAnswerLow[answer]}");
            }

        //--------------------------------------------------------------------------------------

        //Method to give user random answers. Sometimes same answer comes 
            static void AnswerToHigh() 
            {
                Console.WriteLine();
                string[] randomAnswerHigh = { "Sorry, number is to high!", "Oh no, To high!",
                "You´re flying high above the clouds!", "That´s way to high!", "Going to the moon?" };

                Random rnd = new Random();
                int answer = rnd.Next(0, randomAnswerHigh.Length);
                Console.WriteLine($"{randomAnswerHigh[answer]}");
            }

        //----------------------------------------------------------------------------------

        //Method to ask user to start game again or not.
            static void PlayAgain() 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Would you like to play again? [Y/N]");
                Console.ResetColor();
                string again = Console.ReadLine();

                if (again == "Y" || again == "y")
                {
                    Console.WriteLine();
                    NumberMeny();
                }
                if (again == "n" || again == "N")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Thanks for this time!");
                    Console.ResetColor();
                }
            }

        //----------------------------------------------------------------------------------
            public static void NumberMeny()
            {
            bool contiune = true;

            while (contiune)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-------------------------");     
                Console.WriteLine("Choose difficulty level");
                Console.WriteLine("-------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("|Level[1]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("|Level[2]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|Level[3]");
                Console.ResetColor();

                int answer;
                if (Int32.TryParse(Console.ReadLine(), out answer))
                    switch (answer)
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
