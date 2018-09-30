using System;

namespace wordWiz
{
    class Program
    {
        static void Main(string[] args)
        {
            wordWizard wizard1 = new wordWizard(); 
            wizard1.AddWord("hello");
            wizard1.AddWord("world");
            wizard1.AddWord("hello");

            wordWizard wizard2 = new wordWizard();
            wizard2.AddWord("tomas");

            Console.WriteLine(wizard1.ShowList(0));
         }
    }
}
