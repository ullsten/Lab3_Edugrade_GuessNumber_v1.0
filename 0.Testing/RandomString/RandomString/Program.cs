using System;

namespace RandomString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] randomAnswerHigh = { "Tyvärr, nummret är för högt. Försök igen!", "Oh no, To high. Try again!",
                "You´re flying high above the clouds. Try again!", "Ser du ner? För du är hög! Försök igen!", "Du kan inte flyga så högt. Försök igen!" };

            string[] randomAnswerLow = { "Tyvärr, nummret är för lågt. Försök igen!", "Oh no, To low! Try again!", "Are you diving? It´s to low! Try again!",
            "Bäst du tar dig till ytan! Du är under ytan! Försök igen!", "Are you digging to China? Stop! It´s to low!"};

            Random rnd = new Random();
            int answer = rnd.Next(0, randomAnswerHigh.Length);

            Console.WriteLine($"{randomAnswerHigh[answer]}");

            

            Console.ReadKey();
        }

        public static void Letters()  //KOLLA KOLLA KOLLA 
        {
            int guesses4 = 5;

            try
            {
                string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                Random rnd = new Random();
                int i = rnd.Next(0, 5); //0, 51
                string char1 = Characters[i].ToString();
                bool right = false;

                Console.WriteLine("Gissa på en bokstav A-Ö.");
                Console.WriteLine("Du har " + guesses4 + " försök!");

                do
                {
                    string s = Console.ReadLine();
                    //int i = Int32.Parse(s);



                    if (guesses4 == 1)
                    {
                        Console.WriteLine("Tack för att du spelade! Men det var ditt sista försök!");
                        PlayAgain();

                        right = true;
                    }
                    else if (i == guesses4)
                    {
                        Console.WriteLine("Grattis! Vilken fullträff!");

                        PlayAgain();
                        break;
                    }
                    else if (i > guesses4)
                    {
                        guesses4--;
                        AnswerToHigh();
                        Console.WriteLine("Du har nu " + guesses4 + " försök kvar!");

                    }
                    else if (i < guesses4)
                    {
                        guesses4--;
                        AnswerToLow();
                        Console.WriteLine("Du har nu " + guesses4 + " försök kvar!");
                    }

                } while (right == false);
            }
            catch (FormatException)
            {
                Console.WriteLine("Little bit wrong! Try with numbers!");
                Console.WriteLine();
            }



        }
    }
}
