using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3_Circle_Objects_Lab
{
    internal class Circle
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

        public override string ToString()
        {
            string output = "";
            output += "Radius:\t\t" + radius + "\n";
            output += "Diameter:\t" + CalculateDiameter() + "\n";
            output += "Circumference:\t" + CalculateFormattedCircumference() + "\n";
            output += "Area:\t\t" + CalculateFormattedArea();
            return output;
        }

        public double GetRadius() { return radius; }
        private void SetRadius(double radius) { this.radius = radius; }
    }
}
