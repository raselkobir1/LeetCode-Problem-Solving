using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class _383_CanConstruct
    {
        public static void CanConstructTest()
        {
            string input1 = "aa", input2 = "ab";
            var res = CanConstruct(input1, input2);
            Console.WriteLine(res); 
        }
        private static bool CanConstruct(string ransomNote, string magazine)
        {
            var ch = ransomNote.ToCharArray();
            string newString = magazine;

            for (int i = 0; i < ch.Length; i++)
            {
                if (newString.Contains(ch[i].ToString()))
                {
                    newString = newString.Remove(newString.IndexOf(ch[i]), 1);
                }
                else
                {
                    return false; // If a character is not found, return false immediately.
                }
            }

            return true; // If all characters are found, return true.
        }
    }
}
