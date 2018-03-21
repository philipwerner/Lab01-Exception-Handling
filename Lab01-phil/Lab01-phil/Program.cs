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
            int q1 = PlaySoccer();
            int q2 = GuessNumber();
            int q3 = StatesLived();
            int q4 = DogOrCat();
            int q5 = Jameson();
            EndGame(q1, q2, q3, q4, q5);
        }

        static int PlaySoccer()
        {
            Console.WriteLine("Do I play competitive Soccer?");
            string answer = Console.ReadLine().ToUpper();
            int points;

            if (answer == "Y" || answer == "YES")
            {
                Console.WriteLine("You are correct!");
                Console.ReadLine();
                points = 1;
            }
            else if (answer == "N" || answer == "NO")
            {
                Console.WriteLine("I am sorry but I do.");
                Console.ReadLine();
                points = 0;
            }
            else
            {
                Console.WriteLine("I am sorry but I don't understand what you said.");
                Console.ReadLine();
                points = 0;
            }

            return points;
        }

        static int GuessNumber()
        {
            int guesses = 3;
            int points = 0;
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
                        points = 1;
                        guesses = -1;
                        return points;
                    }
                    else if (answer < 16)
                    {
                        guesses--;
                        Console.WriteLine($"Sorry my number is higher than that, you have {guesses} guesses left.");
                        return points;
                        
                    }
                    else if (answer > 16)
                    {
                        guesses--;
                        Console.WriteLine($"Sorry my number is lower than that, you have {guesses} guesses left.");
                        return points;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    return points;
                }
            } while (guesses > 0);
            if (guesses <= 0)
            {
                Console.WriteLine("You have no more guesses.");
                return points;
            }
            return points;
        }

        static int StatesLived()
        {
            int answer;
            int points = 0;
            Console.WriteLine("How many states have I lived in?");
            try
            {
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 6)
                {
                    Console.WriteLine("Yes! I have lived in Indiana, Arizona, California, Georgia, North Carolina and Washington.");
                    points = 1;
                    return points;
                }
                else if (answer != 6)
                {
                    Console.WriteLine("I am sorry I have lived in 6: Indiana, Arizona, California, Georgia, North Carolina and Washington.");
                    return points;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                throw;
            }
            finally
            {
                Console.WriteLine("You are doing great!");
            }
            return points;

        }

        static int DogOrCat()
        {
            int points = 0;
            Console.WriteLine("Do I own more cats or dogs?");
            string answer = Console.ReadLine().ToLower();
                
            if (answer == "cats")
            {
                Console.WriteLine("That is correct!");
                points = 1;
                return points;
            }
            else
            {
                Console.WriteLine("No, I own more cats.");
                return points;
            }

        }

        static int Jameson()
        {
            int points = 0;
            Console.WriteLine("Do I enjoy a nice glass of Jameson?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "y")
            {
                Console.WriteLine("I always do!");
                points = 1;
                return points;
            }
            else if (answer == "no" || answer == "n")
            {
                Console.WriteLine("Sorry but I do enjoy a nice glass of Jameson.");
                return points;
            }
            else
            {
                Console.WriteLine("This was a yes or no question.....");
                return points;
            }
        }

        static void EndGame(int a, int b, int c, int d, int e)
        {
            int total = a + b + c + d + e;
            Console.WriteLine($"You answered {total} out of 5 correctly!");
            Console.WriteLine("Press enter to leave the game.");
            Console.ReadLine();
        }
    }
}
