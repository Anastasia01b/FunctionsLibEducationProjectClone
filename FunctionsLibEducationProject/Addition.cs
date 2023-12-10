using System;
namespace FunctionsLib
{
    /// <summary>
    /// Implements addition operation as Binares Function
    /// </summary>
    public sealed class Addition:Binares
    {
        public Addition(Function l, Function r) : base(l, r)
        {

        }

        public override double Calc(double x)
        {
            return LeftArg.Calc(x) + RightArg.Calc(x);
        }

        public override Function Diff()
        {
            Function leftDiff = LeftArg.Diff();
            Function rightDiff = RightArg.Diff();

            if (RightArg is Constant)
            {
                return leftDiff;
            }

            return new Addition(leftDiff, rightDiff);
        }

    }
}