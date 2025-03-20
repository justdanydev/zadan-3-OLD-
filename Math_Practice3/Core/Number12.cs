using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number12
    {
        private double _y;
        private double _x;
        private double _a;

        public Number12(double y, double x, double a)
        {
            _y = y;
            _x = x;
            _a = a;
        }
        public double G()
        {
            double result = (Math.Pow(Math.Cos(Math.Abs(_y + _x)), 3) - (_x + _y)) / (Math.Pow(Math.Atan(_x + _a), 4) * Math.Pow(_x, 5));
            Console.WriteLine(result);
            return result;
        }
    }
}
