namespace LeetCodeProblem.Solutions
{
    public class _169_MajorityElementOfArray
    {
        //int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
        public int MajorityElement(int[] nums)
        {
            //int count = 0;
            //int? candidate = null;

            //foreach (int num in nums)
            //{
            //    if (count == 0) 
            //        candidate = num;
            //    count += (num == candidate) ? 1 : -1;
            //}

            //return candidate.Value; 

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

                // Check if the current element is the majority element
                if (count[num] > nums.Length / 2)
                {
                    return num;
                }
            }
            return -1;
        }
    }
}
