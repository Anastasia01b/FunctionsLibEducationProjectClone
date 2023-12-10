using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsLib
{
    public sealed class Sqrt : Unares
    {
        public Sqrt(Function f) : base(f)
        {
            funcPtr = (x) => Math.Sqrt(x);

        }
        public override Function Diff()
        {
            return new Multiplication(new Constant(0.5), new Division(arg.Diff(), new Multiplication(new Constant(2), new Sqrt(arg))));
        }
    }
}
