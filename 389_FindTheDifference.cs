using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    internal static class _389_FindTheDifference
    {
        public static void FindTheDifference()
        {
            string s = "a";
            string t = "aa";
            var res = FindTheDifference(s, t);
            Console.WriteLine(res); 

        }
        private static char FindTheDifference(string s, string t)
        {
            List<char> tContainer = new List<char>(t);
            foreach (char c in s)
            {
                tContainer.Remove(c);
            }
            return tContainer[0];
        }
    }
}
