using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRangeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var letterRange = new LetterRange();
            letterRange.ranges("abc");

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }
    }
}
