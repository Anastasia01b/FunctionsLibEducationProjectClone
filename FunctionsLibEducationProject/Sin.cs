using System;

namespace FunctionsLib
{
    public sealed class Sin : Unares
    {
        public Sin(Function f) : base(f)
        {
            funcPtr=(x)=>Math.Sin(x);
        }
        public override Function Diff()
        {
            return new Cos(arg);
        }
    }
}