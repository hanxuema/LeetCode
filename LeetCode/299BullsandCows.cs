using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //You are playing the following Bulls and Cows game with your friend: You write down a number and ask your friend to guess what the number is. Each time your friend makes a guess, you provide a hint that indicates how many digits in said guess match your secret number exactly in both digit and position(called "bulls") and how many digits match the secret number but locate in the wrong position(called "cows"). Your friend will use successive guesses and hints to eventually derive the secret number.

    //Write a function to return a hint according to the secret number and friend's guess, use A to indicate the bulls and B to indicate the cows. 


    //Please note that both secret number and friend's guess may contain duplicate digits.


    //Example 1:


    //Input: secret = "1807", guess = "7810"


    //Output: "1A3B"


    //Explanation: 1 bull and 3 cows.The bull is 8, the cows are 0, 1 and 7.
    //Example 2:


    //Input: secret = "1123", guess = "0111"


    //Output: "1A1B"


    //Explanation: The 1st 1 in friend's guess is a bull, the 2nd or 3rd 1 is a cow.
    //Note: You may assume that the secret number and your friend's guess only contain digits, and their lengths are always equal.
    public class _299BullsandCows
    {
        public string GetHint(string secret, string guess)
        {
            var bull = 0;
            var cow = 0;
            //check corner case
            if (secret.Length == 0 || guess.Length == 0) return string.Format("{0}A{1}B", bull, cow);

            var secOri = new Dictionary<int, int>();
            for (int i = 0; i < secret.Length; i++)
            {
                if (!secOri.ContainsKey(secret[i]))
                {
                    secOri.Add(secret[i], 1);
                }
                else
                {
                    secOri[secret[i]] = secOri[secret[i]] + 1;
                }
            }

            for (int i = 0; i < guess.Length; i++)
            {
                //if secret has same value as guess
                if (secret[i] == guess[i])
                {
                    secOri[guess[i]] = secOri[guess[i]] - 1;
                    bull++;
                }
            }
            for (int i = 0; i < guess.Length; i++)
            {
                if (secret[i] != guess[i] &&secOri.ContainsKey(guess[i]) && secOri[guess[i]] > 0)
                {
                    secOri[guess[i]] = secOri[guess[i]] - 1;
                    cow++;
                }
            }

            return string.Format("{0}A{1}B", bull, cow);
        }
    }
}
