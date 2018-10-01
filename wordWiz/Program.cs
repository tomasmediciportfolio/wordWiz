using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace wordWiz
{
    class Program
    {
        static void Main(string[] args)
        {
            wordWizard wizard = new wordWizard();
           
            string text     = File.ReadAllText(@"testText.txt");
            text            = wizard.TrimText(text);
            var wordlist    = wizard.GroupWords(text);

            foreach (var grp in wordlist)
            {
                Console.WriteLine("{0}: {1}", grp.Count(), grp.Key);
            }




            //wordCalculator analysis = wizard.AnalyseText();

            //Console.WriteLine(Words[3]);

            // Console.WriteLine("{0}", text);
            ////Console.WriteLine(analysis.HighestLetterNumber);
            //Console.WriteLine(analysis.LowestLetterNumber);
        }
    }
}
