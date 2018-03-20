using System;

namespace Lab01_phil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a guessing game about me!!");
            Console.WriteLine("Press enter to continue!");
            Console.ReadLine();
            PlaySoccer();
            GuessNumber();
            StatesLived();
            DogOrCat();
            Jameson();
        }

        static string PlaySoccer()
        {
            Console.WriteLine("Do I play competitive Soccer?");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y" || answer == "YES")
            {
                Console.WriteLine("You are correct!");
                Console.ReadLine();
            }
            else if (answer == "N" || answer == "NO")
            {
                Console.WriteLine("I am sorry but I do.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I am sorry but I don't understand what you said.");
                Console.ReadLine();
            }

            return answer;
        }

        static void GuessNumber()
        {
            int guesses = 3;
            do
            {
                try
                {
                    Console.WriteLine("Guess my favorite number, it's between 1 and 20.");
                    Console.WriteLine($"You will have {guesses} guesses.");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 16)
                    {
                        Console.WriteLine("Awesome job!");
                        guesses = -1;
                    }
                    else if (answer < 16)
                    {
                        guesses--;
                        Console.WriteLine($"Sorry my number is higher than that, you have {guesses} guesses left.");
                    }
                    else if (answer > 16)
                    {
                        guesses--;
                        Console.WriteLine($"Sorry my number is lower than that, you have {guesses} guesses left.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            } while (guesses > 0);
        }

        static void StatesLived()
        {
            int answer;
            Console.WriteLine("How many states have I lived in?");
            try
            {
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 6)
                {
                    Console.WriteLine("Yes! I have lived in Indiana, Arizona, California, Georgia, North Carolina and Washington.");
                    Console.ReadLine();
                }
                else if (answer != 6)
                {
                    Console.WriteLine("I am sorry I have lived in 6: Indiana, Arizona, California, Georgia, North Carolina and Washington.");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("You are doing great!");
            }

        }

        static string DogOrCat()
        {
            Console.WriteLine("Do I own more cats or dogs?");
            string answer = Console.ReadLine().ToLower();
                
            if (answer == "cats")
            {
                Console.WriteLine("That is correct!");
                Console.ReadLine();
                return answer;
            }
            else
            {
                Console.WriteLine("No, I own more cats.");
                Console.ReadLine();
                return answer;
            }

        }

        static string Jameson()
        {
            Console.WriteLine("Do I enjoy a nice glass of Jameson?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "y")
            {
                Console.WriteLine("I always do!");
                Console.ReadLine();
                return answer;
            }
            else if (answer == "no" || answer == "n")
            {
                Console.WriteLine("Sorry but I do enjoy a nice glass of Jameson.");
                Console.ReadLine();
                return answer;
            }
            else
            {
                Console.WriteLine("This was a yes or no question.....");
                return answer;
            }
        }
    }
}
