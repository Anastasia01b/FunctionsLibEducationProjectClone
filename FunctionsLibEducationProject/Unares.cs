using System;

namespace FunctionsLib
{
    /// <summary>
    /// Implements all common operations for unares Functions and operators: F(G(x))
    /// </summary>
    public abstract class Unares:Function
    {
        protected Function arg;
        protected Func<double, double> funcPtr;
        /// <summary>
        /// Constructor with one parameter that realises Dependency Injection of Functions (G(x) encapsulated in F(x)). In Mathematical Analisys it`s called as Superposition of Functions (Fore example: F(G(x))
        /// </summary>
        /// <param name="f">Function corresponding to argumnet (G(x) Function encapsulated in F(x) Function)</param>
        public Unares(Function f)
        {
            arg = f;
        }
        public override double Calc(double x)
        {
            return funcPtr(arg.Calc(x));
        }
        public override string ToString()
        {
            return string.Format("{0}({1})", GetType().Name, arg.ToString());
        }

        protected Function DiffFG(Function f,Function g)
        {
            return new Multiplication(g.Diff(), f.Diff());
        }
    }
}