// See https://aka.ms/new-console-template for more information


// Simple ATM program 
class Program
{
    public static Random random = new Random();
    static void Main()
    {
        double balance = GenerateRandomBalance();
        bool isATMRunning = true;

        while (isATMRunning)
        {
            Console.WriteLine("ATM Options");
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("0. Exit");

            string opCode = Console.ReadLine();

            switch (opCode)
            {
                case "1":
                    Console.WriteLine($"Balance is: {balance}");
                    break;
                case "2":
                    Console.WriteLine("Enter deposit amount:");
                    string depositInput = Console.ReadLine();
                    double depositAmount;
                    if (!ValidateInputForAmount(depositInput))
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    {
                        depositAmount = double.Parse(depositInput);
                        balance = Deposit(balance, depositAmount);
                    }
                    break;  
                case "3":
                    Console.WriteLine("Enter withdraw amount:");
                    string withdrawInput = Console.ReadLine();
                    double withdrawAmount;
                    if (!ValidateInputForAmount(withdrawInput))
                    {
                        Console.WriteLine("Invalid Input");
                        
                    } else
                    {
                        withdrawAmount = double.Parse(withdrawInput);
                        balance = Withdraw(balance, withdrawAmount);
                    }
                    break;
                case "0":
                    isATMRunning = false;
                    break;
            }


        }


    }


    static double GenerateRandomBalance()
    {
        return random.Next(0, 1500);
    }

    static double Deposit(double balance, double amount)
    {
        return balance + amount;
    }

    static double Withdraw(double balance, double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Withdraw Amount is greather than balance");
            return balance;
        }
        return balance - amount;
    }

    static bool ValidateInputForAmount(string input)
    {
        try
        {
            double.Parse(input);
            return true;
        }
        catch (FormatException e)
        {
            return false;
        }
    }


}