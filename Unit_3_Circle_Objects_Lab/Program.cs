using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Circle Tester!");
        List<Circle> circleList = new List<Circle>();

        do
        {
            double rad = 0;
            Validator.GetNumber(ref rad); // Receive user input

            /* Make a circle object and output calculations */
            Circle newCircle = new Circle(rad);
            Console.WriteLine($"Circumference:\t{newCircle.CalculateFormattedCircumference()}");
            Console.WriteLine($"Area:\t\t{newCircle.CalculateFormattedArea()}");
            circleList.Add(newCircle);
        } while (Continue());

        Console.WriteLine($"Goodbye. You created {circleList.Count} Circle object(s).");
    }
    
    /* Method to continue loop while the user inputs "y" */
    static bool Continue()
    {
        Console.Write("Continue? (y/n): ");
        string prompt = Console.ReadLine();
        if (prompt.ToLower() == "y")
            return true;
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

    public double GetRadius() { return radius; }
    public void SetRadius(double radius) { this.radius = radius; }

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