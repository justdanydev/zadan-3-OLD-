﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number23
    {
        private double _x;
        private double _z;
        private double _a;
        private double _b;

        public Number23(double x, double z, double a, double b)
        {
            _x = x;
            _z = z;
            _a = a;
            _b = b;
        }
        public double F()
        {
            double result = (Math.Sqrt(Math.Abs(_x) + Math.Pow(Math.Cos(_x), 3) + Math.Pow(_z, 4))) / (Math.Log(_x) - Math.Asin(_b * _x - _a));
            Console.WriteLine(result);
            return result;
        }
    }
}
