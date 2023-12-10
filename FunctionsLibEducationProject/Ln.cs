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
	    funcPtr = (x) => Math.Log(x);
	}
	public override Function Diff()
	{
	    return new Division(new Constant (1), arg);
	}
    }
}
