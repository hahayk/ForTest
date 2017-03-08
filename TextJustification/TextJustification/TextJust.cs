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
            int startIndex = 0;
            len = L;
            int forCnt = 0;

            foreach (var word in words)
            {
                if (words.Count () == 1)
                {
                    returnWord.Add(word);
                    continue;
                }

                if (MakeSentence(word) == 1)
                {
                    if (++forCnt == words.Count())
                    {
                        returnWord.Add(currentString);
                    }

                    continue;
                }
                else
                {
                    int sz = currentString.Length;
                    if (currentString[sz - 1] == ' ')
                    {
                        sz -= 1;
                    }
                    returnWord.Add(currentString.Substring(0, sz));
                    
                    currentString = word;

                    if (++forCnt == words.Count())
                    {
                        returnWord.Add(currentString);
                    }
                }
            }

            for (int i = 0; i < returnWord.Count; i++)
            {
                //only 1 word
                if (!returnWord[i].Contains(" ") && returnWord[i].Length < L)
                {
                    returnWord[i] = returnWord[i].Insert(returnWord[i].Length, new string(' ', L - returnWord[i].Length));
                }
                //contains only 2 words and its len is < than given L 
                else if (returnWord[i].Split(' ').Count() == 2 && returnWord[i].Length < L)
                {
                    returnWord[i] = returnWord[i].Insert(returnWord[i].IndexOf(' '), new string(' ', L - returnWord[i].Length));
                }
                //contains more than 2 words and its lenght is less than given L
                else if (returnWord[i].Length < L)
                {
                    //split line by words without spaces
                    string[] splitedLine = returnWord[i].Split(' ');
                    int wordPos = 0;

                    do
                    {
                        startIndex = returnWord[i].IndexOf(splitedLine[wordPos], startIndex) + splitedLine[wordPos].Length;

                        //if ((startIndex = returnWord[i].IndexOf(' ', startIndex + 1)) == -1)
                        //{
                        //    startIndex = returnWord[i].IndexOf(' ', 0);
                        //}
                        ////get index of space                        
                        returnWord[i] = returnWord[i].Insert(startIndex + 1, " ");

                        ++wordPos;
                        wordPos %= splitedLine.Length;
                        if (splitedLine[wordPos].Length == 0)
                        {
                            ++wordPos;
                        }
                        if (wordPos == splitedLine.Length - 1)
                        {
                            wordPos = 0;
                        }

                    } while (returnWord[i].Count() < len);

                }
            }

            string[] retVal = { };

            return  retVal;
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

                if (currentString.Length == len)
                {
                    return 0;
                }

                //if (currentString.Length + 1 <= len)
                //{
                //    currentString += " ";
                //}


                //means that can be added another word
                return 1;
            }

            //means that can NOT be added a word anymore
            return 0;
        }
    }
}
