using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * https://leetcode.com/problems/power-of-two/description/
 */
namespace LeetCode
{
    public class IsPowerOfTwo
    {
        public IsPowerOfTwo() { }

        public bool Solution(int n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
