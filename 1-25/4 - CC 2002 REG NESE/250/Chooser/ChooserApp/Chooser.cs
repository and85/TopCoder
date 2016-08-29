using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooserApp
{
    public class Chooser
    {
        public int numSets(int[] easy, int[] middle, int[] hard)
        {
            int result = 0;
            
            Array.Sort<int>(easy);
            Array.Sort<int>(middle);
            Array.Sort<int>(hard);

            int maxEasy     = easy.Length;
            int maxMiddle   = middle.Length;
            int maxHard     = hard.Length;

            for (int i = 0; i < maxEasy; i++)
            for (int j = 0; j < maxMiddle; j++)
            {
                int smallSum = easy[i] + middle[j];

                if (smallSum > 75)
                {
                    maxMiddle = j;
                    break;
                }

                for (int k = 0; k < maxHard; k++)
                {
                    int bigSum = easy[i] + middle[j] + hard[k];

                    if (!(bigSum >= 60 && bigSum <= 75))
                    {
                        continue;
                    }
                    
                    result++;
                }
            }

            return result;
        }
    }
}