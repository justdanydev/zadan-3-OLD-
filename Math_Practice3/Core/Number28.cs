using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number28
    {
        private double _x;
        private double _y;
        private double _z;
        private double _c;

        public Number28(double x, double y, double z, double c)
        {
            _x = x;
            _y = y;
            _z = z;
            _c = c;
        }
        public double G()
        {
            double result = (Math.Tan(Math.Pow(_x, 4) - 6) - Math.Pow(Math.Cos(_z + Math.Pow(_x, 3) * _y), 3*_x)) / (Math.Pow(Math.Cos(Math.Pow(_x, 3) * Math.Pow(_c, 2)), 2));
            Console.WriteLine(result);
            return result;
        }
    }
}
