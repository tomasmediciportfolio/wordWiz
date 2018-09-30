using System;
using System.Collections.Generic;


namespace wordWiz
{
    class wordWizard
    {
        public wordWizard()
        {
            words = new List<string>();
        }

        public void AddWord(string word)
        {
            words.Add(word);
        }

        public string ShowList(int number)
        {
            return words[number];  
        }

        private List<string> words;     // ensures encapsulation
    }
}
