using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class _412_FizzBuzz
    {
        public static void FizzBuzzTest()
        {
            int input = 15;
            var res = FizzBuzz(input);
            foreach (var item in res)
            {
                Console.WriteLine(item);    
            }

        }
        private static IList<string> FizzBuzz(int n)
        {
            string[] newArr = new string[n];
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    newArr[i - 1] = "FizzBuzz";
                else if (i % 3 == 0)
                    newArr[i - 1] = "Fizz";
                else if (i % 5 == 0)
                    newArr[i - 1] = "Buzz";
                else
                    newArr[i - 1] = i.ToString();
            }
            return newArr.ToList();  
        }
    }
}
