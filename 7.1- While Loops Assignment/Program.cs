namespace _7._1__While_Loops_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Naika

            Console.Title = "Naika's 7.1 While Loops Assignment";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Welcome to the user input Assignment! Please follow the instructions and enter the requested information. Thanks!");
            Console.WriteLine();

            Console.Write("Hey user, please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Hey " + name + "!");
            Console.WriteLine();

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();

            //Simple Casino Game

            int points = 3;
            Random rand = new Random();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome to the Coin Flip Casino Game!");

            while (points > 0)
            {
                Console.WriteLine("\nYou have " + points + " points.");
                Console.Write("Choose 'heads', 'tails', or 'quit': ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "quit")
                {
                    Console.WriteLine("Thanks for playing! You finished with " + points + " points.");
                    break;
                }

                if (choice != "heads" && choice != "tails")
                {
                    Console.WriteLine("Invalid choice. Please type 'heads', 'tails', or 'quit'.");
                    continue;
                }

                // Flip the coin
                int flip = rand.Next(2); // 0 or 1
                string result = (flip == 0) ? "heads" : "tails";

                Console.WriteLine("The coin landed on: " + result);

                if (choice == result)
                {
                    points++;
                    Console.WriteLine("You guessed correctly! You gain 1 point.");
                }
                else
                {
                    points--;
                    Console.WriteLine("Wrong guess! You lose 1 point.");
                }
            }

            if (points == 0)
            {
                Console.WriteLine("You ran out of points. Game over!");
            }


        }
    }
}
