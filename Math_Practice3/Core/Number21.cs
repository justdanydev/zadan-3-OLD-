using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number21
    {
        private double _z;
        private double _x;
        private double _a;

        public Number21(double z, double x, double a)
        {
            _z = z;
            _x = x;
            _a = a;
        }
        public double N()
        {
            double result = (Math.Pow(Math.Sqrt(_z + Math.Sqrt(_z * _x)), 5)) / (Math.Pow(Math.E, _x) + Math.Pow(_a, 5) * Math.Atan(_x));
            Console.WriteLine(result);
            return result;
        }
    }
}
