using System;
using System.IO;
using System.Linq;

namespace wordWiz
{
    class Program
    {
        static void Main(string[] args)
        {
            wordWizard wizard   = new wordWizard();
            terminalTalker bot  = new terminalTalker();

            string input        = bot.GetPath();
            try
            {
                string textInput = File.ReadAllText(@input);

                string text = wizard.TrimText(textInput);
                var wordlist = wizard.GroupWords(text);

                Console.WriteLine("The count of each unique word in your file is:");
                foreach (var grp in wordlist)
                {
                    Console.WriteLine("{0}: {1}", grp.Count(), grp.Key);
                }

                var listOfText = wizard.CreateList(text);
                wizard.AddWords(listOfText);
                wordCalculator analysis = wizard.AnalyseText(wordlist);
                bool question = bot.AskAnalysis();
                if (question)
                {
                    Console.WriteLine("There is a total of {0} words in the text of your file. " +
                                      "The word that has the highest occurences, appears {1} time(s) in the text, " +
                                      "and the one with the least occurences, {2} time(s)." +
                                      "The shortest word has {3} letter(s), " +
                                      "and the longest {4} letter(s).",
                                      analysis.TotalWords, analysis.MostOccurencesNumber, 
                                      analysis.LeastOccurencesNumber, analysis.HighestLetterNumber, 
                                      analysis.LowestLetterNumber);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file name is not correct, please run the program again");
            }
        }
    }
}
