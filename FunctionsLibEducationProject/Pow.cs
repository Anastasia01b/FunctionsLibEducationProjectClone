using System;

namespace FunctionsLib
{
    public sealed class Pow : Unares
    {
        private double a;

        public Pow(double v, Function arg) : base(arg)
        {
            a = v;
        }

        public override Function Diff()
        {
            return new Multiplication(new Pow(a, arg), new Ln(new Constant(a)));
        }

        public override string ToString()
        {
            return $"{a}^({arg.ToString()})";
        }
    }
}

