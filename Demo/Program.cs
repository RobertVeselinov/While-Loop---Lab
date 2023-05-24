using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int yearCounter = 0;
            int failsCounter = 0;
            double grade = 0;
            double sumGrade = 0;

            while (yearCounter < 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sumGrade += grade;
                }
                else
                {
                    sumGrade += grade;
                    failsCounter++;
                    if (failsCounter > 1)
                    {
                        break;
                    }
                }
                yearCounter++;

            }
            if (yearCounter == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumGrade / 12:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {yearCounter} grade");
            }
        }
    }
}
