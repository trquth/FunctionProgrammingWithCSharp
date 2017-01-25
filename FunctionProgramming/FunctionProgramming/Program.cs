using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionProgramming
{
    class Program
    {

        static void Main(string[] args)
        {
            new Program().CallFunction(Total2Values,
                result => { ShowResultConsole(result); });
            Console.ReadLine();
        }
        private decimal v1 = 1;
        private decimal v2 = 2;
        public static decimal Total2Values(decimal value1, decimal value2)
        {
            return value1 + value2;
        }
        public static void ShowResultConsole(decimal result)
        {
            Console.WriteLine("Result {0}", result);
        }
        public void CallFunction(Func<decimal, decimal, decimal> callTotal2Value,
            Action<decimal> callShowResult)
        {

            decimal result = callTotal2Value(this.v1, this.v2);
            callShowResult(result);
        }
    }
}
