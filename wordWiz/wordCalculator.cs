using System;

namespace wordWiz
{
    class wordCalculator
    {
        public wordCalculator()
        {
            HighestLetterNumber = 0;
            LowestLetterNumber = 100;
            MostOccurencesNumber = 0;
            LeastOccurencesNumber = 10000;
        }

        public int TotalWords;
        public int HighestLetterNumber;
        public int LowestLetterNumber;
        public int MostOccurencesNumber;
        public int LeastOccurencesNumber;
    }
}
