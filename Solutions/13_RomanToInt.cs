using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal static class _13_RomanToInt
    {
        public static void RomanToInts()
        {
            string input = "III";
            //string input = "LVIII";
            int res = RomanToInt(input);
            Console.WriteLine(res);
        }

        public static int RomanToInt(string s)
        {
            char[] chars = s.ToCharArray();
            int sum = 0;
            for(int i = 1; i< s.Length; i++)
            {
                if (chars[i-1] == 'I')
                {
                    if (chars[i] == 'V' || chars[i] == 'X')
                    {
                        sum -= 1;
                    }
                    sum += 1;
                }
                else if(chars[i-1] == 'V')
                {
                    sum += 5;
                }
                else if (chars[i - 1] == 'X')
                {
                    if (chars[i] == 'L' || chars[i] == 'C')
                    {
                        sum -= 10;
                    }
                    sum += 10;
                }
                else if (chars[i - 1] == 'L')
                {
                    sum += 50;
                }
                else if (chars[i - 1] == 'C')
                {
                    if (chars[i] == 'D' || chars[i] == 'M')
                    {
                        sum -= 100;
                    }
                    sum += 100;
                }
                else if (chars[i - 1] == 'D')
                {
                    sum += 500;
                }
                else if (chars[i - 1] == 'M')
                {
                    sum += 1000;
                }
            }
            return sum;
        }
    }
}
