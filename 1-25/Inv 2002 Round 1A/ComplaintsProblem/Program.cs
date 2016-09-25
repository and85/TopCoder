using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = { 1000, 800, 900, 1400 };

            var complaints = new Complaints();
            int actual = complaints.howMany(line);

            Console.WriteLine(actual);

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
