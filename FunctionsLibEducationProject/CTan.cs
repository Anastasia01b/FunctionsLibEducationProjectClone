using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLib
{
    public sealed class CTan:Unares
    {
		public CTan(Function a) : base(a)
		{

        }
		public override Function Diff()
		{
            return new Division(new Constant(-1), new Degree(new Sin(arg), 2));
        }
    }
}
