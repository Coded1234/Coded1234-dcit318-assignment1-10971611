using System;
namespace dcit318assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleTypeIdentifier();
            Console.ReadLine();
        }
        static void TriangleTypeIdentifier()
        {
            Console.Write("Enter Length of first side : ");
            double size1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Length of first side : ");
            double size2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Length of first side : ");
            double size3 = double.Parse(Console.ReadLine());

            string triangleType;

            if (size1 == size2 && size2 == size3)
            {
                triangleType = "Equilateral Triangle";
            }

            else if (size1 == size2 || size1 == size3 || size2 == size3)
            {
                triangleType = "Isosceles Triangle";
            }

            else
            {
                triangleType = "Scalene Triangle";
            }
            Console.WriteLine($"The triangle type is : {triangleType}");
        }


    }
}
