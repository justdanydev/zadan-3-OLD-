using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number9
    {
        private double _y;
        private double _x;
        private double _d;

        public Number9(double y, double x, double d)
        {
            _y = y;
            _x = x;
            _d = d;
        }
        public double R()
        {
            double result = (Math.Pow(Math.Cos(_y), 3) + Math.Pow(2, _x) * _d) / (Math.Pow(Math.E, _y) + Math.Log(Math.Pow(Math.Sin(_x), 2) + 7.4));
            Console.WriteLine(result);
            return result;
        }
    }
}
