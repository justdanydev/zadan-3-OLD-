using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number14
    {
        private double _x;

        public Number14(double x)
        {
            _x = x;
        }
        public double R()
        {
            double result = (Math.Sin(Math.Pow((Math.Pow(_x, 2) + 4), 3) + 4.3)) / (Math.Pow(Math.Sin(Math.Pow(_x, 4)), 3));
            Console.WriteLine(result);
            return result;
        }
    }
}
