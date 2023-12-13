using System;

namespace FunctionsLib
{
    /// <summary>
    /// Implements multiplication operation as Binares Function
    /// </summary>
    public sealed class Multiplication : Binares
    {
        public Multiplication(Function l, Function r) : base(l, r)
        {
            funcPtr = (x, y) => x * y;
        }
        public override double Calc(double x) => LeftArg.Calc(x) * RightArg.Calc(x);
        public override Function Diff()
        {
            if (LeftArg is Constant && RightArg is Argument)
            {
                return new Multiplication(LeftArg, RightArg.Diff());
            }
            else if (RightArg is Constant && LeftArg is Argument)
            {
                return new Multiplication(RightArg, LeftArg.Diff());
            }
            else
            { 
                Function leftDiff = LeftArg.Diff();
                Function rightDiff = RightArg.Diff();
                return new Addition(new Multiplication(leftDiff, RightArg), new Multiplication(LeftArg, rightDiff));
            }
        }
    }
}

