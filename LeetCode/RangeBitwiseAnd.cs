using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * https://leetcode.com/problems/bitwise-and-of-numbers-range/description/
 */
namespace LeetCode
{
    public class RangeBitwiseAnd
    {
        public RangeBitwiseAnd() { }

        public int Solution(int left, int right)
        {
            int step = 0;
            while (left != right)
            {
                left >>= 1;
                right >>= 1;
                ++step;
            }

            return left << step;
        }
    }
}
