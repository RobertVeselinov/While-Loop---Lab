﻿using System;

namespace P06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double maxNumber = double.MinValue;


            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine($"{maxNumber}");
        }
    }
}
