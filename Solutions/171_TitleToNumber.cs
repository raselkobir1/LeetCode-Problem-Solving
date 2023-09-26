using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    public static class _171_TitleToNumber
    {
        public static void TitleToNumberForExcel()
        {
            string input = "AB";
            int num = TitleToNumber(input);
            Console.WriteLine(num); 
            Console.WriteLine();
        }
        private static int TitleToNumber(string columnTitle)
        {
            int result = 0;
            foreach (char c in columnTitle)
            {
                int digitValue = c - 'A' + 1;
                result = result * 26 + digitValue;
            }
            return result;
        }
    }
}
