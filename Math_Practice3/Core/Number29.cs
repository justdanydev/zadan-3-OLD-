using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number29
    {
        private double _y;
        private double _x;
        private double _d;

        public Number29(double y, double x, double d)
        {
            _y = y;
            _x = x;
            _d = d;
        }
        public double R()
        {
            double result = (Math.Pow(Math.Cos(_y), 2) + 2.4 * _d) / (Math.Pow(Math.E, _y) + Math.Log(Math.Pow(Math.Sin(_x), 2) + 6));
            Console.WriteLine(result);
            return result;
        }
    }
}
