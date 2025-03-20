using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number30
    {
        private double _x;

        public Number30(double x)
        {
            _x = x;
        }
        public double K()
        {
            double result = (Math.Sqrt(Math.Pow(3 + _x, 6) - Math.Log(_x))) / (Math.Pow(Math.E, 0) + Math.Asin(6 * Math.Pow(_x, 2)));
            Console.WriteLine(result);
            return result;
        }
    }
}
