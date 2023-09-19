using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    public class ReverseInteger_mid
    {
        public int Reverse(int x)
        {
            try
            {
                string xStr = x.ToString(); 
                int startingIndex = 0;  
                if (xStr[0] == '-')
                    startingIndex = 1;

                var characterArr = xStr.Substring(startingIndex).ToCharArray();

                var reverseStr = characterArr.Reverse(); 
                string result = string.Empty;

                foreach (var item in reverseStr)
                {
                    result += item;
                }
                int final = int.Parse(result); 
                if(startingIndex == 1) 
                {
                    final = -final;
                }
                return final;   
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
