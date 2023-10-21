using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal static class _859_BuddyStrings
    {
        public static void BuddyStrings()
        {
            string s = "aaaaaaabc";
            string goal = "aaaaaaacb";
            var res = BuddyStrings(s, goal);
            Console.WriteLine(res); 
        }
        private static bool BuddyStrings(string s, string goal)
        {
            char[] chString = s.ToCharArray();
            foreach (char ch in chString)
            {
                if (!goal.Contains(ch))
                {
                    return false;
                }
            }
            return true;        
            //char[] chString = s.ToCharArray();
            //for (var i = 0; i < s.Length-1; i++)  
            //{
            //    for (var j = 1; j< s.Length; j++) 
            //    {
            //        if(i != j)
            //        {
            //            var x = chString[i];
            //            chString[i] = chString[j];
            //            chString[j] = x;
            //            if (chString.SequenceEqual(goal.ToCharArray()))
            //            {
            //                return true;
            //            }
            //        }
            //    }
            //    chString = s.ToCharArray(); 
            //}
            //return false;   
        }
    }
}
