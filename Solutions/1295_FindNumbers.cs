using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class _1295_FindNumbers
    {
        public static void FindNumbersTest()
        {
            int[] input = { 154, 2569, 12 };
            var res = FindNumbers(input);
            Console.WriteLine(res); 
        }
        private static int FindNumbers(int[] nums)
        {
            int count = 0; 
            foreach (int num in nums)
            {
                var len = num.ToString().ToCharArray().Length;
                if(len % 2 == 0)
                    count++;    

            }
            return count;
        }
    }
}
