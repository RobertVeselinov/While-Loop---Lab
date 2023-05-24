using System;

namespace P05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double deposit = 0;
            double total = 0;

            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                deposit = double.Parse(input);
                if (deposit > 0)
                {
                    Console.WriteLine($"Increase: {deposit:f2}");
                    total += deposit;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
                Console.WriteLine($"Total: {total:f2}");
        }
    }
}
