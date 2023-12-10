using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLib
{
	public sealed class Ln : Unares
	{ 
        public Ln(Function arg) : base(arg)
        {

		}
		public override Function Diff()
		{
			return new Division(new Constant (1), arg);
		}
        
        public override double Calc(double x)
        {
            if (funcPtr == null)
            {
                throw new InvalidOperationException("Function pointer not set.");
            }

            return funcPtr(arg.Calc(x));
        }
    }
}
