using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    public class _14_FindLongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
           int minLength = strs.Min(x => x.Length); 
            string sortestElement = strs.FirstOrDefault(x => x.Length == minLength); 
            
            foreach (string item in strs) 
            {
                for (int i = 0; i < minLength; i++) 
                {
                    if (item[i] != sortestElement[i])
                    {
                        minLength = i;
                        break;  

                    }
                }
            }
            return sortestElement.Substring(0, minLength);
        }
    }
}
