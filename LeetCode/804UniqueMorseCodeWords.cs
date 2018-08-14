using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _804UniqueMorseCodeWords
    {
        //International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

        //For convenience, the full table for the 26 letters of the English alphabet is given below:
        //            [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]

        //Example:
        //Input: words = ["gin", "zen", "gig", "msg"]
        //Output: 2
        //Explanation: 
        //The transformation of each word is:
        //"gin" -> "--...-."
        //"zen" -> "--...-."
        //"gig" -> "--...--."
        //"msg" -> "--...--."

        //There are 2 different transformations, "--...-." and "--...--.".

        public int UniqueMorseRepresentations(string[] words)
        {
            var result = new Dictionary<string, int>();
            var a = 97;
       
            var morseCode = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            var hash = new Dictionary<char, string>();
            for (int i = 0; i < morseCode.Length; i++)
            {
                hash.Add(Convert.ToChar(i + a), morseCode[i]);
            }

            for (int i = 0; i < words.Length; i++)
            {
                var wordMorse = "";

                for (int k = 0; k < words[i].Length; k++)
                {
                    var c = words[i][k];
                    wordMorse = wordMorse + hash[c];
                }
                if (result.ContainsKey(wordMorse))
                {
                    result[wordMorse]++;
                }
                else
                {
                    result.Add(wordMorse, 1);

                }
            }

            return result.Count;
        }

    }
}
