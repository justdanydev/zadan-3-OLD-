using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number18
    {
        private double _y;
        private double _t;

        public Number18(double y, double t)
        {
            _y = y;
            _t = t;
        }
        public double S()
        {
            double result = (4.351 * Math.Pow(_y, 3) + 2 * _t * Math.Log(_t)) / (Math.Sqrt(Math.Cos(2 * _y) + 4.351));
            Console.WriteLine(result);
            return result;
        }
    }
}
