using System;
namespace FunctionsLib
{
    public sealed class Exp:Unares
    {
        public Exp(Function f) : base(f)
        {
            funcPtr = (x) => Math.Exp(x);
        }
        public override Function Diff()
        {
            if (arg is Argument)
                return this;
            return new Multiplication(this, arg.Diff());
        }
        
    }
}
