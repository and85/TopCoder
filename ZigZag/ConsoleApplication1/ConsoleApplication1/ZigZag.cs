namespace ConsoleApplication1
{
    public class ZigZag
    {
        public int longestZigZag(int[] sequence)
        {
            if (sequence.Length < 2)
            {
                return 1;
            }

            return RemoveElements(sequence).Length;
        }

        public int[] RemoveElements(int[] sequence)
        {
            if (!AllSignsDifferent(sequence))
            {
                int prevSign = 0;
                int[] newSequence = new int[0];

                for (int i = 1; i < sequence.Length; i++)
                {
                    int sign = System.Math.Sign(sequence[i] - sequence[i - 1]);
                    if (IsTheSameSign(prevSign, sign))
                    {
                        newSequence = new int[sequence.Length - 1];
                        System.Array.Copy(sequence, 0, newSequence, 0, i-1);
                        System.Array.Copy(sequence, i, newSequence, i - 1, newSequence.Length - i + 1);
                        break;                        
                    }

                    prevSign = sign;
                }

                return RemoveElements(newSequence);
            }
            else
            {
                return sequence;
            }
        }

        private static bool IsTheSameSign(int prevSign, int sign)
        {
            return prevSign == sign || sign == 0;
        }

        public bool AllSignsDifferent(int[] sequence)
        {
            int prevSign = 0;

            for (int i = 1; i < sequence.Length; i++)
            {
                int sign = System.Math.Sign(sequence[i] - sequence[i - 1]);
                if (IsTheSameSign(prevSign, sign))
                {
                    return false;
                }

                prevSign = sign;
            }

            return true;
        }
    }
}
