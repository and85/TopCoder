using System;
using System.Collections.Generic;
using System.Text;

namespace RPN
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"2 3 + 6 ~ 7 * -";
            var rpn = new RPN();
            
            int result = rpn.evaluate(input);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
