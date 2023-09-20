using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    public class _29_DivideTwoInteger
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0)
                return dividend;

            if (dividend == int.MinValue && divisor == - 1)
                return int.MaxValue;

            long result = (long)dividend / divisor;

            if (result > int.MaxValue)
                return int.MaxValue;    

            if ((int)result < int.MinValue)
                return int.MinValue;    

            return (int)result;
        }
    }
}
