using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * https://leetcode.com/problems/squares-of-a-sorted-array/description/
 */
namespace LeetCode
{
    public class SortedSquares
    {
        public SortedSquares() { }

        public int[] Solution(int[] nums)
        {
            int[] result = new int[nums.Length];
            int i = nums.Length - 1;

            for (int left = 0, right = nums.Length - 1; left <= right;)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    result[i--] = nums[left] * nums[left++];
                }
                else
                {
                    result[i--] = nums[right] * nums[right--];
                }
            }

            return result;
        }

    }
}
