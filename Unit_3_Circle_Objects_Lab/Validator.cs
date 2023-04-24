using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3_Circle_Objects_Lab
{
    internal static class Validator
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
}
