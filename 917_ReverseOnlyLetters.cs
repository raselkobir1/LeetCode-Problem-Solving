using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    internal class _917_ReverseOnlyLetters
    {
        public static void ReverseOnlyLettersTest()
        {
            string input = "ab-cd";
            var result = ReverseOnlyLetters(input);
            Console.WriteLine(result);  
        }
        private static string ReverseOnlyLetters(string s)
        {
            char[] charArray = s.ToCharArray();
            int left = 0;
            int right = s.Length -1;  

            while (left < right)
            {
                if (char.IsLetter(charArray[left]) && char.IsLetter(charArray[right]))
                {
                    char temp = charArray[left];
                    charArray[left] = charArray[right];
                    charArray[right] = temp;

                    left++;
                    right--;    
                }

                if (!char.IsLetter(charArray[left]))
                {
                    left++;
                }

                if (!char.IsLetter(charArray[right]))
                {
                    right--;
                }
            }
            return new string(charArray);
        }
    }
}
