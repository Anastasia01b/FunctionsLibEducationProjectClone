using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionsLib
{
    /// <summary>
    /// Implements all common operations for binares Functions and operators
    /// </summary>
    public abstract class Binares:Function
    {
        protected Function LeftArg;
        protected Function RightArg;
        protected Func<double, double, double> funcPtr;
        //protected static Dictionary<string, char> operationSymbols = new Dictionary<string, char>();
        readonly static Dictionary<string, char> operationSymbols = new Dictionary<string, char>();


        /// <summary>
        /// Constructor with two parameters that realises Dependency Injection of Functions
        /// </summary>
        /// <param name="l">Function corresponding left operand</param>
        /// <param name="r">Function corresponding right operand </param>
        public Binares(Function l, Function r)
        {
            LeftArg = l;
            RightArg = r;

        }
        static Binares()
        {
            AddOperationSymbols("Addition", '+');
            AddOperationSymbols("Division", '/');
            AddOperationSymbols("Multiplication", '*');
            AddOperationSymbols("Subtraction", '-');
        }
        private static void AddOperationSymbols(string nameOperation, char symbol)
        {
            operationSymbols.Add(nameOperation, symbol);
        }
        /// <summary>
        /// Default implementation for all Binares Function
        /// </summary>
        /// <returns>string - text representation of Binares Function</returns>
        public override string ToString()
        {
            string nameOperation = GetType().Name;
            if (operationSymbols.ContainsKey(nameOperation))
            {
                char operationSymbol = operationSymbols[nameOperation];
                return $"{LeftArg.ToString()}{operationSymbol}{RightArg.ToString()}";
            }
            return $"{LeftArg}?{RightArg}";
        }
        public override double Calc(double x)
        {
            throw new NotImplementedException();
        }
       
    }
}