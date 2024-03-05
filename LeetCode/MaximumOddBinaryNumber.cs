using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * [Задача на leetcode](https://leetcode.com/problems/maximum-odd-binary-number/description/)
 */
namespace LeetCode
{
    public class MaximumOddBinaryNumber
    {
        public MaximumOddBinaryNumber() { }

        public string Solution(string s)
        {
            int ones = 0;
            int zeros = 0;
            string result = "";

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    ones++;
                }
            }

            zeros = s.Length - ones;

            for(int i = 0; i < ones - 1; i++) 
            {
                result += "1"; 
            }

            for(int i =0; i < zeros; i++)
            {
                result += "0";
            }

            result += "1";
            return result;
             
        }
    }
}
