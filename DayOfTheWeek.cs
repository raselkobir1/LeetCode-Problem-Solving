using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    internal class DayOfTheWeek
    {
        public static void DayOfTheWeekTest()
        {
            int day = 19, month = 11, year = 2023; 
            var result = DayOfTheWeeks(day, month, year);
            Console.WriteLine(result);  
        }
        private static string DayOfTheWeeks(int day, int month, int year)
        {
            try
            {
                DateTime date = new DateTime(year, month, day); 
                string dayOfWeek = date.DayOfWeek.ToString(); 
                return dayOfWeek; 
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
