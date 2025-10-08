using System.Diagnostics;

class CalculatorProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Error! Not a number!");
            return;
        }

        Console.Write("Enter second number: ");
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Error! Not a number!");
            return;
        }

        Console.Write("Enter operator (& | ^): ");
        var s = Console.ReadLine();
        if (string.IsNullOrEmpty(s))
        {
            Console.WriteLine("Error!");
            return;
        }

        int result = 0;

        switch (s[0])
        {
            case '&':
            result = a & b;
                Console.WriteLine($"Result of {a} & {b} = {result}");
                break;
            case '|':
                result = a | b;
                Console.WriteLine($"Result of {a} | {b} = {result}");
                break;
            case '^':
                result = a ^ b;
                Console.WriteLine($"Result of {a} ^ {b} = {result}");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }

        Console.WriteLine("\nResult:");
        Console.WriteLine($"Decimal: {result}");
        Console.WriteLine($"Binary: {Convert.ToString(result, 2)}");
        Console.WriteLine($"Hexadecimal: {Convert.ToString(result, 16).ToUpper()}");
    
    }
}




   
        
