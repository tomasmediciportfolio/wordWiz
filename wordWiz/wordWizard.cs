using System;
using System.Collections.Generic;
using System.IO;


namespace wordWiz
{
    class wordWizard
    {
        public wordWizard()
        {
            words = new List<string>(); // List<string>();
        }

        public wordCalculator AnalyseText()
        {
            wordCalculator analysis = new wordCalculator();

            foreach(string word in words)
            {
                analysis.HighestLetterNumber = Math.Max(word.Length, analysis.HighestLetterNumber);
                analysis.LowestLetterNumber = Math.Min(word.Length, analysis.LowestLetterNumber);
            }
            analysis.TotalWords = words.Count;
            return analysis;
        }

        public void AddWord(string word)
        {
            words.Add(word);
        }

        public string ShowList(int number)
        {
            return words[number];  
        }

        private List<string> words; //List<string> words;     // ensures encapsulation
    }
}
