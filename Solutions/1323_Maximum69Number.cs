using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class _1323_Maximum69Number
    {
        public static void Maximum69NumberTest()
        {
            int input = 9669;
            var res = Maximum69Number(input);
            Console.WriteLine(res);
        }
        private static int Maximum69Number(int num)
        {
            var strNum = num.ToString().ToCharArray();
            for (int i = 0; i < strNum.Length; i++)
            {
                if (strNum[i] == '6')
                {
                    strNum[i] = '9';
                    break;
                }
            }
            return int.Parse(strNum);
        }
    }
}
