using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number22
    {
        private double _x;
        private double _y;

        public Number22(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public double F()
        {
            double result = Math.Cos(Math.Pow(_x, 2) + 2) + (3.5 * Math.Pow(_x, 2) + 1) / (Math.Pow(Math.Cos(_y), 2));
            Console.WriteLine(result);
            return result;
        }
    }
}
