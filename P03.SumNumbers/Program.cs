using System;

namespace P03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int secondNumber;
            while (sum < number)
            {
                secondNumber = int.Parse(Console.ReadLine());
                sum += secondNumber;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
