using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextJustification
{
    public class TextJust
    {
        string currentString = string.Empty;
        int len = 0;

        public string[] textJustification(string[] words, int L)
        {
            List<string> returnWord = new List<string>();
            len = L;

            foreach (var word in words)
            {
                if (MakeSentence(word) == 1)
                {
                    continue;
                }
                else
                {
                    returnWord.Add(currentString.Substring(0, currentString.Length - 1));
                    currentString = word;
                }
            }


            return words;
        }

        int MakeSentence(string curStr)
        {
            //if((currentString.Length + curStr.Length + 1 /*1 for space between words*/) <= len)
            if ((currentString.Length + curStr.Length) <= len)
            {
                if (currentString.Length == 0)
                {
                    //if it is the first time of a loop
                    currentString += curStr;
                }
                else
                {
                    //if it is NOT the first time of a loop
                    currentString += " " + curStr;
                }

                if (currentString.Length + 1 <= len)
                {
                    currentString += " ";
                }

                //means that can be added another word
                return 1;
            }

            //means that can NOT be added a word anymore
            return 0;
        }
    }
}
