using System.Globalization;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fibonaccy
             int[] fibonacci = new int[10] {0,1,1,2,3,5,8,13,21,34};

            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine(fibonacci[i]);
            }


            //even number

            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }


            // multiplication
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    int result = i * j;
                    Console.WriteLine($"{i} * {j} = {result}");
                }
            }

            //password
            string password = "qwerty";
            string input;

            do
            {
                Console.WriteLine("Enter correct password:");
                input = Console.ReadLine();
            }
            while (password != input);

            Console.ReadLine("Welcome back!");

        }
    }
}