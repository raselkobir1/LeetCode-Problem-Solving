using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class _344_ReverseString
    {
        public static void ReverseStringTest()
        {
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(chars);
        }
        private static void ReverseString(char[] s)
        {
            char[] x = new char[s.Length];
            int inc =0;
            for (int i = s.Length-1; i < s.Length; i--)
            {
                x[inc] = s[i];
                inc++;  
            }
        }
    }
}
