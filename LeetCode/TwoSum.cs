using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * https://leetcode.com/problems/two-sum/description/
 */
namespace LeetCode
{
    public class TwoSum
    {
        public TwoSum() { }

        public int[] Solution(int[] nums, int target)
        {
            int amountOutvalue = 2;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            int[] result = new int[amountOutvalue];

            for (int i = 0; i < nums.Length; i++)
            {
                int key = target - nums[i];

                if (keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs.TryGetValue(key, out result[0]);
                    result[1] = i;
                    return result;
                }

                keyValuePairs[nums[i]] = i;
            }

            return result;
        }
    }
}
