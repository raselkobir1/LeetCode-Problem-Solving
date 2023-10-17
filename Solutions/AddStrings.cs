using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class AddStrings
    {
        public class Solution
        {
            public string AddStrings(string num1, string num2)
            {
                BigInteger x = BigInteger.Parse(num1) + BigInteger.Parse(num2);
                return x.ToString();
            }
        }
    }
}
