using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeProblem.Solutions
{
    internal static class _905_SortArrayByParity
    {
        public static void SortArrayByParity()
        {
            //int[] input = {3, 1, 2, 4};
            //int[] input = {0};
            //int[] input = { 0, 2 };
            //int[] input = { 1, 0 };
            int[] input = { 0, 2, 4 };
            var res = SortArrayByParity(input);
            foreach (int i in res)
            {
                Console.WriteLine(i);   
            }
        }
        private static int[] SortArrayByParity(int[] nums)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
                else
                {
                    oddNumbers.Add(num);
                }
            }

            evenNumbers.Sort(); 

            evenNumbers.AddRange(oddNumbers);

            return evenNumbers.ToArray();
        }
    }
}
