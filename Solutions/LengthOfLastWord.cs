using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    public class LengthOfLastWord
    {
        public int LengthOfLastWords(string s) 
        {
            var splitStr = s.Split(' ');  
            var lastWord = splitStr[splitStr.Length - 1];
            lastWord.Trim();    
            return lastWord.Length;
        }
    }
}
