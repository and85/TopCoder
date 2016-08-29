using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] easy = new[] { 5, 5, 5 };
            int[] middle = new[] { 15, 15, 15 };
            int[] hard = new[] { 45, 45, 35 };

            var chooser = new Chooser();
            int actual = chooser.numSets(easy, middle, hard);
        }
    }
}
