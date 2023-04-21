using System;
using System.Diagnostics;

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

public class Circle
{
    private double radius;

    public Circle(double radius) { this.radius = radius; }

    public double CalculateDiameter()
    {
        return radius * 2;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public string CalculateFormattedCircumference()
    {
        return FormatNumber(CalculateCircumference());
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public string CalculateFormattedArea()
    {
        return FormatNumber(CalculateArea());
    }

    private string FormatNumber(double x)
    {
        return string.Format("{0:0.##}", x);
    }

    public void Grow()
    {
        SetRadius(radius * 2);
    }

    public double GetRadius() { return radius; }
    private void SetRadius(double radius) { this.radius = radius; }

}

public static class Validator
{
    /* Method to accept only a valid input */
    public static void GetNumber(ref double rad)
    {
        try
        {
            Console.Write("Enter a radius: ");
            rad = double.Parse(Console.ReadLine());
            return;
        }
        catch (FormatException e)
        {
            Console.WriteLine("Invalid input.");
            GetNumber(ref rad);
        }
    }
}