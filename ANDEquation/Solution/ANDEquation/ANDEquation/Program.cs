using System;
using System.Collections.Generic;
using System.Text;

namespace ANDEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            var equation = new ANDEquation();
            int N = 10;
            var A = new int[] {1, 3, 5};
            int res = equation.restoreY(A);

            Console.WriteLine("Result = {0}", res);
            Console.ReadLine();
        }
    }
}
