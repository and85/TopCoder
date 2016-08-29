namespace LetterRangeApp
{
    public class LetterRange
    {
        private const int NumberOfUniqueLetters = 26;
        private const int AsciCodeOfFirstLetter = 97;

        // O(n) complexity
        public System.String[] ranges(System.String text)
        {
            // input: aha; result: "a:a", "h:h"
            // input: abc; result: "a:c"
            var resultRanges = new System.Collections.Generic.List<string>();
            
            System.Collections.BitArray bitArray = new System.Collections.BitArray(NumberOfUniqueLetters);

            foreach (char c in text)
            {
                if (c - AsciCodeOfFirstLetter < 0)
                    continue;

                bitArray[c - AsciCodeOfFirstLetter] = true;
            }

            char emptyChar = '\0';
            char rangeStart = emptyChar;

            for (int i = 0; i < bitArray.Length; i++)
            {
                if (bitArray[i] && rangeStart == emptyChar)
                    rangeStart = (char)(i + AsciCodeOfFirstLetter);

                if (!bitArray[i] && rangeStart != emptyChar)
                {
                    char rangeEnd = (char)(i + AsciCodeOfFirstLetter - 1);
                    string range = string.Format("{0}:{1}", rangeStart, rangeEnd);
                    resultRanges.Add(range);
                    rangeStart = emptyChar;
                }

            }

            // close a range if it was openned
            if (rangeStart != emptyChar)
            {
                string range = string.Format("{0}:{1}", rangeStart, 'z');
                resultRanges.Add(range);
            }

            return resultRanges.ToArray();
        }
    }
}
