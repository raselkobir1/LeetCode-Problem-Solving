using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class _389_FirstUniqChar
    {
        public static void FirstUniqChar()
        {
            string input = "leetcode";
            var x = FirstUniqChar(input);
            Console.WriteLine(x);   
        }
        public static int FirstUniqChar(string s)
        {
            Dictionary<char,int> count = new Dictionary<char,int>(); 
            foreach (char c in s)
            {
                if (count.ContainsKey(c))
                {
                    count[c]++; 
                }
                else { count[c] = 1; }
            }

            for (int i = 0; i <= s.Length-1; i++)
            {
                if(count[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
