using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var checkers = new Checkers();
            checkers.compute("1,0", new[]{"2,1", "0,3", "4,3", "5,6", "4,2"});

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }
    }
}
