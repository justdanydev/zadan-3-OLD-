using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number16
    {
        private double _x;
        private double _y;
        private double _t;

        public Number16(double x, double y, double t)
        {
            _x = x;
            _y = y;
            _t = t;
        }
        public double P()
        {
            double result = (Math.Pow(Math.Sin(_x), 3) + Math.Log(2 * _y + 3 * _x)) / (Math.Pow(_t, Math.E) + Math.Sqrt(_x));
            Console.WriteLine(result);
            return result;
        }
    }
}
