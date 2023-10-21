using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal static class _884_UncommonWordFromTwoSentance
    {
        public static void UncommonFromSentences()
        {
            //Condition for Uncommon: every word appear one in a santance and does not appear in the other santance
            //step-1 remove duplicate from a santance
            //step-2 find mitch match word list.

            //string s1 = "this apple is apple sweet", s2 = "this apple is sour";
            string s1 = "fd kss fd", s2 = "fd fd kss";
            var res = UncommonFromSentences(s1, s2);
            foreach (var sentence in res)
            {
                Console.WriteLine(sentence);    
            }
        }
        private static string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string[] words1 = s1.Split(' ');
            string[] words2 = s2.Split(' ');

            foreach(string word in words1)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            foreach(string word in words2)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            List<string> uncommonWords = new List<string>();
            foreach(var pair in wordCount)
            {
                if (pair.Value == 1)
                {
                    uncommonWords.Add(pair.Key);
                }
            }
            return uncommonWords.ToArray();
        }
    }
}
