using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number4
    {
        private double _y;
        private double _x;

        public Number4(double y, double x)
        {
            _y = y;
            _x = x;
        }
        public double F()
        {
            double result = (Math.Sqrt(Math.Pow((2 + _y), 2) + Math.Pow(Math.Sqrt(Math.Sin(_y + 5)), 7))) / (Math.Log(_x + 1) - Math.Pow(_y, 3));
            Console.WriteLine(result);
            return result;
        }
    }
}
