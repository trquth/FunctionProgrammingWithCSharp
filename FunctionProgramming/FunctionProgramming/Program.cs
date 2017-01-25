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
        private decimal v1 = 1;
        private decimal v2 = 2;
        private int[] months = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        static void Main(string[] args)
        {
            //new Program().CallFunction(Total2Values,
            //    result => { ShowResultConsole(result); });
            var result = new Program().GreaterThan2(FindValue);
            Console.ReadLine();
        }

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
        public static int[] FindValue(int[] months, int value)
        {
            int[] returnValue = new int[12];
            int index = 0;
            foreach (var month in months)
            {
                if (month > value) { returnValue[index] = month; index++; };
            }
            return returnValue;
        }
        public int[] GreaterThan2(Func<int[], int, int[]> findValue)
        {
            return findValue(this.months, 2);
        }

    }
}
