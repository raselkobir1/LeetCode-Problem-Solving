
namespace LeetCodeProblem.Solutions
{
    public static class _136_SingleNumber
    {
        public static void SingleNumber()
        {
            //int[] input = { 2, 2, 1 }
            int[] input = { 4, 1, 2, 1, 2,3 };
            int res = SingpleNumber(input);
            Console.WriteLine(res);
        }

        private static int SingpleNumber(int[] nums)  
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int num in nums) 
            {
                if (!count.ContainsKey(num))
                {
                    count[num] = 1;
                }
                else
                {
                    count[num]++;
                }
            }   
            // Find the minimum value and its corresponding key
            KeyValuePair<int, int> minEntry = count.Aggregate((l, r) => l.Value < r.Value ? l : r);
            int minKey = minEntry.Key;
            return minKey;
        }
    }
}
