using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number7
    {
        private double _x;
        private double _y;
        private double _a;

        public Number7(double x, double y, double a)
        {
            _x = x;
            _y = y;
            _a = a;
        }
        public double D()
        {
            double result = (Math.Cos(Math.Pow(_x, 3) + 6) - Math.Sin(_y - _a)) / (Math.Log(Math.Pow(_x, 4)) - 2 * Math.Pow(Math.Sin(_x), 5));
            Console.WriteLine(result);
            return result;
        }
    }
}
