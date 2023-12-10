using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLib
{
	public sealed class Tan : Unares
	{
		public Tan(Function a) : base(a)
		{
            funcPtr=(x)=>Math.Tan(x);
		}
		public override Function Diff()
		{
			return new Division(new Constant(1), new Degree(new Cos(arg),2));
		}
    }
}
