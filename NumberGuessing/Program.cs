// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);
        bool hasGuessed = false;
        int numOfAttempts = 0;

        while (!hasGuessed)
        {
            try
            {
                Console.WriteLine("Generate a random number between 1 and 100");
                string input = Console.ReadLine();
                int playerNumber = int.Parse(input);
                numOfAttempts++;

                if (playerNumber < 1 || playerNumber > 100)
                {
                    Console.WriteLine("The number entered is not between 1 and 100");
                    continue;
                }

                if (playerNumber > randomNumber)
                {
                    Console.WriteLine("Too High");
                }
                else if (playerNumber < randomNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("You found it at " + numOfAttempts + " attempts");
                    hasGuessed = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number entered is too large or too small for an integer.");
            }
        }
    }
}
