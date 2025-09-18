

class Calculator
{
    static int Main(string[] args)
    {
        char[] operations = { '+', '/', '*', '-' };
        Console.WriteLine("Choose Operation: + / * -");
        int operationCode = Console.Read();
        char inputOp = (char) operationCode;

        bool operationExists = Array.Exists<Char>(operations, op => op == inputOp);

        if (!operationExists) {
            Console.WriteLine("invalid operation");
            return 1;
        }

        
    
        string cleanup = Console.ReadLine();    // reading char input problem cleanup


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
            switch (inputOp)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                case '*':
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
        


        return 0;

    }
}

