using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number10
    {
        private double _x;
        private double _y;

        public Number10(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public double U()
        {
            double result = (Math.Pow(Math.E, Math.Pow(_x, 3)) + Math.Pow(Math.Cos(_x -4), 2)) / (Math.Atan(_x) + 5.2 * _y);
            Console.WriteLine(result);
            return result;
        }
    }
}
