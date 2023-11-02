using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class MobileBillCalculation
    {
        public void MobileBillCalculationPeakOurAndOffPeakOur() 
        {
            DateTime startDate = new DateTime(2019, 08, 31, 08, 59, 13); 
            DateTime endDate =   new DateTime(2019, 08, 31, 09, 00, 39);
            decimal cost = MobileBillCalculationPeakOurAndOffPeakOur(startDate, endDate);
        }

        public decimal MobileBillCalculationPeakOurAndOffPeakOur(DateTime startDate, DateTime endDate)
        {
            return 10;
        }
    }
}
