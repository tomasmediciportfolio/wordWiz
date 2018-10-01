using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;


namespace wordWiz
{
    class wordWizard
    {
        public wordWizard()
        {
            words = new List<string>();
        }

        public string TrimText(string text)
        {
            text = text.ToLower().Trim();
            return Regex.Replace(text, @"\s+", " ");
        }

        public IEnumerable<IGrouping<string, string>> GroupWords(string text)
        {
            var wordlist = text.Split(' ').ToList().GroupBy(i => i);
            return wordlist;
        } 

        public string[] CreateList(string text)
        {
            return text.Split(' ');
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

        private List<string> words;
    }
}
