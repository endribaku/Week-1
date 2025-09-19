

class Program
{
    static void Main()
    {
        Console.WriteLine("Check if a number is prime, Yes or No");
        string operation = Console.ReadLine().ToUpper();

        switch (operation)
        {
            case "YES":
                try
                {
                    Console.WriteLine("Type a number to see if it is prime or not:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (CheckNumberIfPrime(number)) {
                        Console.WriteLine("Number is Prime");
                    }
                    else
                    {
                        Console.WriteLine("Number is not Prime");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Input is not recognized as Integer");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Input Integer is either too large or too small");
                }
                finally
                {
                    Console.WriteLine("Program ended");
                }
                break;
            case "NO":
                Console.WriteLine("Ok.");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    public static bool CheckNumberIfPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true; // 2 is prime so no need to go to loop
        if (number % 2 == 0) return false; // even numbers are not prime, those greater than 2 since they would be able to be divided by 2 

        for (int i = 3; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}




