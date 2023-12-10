using System;
using System.Reflection.Metadata;

namespace FunctionsLib
{
    public sealed class Constant:Function
    {
        private double value;
        public Constant(double val)
        {
            value = val;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override double Calc(double x)
        {
            return value;
        }

        public override Function Diff()
        {
            return new Constant(0);
        }
    }
}