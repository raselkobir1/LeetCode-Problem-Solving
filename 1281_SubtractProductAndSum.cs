using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    internal class _1281_SubtractProductAndSum
    {
        public static void SubtractProductAndSum()
        {
            var input = 256;
            var result = SubtractProductAndSum(input);
            Console.WriteLine(result);  
        }
        private static int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;   
            var nums = n.ToString().ToCharArray();
            foreach (char c in nums)
            {
                int num = c;
                product += c * num;
                sum += c + num;
                num = 0;
            }
            return product - sum;    
        }
    }
}
