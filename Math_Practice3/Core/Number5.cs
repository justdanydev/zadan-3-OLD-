using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number5
    {
        private double _x;
        private double _y;
        private double _z;
        private double _c;

        public Number5(double x, double y, double z, double c)
        {
            _x = x;
            _y = y;
            _z = z;
            _c = c;
        }
        public double G()
        {
            double result = (Math.Tan(Math.Pow(_x, 4) - 6) - Math.Cos(Math.Pow(_z + _x * _y, 3))) / (Math.Pow(Math.Cos(Math.Pow(_x, 3) * Math.Pow(_c, 2)), 4));
            Console.WriteLine(result);
            return result;
        }
    }
}
