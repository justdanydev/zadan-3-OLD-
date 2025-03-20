using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number3
    {
        private double _y;
        private double _h;

        public Number3(double y, double h)
        {
            _y = y;
            _h = h;
        }
        public double A()
        {
            double result = (Math.Tan(Math.Pow(_y, 3) - Math.Pow(_h, 4)) + Math.Pow(_h, 2)) / (Math.Sin(Math.Pow(_h, 3)) + _y);
            Console.WriteLine(result);
            return result;
        }
    }
}
