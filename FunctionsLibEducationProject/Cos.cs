using System;
namespace FunctionsLib
{
    public sealed class Cos:Unares
    {
        public Cos(Function f) : base(f)
        {
            funcPtr=(x)=>Math.Cos(x);
        }
        public override Function Diff()
        {
            return new Multiplication(new Constant(-1), new Sin(arg));
        }
    }
}