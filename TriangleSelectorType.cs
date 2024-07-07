using System;

class TriangleSelectorType
{
    static void Main()
    {
        Console.WriteLine("Enter the first length: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the the second length: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the the third length: ");
        double side3 = double.Parse(Console.ReadLine());

        string theTriangleType = GetTriangleType(side1, side2, side3);

        Console.WriteLine("This is an " + theTriangleType + " Triangle");
    }

    static string GetTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}
