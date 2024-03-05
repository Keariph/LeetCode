using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * https://leetcode.com/problems/missing-number/description/
 */
namespace LeetCode
{
    public class MissingNumber
    {
        public MissingNumber() { }

        public int Solution(int[] nums)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result += i - nums[i];
            }

            result += nums.Length;
            return result;
        }
    }
}
