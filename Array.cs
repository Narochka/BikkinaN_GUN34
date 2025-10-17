
namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Задание 1
            int[] fibonacci = new int[8] {0,1,1,2,3,5,8,13};


            // Задание 2
            string[] months = new string[12]{"January","February","March","April","May","June","July","August","September","October","November","December"};


            // Задание 3
            int[,] matrix = new int[3,3]{
                {2,3,4},
                {4,9,16},
                {8,27,64}
                };


            // Задание 4
            double[][] jagged = new double[3][];   
            jagged[0] = new double[5]{1,2,3,4,5};
            jagged[1] = new double[2]{Math.PI,Math.E};
            jagged[2] = new double[]
            {
                Math.Log10(1),
                Math.Log10(10),
                Math.Log10(100),
                Math.Log10(1000)
            };

            // массивы для задания 5-6
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };


            // Задание 5
            Array.Copy(array, 0, array2, 0, 3);
            Console.WriteLine(array2);
            
            // Задание 6
            Array.Resize(ref array, array.Length * 2);
            Console.WriteLine(array);
        }

    }
}