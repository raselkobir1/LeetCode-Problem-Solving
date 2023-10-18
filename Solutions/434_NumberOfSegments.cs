using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal static class _434_NumberOfSegments
    {
        public static void CountSegment()
        {
            //string input = "hello, my nme is rsel";
            string input = "      ";
            var res = CountSegments(input);
        }

        private static int CountSegments(string s)
        {
            var seg = s.Split(" ");
            var newItem = seg.Where(item => !string.IsNullOrWhiteSpace(item)).ToArray();
            int count = newItem.Length;
            return count;
        }
    }
}
