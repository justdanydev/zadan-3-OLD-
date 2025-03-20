using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number11
    {
        private double _y;
        private double _x;

        public Number11(double y, double x)
        {
            _y = y;
            _x = x;
        }
        public double I()
        {
            double result = (2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(_y), 2)))) / (Math.Pow(Math.E, _y) + Math.Pow(Math.Sin(_x), 2));
            Console.WriteLine(result);
            return result;
        }
    }
}
