using System;

namespace P08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clas1 = 1;
            string name = Console.ReadLine();
            double sumRate = 0;
            int fail = 0;

            while (clas1 <= 12)
            {
         
                double rate = double.Parse(Console.ReadLine());
                if (rate >= 4.00)
                {
                    sumRate += rate;
                    clas1++;
                    continue;
                }
                else if (fail == 0)
                {
                    sumRate += rate;
                    fail++;
                    clas1++;
                }
                else
                {
                    Console.WriteLine($"{name} has been excluded at {clas1-1} grade");
                    break;
                }
            }
            if (clas1 == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumRate / (clas1 - 1):f2}");
            }
        }
    }
}
