using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class _349_Intersection
    {
        public static void Intersection()
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            var x = Intersection(nums1, nums2);
            foreach (int i in x)
            {
                Console.WriteLine(i);   
            }
        }
        private static int[] Intersection(int[] nums1, int[] nums2)
        {
            return  nums1.Intersect(nums2).Distinct().ToArray();
        }
    }
}
