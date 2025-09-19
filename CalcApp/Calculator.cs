

class Calculator
{
    static int Main(string[] args)
    {
        Console.WriteLine("Choose Operation: + / * -");
        string operationCode = Console.ReadLine();

        switch (operationCode)
        {
            case "+":
            case "/":
            case "*":
            case "-":
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                int num1;
                int num2;
                bool isNumeric1 = int.TryParse(input1, out num1);
                bool isNumeric2 = int.TryParse(input2, out num2);

                if (!(isNumeric1 && isNumeric2))
                {
                    Console.WriteLine("Not numeric numbers");
                    return 1;
                }

                try // result calculation
                {
                    Console.WriteLine("Result is");
                    switch (operationCode)
                    {
                        case "+":
                            Console.WriteLine(num1 + num2);
                            break;
                        case "-":
                            Console.WriteLine(num1 - num2);
                            break;
                        case "/":
                            Console.WriteLine(num1 / num2);
                            break;
                        case "*":
                            Console.WriteLine(num1 * num2);
                            break;
                        default:
                            Console.WriteLine("Invalid Operation");
                            break;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Divided By Zero");
                }
                finally
                {
                    Console.WriteLine("Finished Program");
                }
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
        return 0;

    }
}

