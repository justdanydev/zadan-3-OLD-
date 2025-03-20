using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number17
    {
        private double _x;
        private double _y;
        private double _b;
        private double _a;

        public Number17(double x, double y, double b, double a)
        {
            _x = x;
            _y = y;
            _b = b;
            _a = a;
        }
        public double T()
        {
            double result = (Math.Sqrt(_x + _b - _a) + Math.Log(_y)) / (Math.Atan(_a + _b));
            Console.WriteLine(result);
            return result;
        }
    }
}
