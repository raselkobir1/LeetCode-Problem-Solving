using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class _929_NumUniqueEmails
    {
        public static void NumUniqueEmails()
        {
            string[] input = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            int res = NumUniqueEmails(input);
            Console.WriteLine(res);     
        }
        public static int NumUniqueEmails(string[] emails)
        {
            string newEmail = string.Empty; 
            HashSet<string> unique = new HashSet<string>();
            foreach (string email in emails)
            {
                if (unique.Contains(email)) { }
                var res = getUniqueEmail(email);
                unique.Add(res);  
            }
            return unique.Count;
        }

        private static string getUniqueEmail(string email)
        {
            string firstPart = string.Empty;
            string secondPart = string.Empty;

            var x = email.Split("@");
            firstPart = x[0];
            secondPart = x[1];

            firstPart = firstPart.Replace(".","");

            if(firstPart.Contains('+'))
                firstPart = firstPart.Substring(0,firstPart.IndexOf("+"));

            return $"{firstPart}@{secondPart}";



        }
    }
}
