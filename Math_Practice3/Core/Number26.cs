using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number26
    {
        private double _y;
        private double _x;
        private double _k;

        public Number26(double y, double x, double k)
        {
            _y = y;
            _x = x;
            _k = k;
        }
        public double U()
        {
            double result = (Math.Log(Math.Pow(_x, 3) + _y) - Math.Pow(_y, 4)) / (Math.Pow(Math.E, _y) + 5.4 * Math.Pow(_k, 3));
            Console.WriteLine(result);
            return result;
        }
    }
}
