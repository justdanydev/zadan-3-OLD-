using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number24
    {
        private double _b;
        private double _x;
        private double _z;
        private double _a;

        public Number24(double b, double x, double z, double a)
        {
            _b = b;
            _x = x;
            _z = z;
            _a = a;
        }   
        public double F()
        {
            double result = (Math.Pow(Math.Cos(_b * Math.Pow(_x, 5)), 7) - (Math.Sin(Math.Pow(_a, 2)) + Math.Cos(Math.Pow(_x , 3) + Math.Pow(_z, 5) - Math.Pow(_a,2)))) / (Math.Asin(Math.Pow(_a, 2)) + Math.Acos(Math.Pow(_x, 7) - Math.Pow(_a, 2)));
            Console.WriteLine(result);
            return result;
        }
    }
}
