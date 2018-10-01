using System;

namespace wordWiz
{
    public class terminalTalker
    {
        public terminalTalker()
        {
        } 

        public string GetPath()
        {
            Console.WriteLine("Please enter file path");
            string InputText = Console.ReadLine();
            return InputText;
        }

        public bool AskAnalysis()
        {
            Console.WriteLine("Would you like an additional small analysis of the text (y/n)?");
            string InputText = Console.ReadLine();
            if(InputText == "y" || InputText == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
