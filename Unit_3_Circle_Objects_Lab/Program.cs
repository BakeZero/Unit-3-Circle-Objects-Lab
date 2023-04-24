using System;
using System.Diagnostics;

namespace Unit_3_Circle_Objects_Lab
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Circle Tester!");
            double rad = 0;
            Validator.GetNumber(ref rad);
            Circle circle = new Circle(rad);

            do
            {
                Console.WriteLine($"Diameter:\t{circle.CalculateDiameter()}");
                Console.WriteLine($"Circumference:\t{circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area:\t\t{circle.CalculateFormattedArea()}");
                circle.Grow();
            } while (Continue());

            Console.WriteLine($"Goodbye. The circle's final radius is {circle.GetRadius()}.");
        }

        static bool Continue()
        {
            Console.Write("\nShould the circle grow? (y/n): ");
            string prompt = Console.ReadLine();
            if (prompt.ToLower() == "y")
            {
                Console.WriteLine("The circle is magically growing.\n");
                return true;
            }
            else if (prompt.ToLower() == "n")
                return false;
            else
                return Continue();
        }
    }
}