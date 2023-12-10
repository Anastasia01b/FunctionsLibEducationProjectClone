using System;
namespace FunctionsLib
{
    public sealed class Exp:Unares
    {
        public Exp(Function f) : base(f)
        {

        }
        public override Function Diff()
        {
            return new Multiplication(new Exp(arg), arg.Diff());
        }
    }
}
