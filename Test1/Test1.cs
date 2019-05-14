using System;

namespace Test1
{
    internal static class Test1
    {
        private static void Main()
        {
            try
            {
                Console.WriteLine("Please enter radius");
                double.TryParse(Console.ReadLine(), out double radius);

                Assert(radius > 0, $"Radius should be more 0. Current value - {radius}");

                Console.WriteLine("Circle square - {0:F}", CircleSquare(radius));

                Console.WriteLine("Please enter side length");
                double.TryParse(Console.ReadLine(), out double sideLength);


                Assert(sideLength > 0, $"Side length should be more 0. Current value - {sideLength}");

                Console.WriteLine("Square square - {0:F}", SquareSquare(sideLength));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            
        }

        private static void Assert(bool value, string message)
        {
            if (!value)
            {
                throw new Exception(message);
            }
        }

        private static double CircleSquare(double radius)
        {
            return Math.PI * radius * radius;
        }

        private static double SquareSquare(double sideLength)
        {
            return sideLength * sideLength;
        }
    }
}