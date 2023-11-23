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
            var input = 222;
            var result = SubtractProductAndSum(input);
            Console.WriteLine(result);  
        }
        private static int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;   
            while (n > 0) {
                int digit = n % 10;
                product *= digit;
                sum += digit;
                n /= 10;
            }
            return product - sum;    
        }
    }
}
