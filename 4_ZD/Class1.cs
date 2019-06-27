using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ZD
{
    public class Program
    {
        public static void Main()
        {
            List<Point> points = new List<Point> {
            new Point(0, -10),
            new Point(6, -9),
            new Point(10, -3),
            new Point(10, 3),
            new Point(6, 9),
            new Point(0, 10),
            new Point(-6, 9),
            new Point(-10, 3),
            new Point(-10, -3),
            new Point(-6, -9),
        };
            double perimeter = 0;
            for (int i = 0; i < points.Count - 1; i++)
            {
                perimeter += points[i].RangeeTo(points[i + 1]);
            }
            perimeter += points[points.Count - 1].RangeeTo(points[0]);
            Console.Write("Периметр = ");
            perimeter = Math.Round(perimeter, 0);
            Console.WriteLine(perimeter);

            Console.ReadKey();
        }
    }
}