using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class _1221_BalancedStringSplit
    {
        public static void BalancedStringSplitTest()
        {
            string input = "RLRRLLRLRL";
            var res = BalancedStringSplit(input); 
            Console.WriteLine(res); 
        }
        private static int BalancedStringSplit(string s)
        {
            int count = 0;
            int balanceStr = 0;
            foreach (char c in s)
            {
                if (c == 'L')
                    balanceStr++;
                else if(c == 'R')
                    balanceStr--;

                if(balanceStr == 0)
                   count++;
            }
            return count;
        }
    }
}
