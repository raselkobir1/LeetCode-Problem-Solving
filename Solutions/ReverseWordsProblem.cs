using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    public class ReverseWordsProblem
    {
        public string ReverseWords(string s)
        {
            if(s.Length == 0)
                return string.Empty;        

            var words = s.Split(' ');
            var newReverString = string.Empty;
            foreach (var word in words)
            {
                var characters = word.ToCharArray().Reverse();   
                foreach (var ch in characters)
                {
                    newReverString += ch;
                }
                newReverString +=" ";
            }
            newReverString = newReverString.TrimEnd();

            return newReverString;   
        }
    }
}
