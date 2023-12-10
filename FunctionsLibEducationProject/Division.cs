using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLib
{
    /// <summary>
    /// Implements division operation as Binares Function
    /// </summary>
    public sealed class Division : Binares
    {
        public Division(Function l, Function r) : base(l, r)
        {

        }

        public override double Calc(double x)
        {
            if (Math.Abs(RightArg.Calc(x)) < double.Epsilon)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return LeftArg.Calc(x) / RightArg.Calc(x);
        }

        public override Function Diff()
        {
            Function leftDiff = LeftArg.Diff();
            Function rightDiff = RightArg.Diff();

            Function numeratorOne = new Multiplication(leftDiff, RightArg);
            Function numeratorTwo = new Multiplication(LeftArg, rightDiff);
            Function numerator = new Subtraction(numeratorOne, numeratorTwo);

            Function denominator = new Multiplication(RightArg, RightArg);

            return new Division(numerator, denominator);
        }
    }
}