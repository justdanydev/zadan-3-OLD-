using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number25
    {
        private double _a;
        private double _x;
        private double _y;

        public Number25(double a, double x, double y)
        {
            _a = a;
            _x = x;
            _y = y;
        }
        public double J()
        {
            double result = (Math.Pow(Math.Cos(Math.Pow(_a,3))/Math.Sin(Math.Pow(_a,3)), 3) + Math.Pow(Math.Atan(_a), 2)) / (Math.Sqrt(Math.Pow(_y, Math.Tan(_x))));
            Console.WriteLine(result);
            return result;
        }
    }
}
