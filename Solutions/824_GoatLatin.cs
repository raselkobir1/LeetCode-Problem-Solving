using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal static class _824_GoatLatin
    {
        //1.---if a word begin vowel then append 'ma' to end of the word.
        //2.---if a word begin constant remove the first letter and append to the end then add 'ma'
        //3.---Add one letter 'a' to the end each word per its word in the santance. 
        public static void GoatLatin()
        {
            string input = "I speak Goat Latin";
            string res = ToGoatLatin(input);
            Console.WriteLine(res);
        }
        private static string ToGoatLatin(string sentence)
        {
            string vowel = "aeiou";
            string[] words = sentence.Split(' ');
            string newSantance = string.Empty;
            string a = "a";    
            foreach (string word in words)
            {
                if (vowel.Contains(word.ToLower()[0]))
                {
                    newSantance += $"{word}ma" + a + " ";
                }
                else 
                {
                    char ch = word[0];
                    var newWord = word.Remove(0, 1); 
                    newSantance += newWord + ch + "ma" + a +" ";
                }
                a += "a";
            }
            string result = newSantance.TrimEnd();
            return result;
        }
    }
}
