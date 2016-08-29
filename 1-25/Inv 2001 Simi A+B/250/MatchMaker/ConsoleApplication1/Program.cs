using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   

    class Program
    {
        static void Main(string[] args)
        {
            var members = new string[]  {    
                                            "BETTY F M A A C C",
                                            "TOM M F A D C A",
                                            "SUE F M D D D D",
                                            "ELLEN F M A A C A",
                                            "JOE M F A A C A",
                                            "ED M F A D D A",
                                            "SALLY F M C D A B",
                                            "MARGE F M A A C C"
                                        };

            var matchMaker = new MatchMaker();

            string[] actual = matchMaker.getBestMatches(members, "BETTY", 2);

            foreach (string item in actual)
            {
                Console.WriteLine(item);
            }

#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
