using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number19
    {
        private double _K;
        private double _a;
        private double _b;
        private double _y;
        private double _x;

        public Number19(double K, double a, double b, double y, double x)
        {
            _K = K;
            _a = a;
            _b = b;
            _y = y;
            _x = x;
        }
        public double D()
        {
            double result = (Math.Pow(_K, -_a*_y*_x) -_a * Math.Sqrt(6) - Math.Cos(3 * _a * _b)) / (Math.Pow(Math.Sin(_a * Math.Asin(_x) + Math.Log(_y)), 2));
            Console.WriteLine(result);
            return result;
        }
    }
}
