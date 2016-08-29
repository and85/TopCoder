using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var zigZag = new ZigZag();
            int[] seq = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            zigZag.longestZigZag(seq);

#if DEBUG
            Console.WriteLine("End");
            Console.ReadLine();
#endif
        }
    }
}
