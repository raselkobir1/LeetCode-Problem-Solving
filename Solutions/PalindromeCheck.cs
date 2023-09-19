using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class PalindromeCheck 
    {
        public bool IsPalindrome(int x )
        {
            try
            {
                var LeftToRight = x;
                var reverseData = x.ToString().ToCharArray().Reverse();
                string result = string.Empty;

                foreach (var item in reverseData)
                {
                    result += item; 
                }

                int RightToLeft = int.Parse(result); 

                if (LeftToRight == RightToLeft)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;   
            }

        }
    }
}
