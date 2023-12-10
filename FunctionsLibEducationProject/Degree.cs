using System;

namespace FunctionsLib
{
    public sealed class Degree : Unares
    {
        private int degree;

        public Degree(Function f, int degree) : base(f)
        {
            this.degree = degree;
        }

        public override string ToString()
        {
            return $"({arg.ToString()})^({degree})"; 
        }

        public override Function Diff()
        {
            return new Multiplication(new Constant(degree),new Degree(arg, (degree-1)));
        }
    }
}


