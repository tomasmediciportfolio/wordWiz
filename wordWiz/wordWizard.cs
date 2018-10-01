using System;
using System.Collections.Generic;
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

        public List<string> CreateList(string text)
        {
            return text.Split(' ').ToList();
        }

        public void AddWords(List<string> listOfText)
        {
            foreach (var wrd in listOfText)
            {
                words.Add(wrd);
            }
        }

        public wordCalculator AnalyseText(IEnumerable<IGrouping<string, string>> wordlist)
        {
            wordCalculator analysis = new wordCalculator();

            foreach(string word in words)
            {
                analysis.HighestLetterNumber    = Math.Max(word.Length, analysis.HighestLetterNumber);
                analysis.LowestLetterNumber     = Math.Min(word.Length, analysis.LowestLetterNumber);
            }
            analysis.TotalWords = words.Count;
            foreach(IGrouping<string, string> elm in wordlist)
            {
                analysis.MostOccurencesNumber   = Math.Max(elm.Count(), analysis.MostOccurencesNumber);
                analysis.LeastOccurencesNumber  = Math.Min(elm.Count(), analysis.LeastOccurencesNumber);

            }
            return analysis;
        }

        private List<string> words;
    }
}
