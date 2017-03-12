using System.Collections.Generic;
using System.Linq;

namespace TextJustification
{
    public class TextJust
    {
        public string[] textJustification(string[] words, int L)
        {
            string currentString = string.Empty;
            int len = L;

            List<string> returnWord = new List<string>();
            int startIndex = 0;

            int forCnt = 0;
            bool nextLine = false;
            bool equalLen = false;

            foreach (var word in words)
            {
                if (words.Count () == 1)
                {
                    returnWord.Add(word);
                    continue;
                }

                if (MakeSentence(word, ref currentString, L, ref nextLine, ref equalLen) == 1)
                {
                    if (++forCnt == words.Count())
                    {
                        returnWord.Add(currentString);
                    }

                    continue;
                }
                else if (equalLen)
                {
                    //if (++forCnt == words.Count() && nextLine == false)
                    {
                        returnWord.Add(currentString);
                    }
                    equalLen = false;
                }
                else
                {
                    int sz = currentString.Length;
                    if (currentString[sz - 1] == ' ')
                    {
                        sz -= 1;
                    }
                    returnWord.Add(currentString.Substring(0, sz));

                    if (!nextLine)
                    {
                        currentString = word;
                        nextLine = false;
                    }
                    else
                    {
                        currentString = string.Empty;
                    }

                    if (++forCnt == words.Count() && nextLine == false)
                    {
                        returnWord.Add(currentString);
                    }
                }
            }

            for (int i = 0; i < returnWord.Count; i++)
            {
                //only 1 word
                if ((!returnWord[i].Contains(" ") && returnWord[i].Length < L) || i == returnWord.Count - 1)
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
           
            return  returnWord.ToArray();
        }

        int MakeSentence(string curStr, ref string currentString, int len, ref bool nextLine, ref bool equalLen)
        {
            equalLen = false;
            //if((currentString.Length + curStr.Length + 1 /*1 for space between words*/) <= len)
            if ((currentString.Length + curStr.Length) < len)
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

                nextLine = false;

                if (currentString.Length == len)
                {
                    nextLine = true;
                    return 0;
                }
                
                //can be added another word
                return 1;
            }

            if (curStr.Length == len)
            {
                currentString = curStr;
                equalLen = true;
            }

            //means that can NOT be added a word anymore
            return 0;
        }
    }
}
