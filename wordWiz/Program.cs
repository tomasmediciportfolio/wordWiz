using System;

namespace wordWiz
{
    class Program
    {
        static void Main(string[] args)
        {
            wordWizard wizard = new wordWizard(); 
            //wizard.AddWord("hello");
            //wizard.AddWord("world");
            //wizard.AddWord("hi");
            //wizard.AddWord("thisisaverylongwordthatidontreallyknowifexists");

            string text = System.IO.File.ReadAllText(@"testText.txt");

            //foreach(string word in text)
            //{
            //    Console.WriteLine(word);
            //    // wizard.AddWord(word);
            //}

            //wordCalculator analysis = wizard.AnalyseText();

            Console.WriteLine("{0}", text);
            //Console.WriteLine(analysis.HighestLetterNumber);
            //Console.WriteLine(analysis.LowestLetterNumber);
        }
    }
}
