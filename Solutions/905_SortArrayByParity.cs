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
            if(nums.Length == 1)
            {
                return nums;  
            }
            if (nums.Length == 2)
            {
                if (nums[0] % 2 == 0)
                {
                    return nums;
                }
                else
                {
                    int temp = 0;
                    temp = nums[0];
                    nums[0] = nums[1];
                    nums[1] = temp; 
                }
                return nums;
            }
            string evenArr = string.Empty;
            string oddArr = string.Empty;

            for (int i = 0; i< nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenArr += nums[i] + " ";
                }
                else
                {
                    oddArr += nums[i] + " ";
                }
            }

            var x = evenArr.TrimEnd().Split(" ");
            var y = oddArr.TrimEnd().Split(" ");

            string[] res = x.Concat(y).ToArray();


            int[] intArray = new int[x.Length + y.Length];
            for (int i = 0; i < res.Length; i++)
            {
                if (int.TryParse(res[i], out int result))
                {
                    intArray[i] = result;
                }
            }
            return intArray;
        }
    }
}
