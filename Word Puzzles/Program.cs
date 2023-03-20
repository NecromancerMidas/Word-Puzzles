// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Word_Puzzles
{

    class WordPuzzles{


        public static void Main(string[] args)
        {
            var path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..","..",".."));
            Console.WriteLine(path);
            List<string> toFile = new List<string>();
            var text = File.ReadAllText($@"{path}\ordliste.txt").Split("\t").ToArray();
            text = CreateArray.Create(text);
            for (int i = 0; i <= 200; i++)
            {
                string sub1 = String.Empty;
                string sub2 = String.Empty;
                string line1 = String.Empty;
                string line2 = String.Empty;
                string toFileAnswer1 = String.Empty;
                string toFileAnswer2 = String.Empty;
                do
                {
                    line1 = text[Randomer.Randomizer(0, text.Length)];
                    line2 = text[Randomer.Randomizer(0, text.Length)];
                    for (int j = 3; j <= 5; j++)
                    {
                        sub1 = line1.Substring(j);
                        sub2 = line2.Substring(0,j);
                        toFileAnswer1 = line1.Remove(j);
                        toFileAnswer2 = line2.Remove(0,j);
                        
                    }
                } while (sub1 != sub2);
                toFile.Add($@"Number:{i}{(i >= 10 ? null : " ")}{(i >= 100 ? null : " ")} '{toFileAnswer1}_'  '_{toFileAnswer2}' Answer:'{sub1}'");
                Console.WriteLine($@"Number:{i}{(i >= 10 ? null : " ")}{(i >= 100 ? null : " ")} '{line1}' ends the same as '{line2}' starts. Answer: '{sub1}'");
                
               

            }
            File.WriteAllLines(@$"{path}\completefile.txt", toFile);

        }


    }

}