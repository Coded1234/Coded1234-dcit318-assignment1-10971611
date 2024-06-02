using System;

namespace DCIT318Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeCalculator();
            Console.ReadLine();
        }

        static void GradeCalculator()
        {
            Console.Write("Enter a numerical score: ");
            int grade = int.Parse(Console.ReadLine());

            string letterGrade;

            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }
    }
}