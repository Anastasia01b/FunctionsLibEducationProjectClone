using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLib
{
	/// <summary>
	/// Implements substraction operation as Binares Function
	/// </summary>
	public sealed class Subtraction:Binares
    {
		public Subtraction(Function l, Function r) : base(l, r)
		{
            funcPtr = (x, y) => x - y;
        }
        public override Function Diff() 
        {
           return new Constant(new Subtraction(LeftArg.Diff(), RightArg.Diff()).Calc(0));
        }
        public override double Calc(double x) => LeftArg.Calc(x) - RightArg.Calc(x);
    }
}
