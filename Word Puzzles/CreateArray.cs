using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Word_Puzzles
{
    internal class CreateArray
    {

        public static string[] Create(string[] input)
        {
            string[] array = { "something" };
            List<string> list = new List<string>();
            string previoustext = "";
            int[] length = { 7, 8, 9, 10 };
            foreach (var line in input)
            {

                if (line.Any(char.IsDigit) || line.Any(char.IsPunctuation) || !length.Contains(line.Length) || line.Any(char.IsWhiteSpace))
                {
                    continue;
                }

                if (line != previoustext)
                {

                    list.Add(line);
                }
            }

            return list.ToArray();





        }
    }
}
