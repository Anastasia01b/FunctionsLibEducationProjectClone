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
            return LeftArg.Calc(x) / RightArg.Calc(x);
        }
            

        public override Function Diff()
        {
            if (LeftArg is Constant)
                return new Multiplication(LeftArg, new Multiplication(new Constant(-1), new Degree(RightArg, -2)));
            if (RightArg is Constant)
                return new Division(LeftArg.Diff(), RightArg);
            if ((LeftArg is Constant && RightArg is Constant) || (LeftArg is Argument && RightArg is Argument))
                return new Constant(0);
            return new Division(new Subtraction(new Multiplication(LeftArg.Diff(), RightArg), new Multiplication(RightArg.Diff(), LeftArg)), new Degree(RightArg, 2));
        }
    }
}
