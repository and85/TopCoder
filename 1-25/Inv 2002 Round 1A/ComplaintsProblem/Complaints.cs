using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintsProblem
{
    public class Complaints
    {
        public int howMany(int[] line)
        {
            int counter = 0;

            for (int i = 1; i< line.Length; i++)
            for (int j = i - 1; j >= 0; j--)
            {
                if (line[j] < line[i])
                    counter++;
            }

            return counter;
        }
    }
}
