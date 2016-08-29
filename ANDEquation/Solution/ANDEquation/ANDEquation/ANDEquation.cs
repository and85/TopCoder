using System;

namespace ANDEquation
{
    public class ANDEquation
    {
        public int restoreY(int[] arguments)
        {
            int result = -1;

            if (arguments.Length % 2 == 0)
            {
                return result;
            }

            result = arguments[0] & arguments[1];

            for (int i = 2; i < arguments.Length; i++)
            {
                result &= arguments[i];
            }

            return result;
        }
    }
}

