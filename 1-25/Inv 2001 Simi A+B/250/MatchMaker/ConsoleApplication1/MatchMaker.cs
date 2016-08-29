namespace ConsoleApplication1
{
    public class MatchMaker
    {
       private char _delimiter = ' ';

        private class User
        {
            public string UserName {get; set;} 
            public string UserSex {get; set;} 
            public string PreferedSex {get; set;}
            public string[] UserAnswers { get; set; } 
        }

        static int CompareByValue(System.Collections.Generic.KeyValuePair<string, int> a, System.Collections.Generic.KeyValuePair<string, int> b)
        {
            return b.Value.CompareTo(a.Value);
        }

        public string[] getBestMatches(string[] members, string currentUser, int sf)
        {
            var result = new System.Collections.Generic.List<string>();

            // find preferences of a current user
            User interestedUser = new User();
            FindPreferences(members, currentUser, interestedUser);

            var matches = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, int>>();

            // Analyse answers of other users
            foreach (string member in members)
            {
                User possibleMatch = new User();
                ExtractUserObject(possibleMatch, member.Split(_delimiter));

                if (interestedUser.PreferedSex == possibleMatch.UserSex)
                {
                    // if sex suits us, calculate a number of matched answers
                    int matchedAnswers = 0;
                    for (int i=0; i<interestedUser.UserAnswers.Length; i++)
                    {
                        if (interestedUser.UserAnswers[i] == possibleMatch.UserAnswers[i])
                        {
                            matchedAnswers++;
                        }
                    }

                    if (matchedAnswers >= sf)
                    {
                        matches.Add(new System.Collections.Generic.KeyValuePair<string, int>(possibleMatch.UserName, matchedAnswers));
                    }
                }
            }
                     
            matches.Sort(CompareByValue);

            foreach (var match in matches)
            {
                result.Add(match.Key);
            }

            return result.ToArray();
        }

        private void FindPreferences(string[] members, string currentUser, User interestedUser)
        {
            foreach (string item in members)
            {
                string[] input = item.Split(' ');
                string userName = input[0];

                if (userName == currentUser)
                {
                    ExtractUserObject(interestedUser, input);
                    break;
                }
            }
        }

        private static void ExtractUserObject(User interestedUser, string[] input)
        {
            interestedUser.UserName = input[0];
            interestedUser.UserSex = input[1];
            interestedUser.PreferedSex = input[2];
            int currentUserAnsfersLenght = input.Length - 3;
            interestedUser.UserAnswers = new string[currentUserAnsfersLenght];

            System.Array.Copy(input, 3, interestedUser.UserAnswers, 0, input.Length - 3);
        }
    }
}

