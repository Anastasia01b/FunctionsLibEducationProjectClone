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
            return new Subtraction(LeftArg.Diff(), RightArg.Diff());
        }
        public override string ToString()
        {
            string leftArgString = LeftArg.ToString();
            string rightArgString = RightArg.ToString();
            if (RightArg is Constant && Math.Abs(RightArg.Calc(0)) < double.Epsilon)
            {
                return leftArgString; 
            }
            else
            {
                return $"{leftArgString}-{rightArgString}";
            }
        }
    }
}
