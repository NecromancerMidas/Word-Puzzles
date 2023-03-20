using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Word_Puzzles
{
    internal class FindRandomWordAndCompare
    {
        //REDUNDANT LOL NOOB
        public static void Compare(string[] list)
        {
            string sub1 = String.Empty;
            string sub2 = String.Empty;
            string line1 = String.Empty;
            string line2 = String.Empty;
            do
            {
                line1 = list[Randomer.Randomizer(0, list.Length)];
                line2 = list[Randomer.Randomizer(0, list.Length)];
                for (int j = 3; j < 5; j++)
                {
                    sub1 = line1.Substring(line1.Length - j);
                    sub2 = line2.Substring(j);
                }
            } while (sub1 != sub2);
            Console.WriteLine($@"'{line1}' ends the same as '{line2}' starts. Answer: '{sub1}'");
              /*  string line = list[Randomer.Randomizer(0, list.Length)];
                foreach (var listline in list)
                {
                    for (int j = 3; j < 5; j++)
                    {
                        sub1 = line.Substring(line.Length - j);
                        sub2 = listline.Substring(j);
                        if (sub1 == sub2)
                        {
                            Console.WriteLine($@"{line} ends the same as {listline} starts. Answer: '{sub1}'");
                        }
                    }
                }*/
        }
    }
}
