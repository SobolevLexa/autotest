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
                
                var circle = new Circle(radius);
                    

                Console.WriteLine("Circle square - {0:F}", circle);

                Console.WriteLine("Please enter side length");
                double.TryParse(Console.ReadLine(), out double sideLength);
                
                Assert(sideLength > 0, $"Side length should be more 0. Current value - {sideLength}");

                var square = new Square(sideLength);

                Console.WriteLine("Square square - {0:F}", square);
                
                
                Console.WriteLine($"Square contains circle is {square.Contains(circle)}");
                Console.WriteLine($"Circle contains square is {circle.Contains(square)}");
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
    }
}