using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LeetCodeProblem.Solutions
{
    internal static class _202_HappyNumber
    {
        public static void IsHappyNumber()
        {
            //int happyNumber = 19;
            //int happyNumber = 2;
            int happyNumber = 75;
            //bool res = IsHappy(happyNumber);
            SumOfDigits(happyNumber);
            //Console.WriteLine(res); 
        }
        private static bool IsHappy(int num) 
        {
            int sum = 0;
            int temp = num;
            if(temp == 1)
                return true;

            if (num == 7)
                return true;

            var x = num.ToString().ToCharArray();
            foreach(var i in x)
            {
                var val = i.ToString();
                sum = sum + (Convert.ToInt32(val) * Convert.ToInt32(val));
                temp = sum;
            }

            if ((temp == num * num) || (temp == num))
                return false;

            return IsHappy(temp);
        }

        private static void SumOfDigits(int n)
        {
            int sum = 0;
            int xx = (n % 10);
            int yy = (n % 10);
            sum += xx * yy;
            n /= 10;

        }
    }
}
