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
                Console.WriteLine(circle.ToString());
            } while (Continue(ref circle));

            Console.WriteLine($"Goodbye. The circle's final radius is {circle.GetRadius()}.");
        }

        static bool Continue(ref Circle circle)
        {
            Console.Write("\nShould the circle grow? (y/n): ");
            string prompt = Console.ReadLine();
            if (prompt.ToLower() == "y")
            {
                Console.WriteLine("The circle is magically growing.\n");
                circle.Grow();
                return true;
            }
            else if (prompt.ToLower() == "n")
                return false;
            else
                return Continue(ref circle);
        }
    }
}