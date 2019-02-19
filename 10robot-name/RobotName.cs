using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercismRobotName
{
    public class Robot
    {
        private static int LetterPart = 27;
        private static int NumberPart = 0;

        private string _Name = string.Empty;

        public string Name 
        {
            get
            {
                if (this._Name == string.Empty)
                {
                    ++NumberPart;
                    if (NumberPart > 999) // we flipped, increment LetterPart and set NumberPart to 1
                    {
                        ++LetterPart;
                        NumberPart = 1;
                        if (LetterPart > 702) // ZZ -> we flipped, set LetterPart to 27 (AA)
                            LetterPart = 27;
                    }
                    this.Name = string.Format("{0}{1:000}", ConvertToLetters(LetterPart), NumberPart);
                }
                return this._Name;
            }

            private set { this._Name = value; }
        }

        public Robot() 
        {
            // I'm assuming "the first time it boots up" would be in the constructor...
            // so, force the name to generate
            string name = this.Name;
        }

        private static string ConvertToLetters(int num)
        {
            string letters = "";
            while (num > 0)
            {
                int offset = (num - 1) % 26;
                char letter = (char)(offset + (int)'A');
                letters = letter + letters;
                num = (num - (offset + 1)) / 26;
            }
            return letters;
        }

        public void Reset()
        {
            this._Name = string.Empty;
        }
    }
}