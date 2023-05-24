using System;

namespace P02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string enteredPassword = Console.ReadLine();

            while (true)
            {
                if (enteredPassword == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
                else
                {
                    enteredPassword = Console.ReadLine();
                }
            }
        }
    }
}
