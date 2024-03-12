using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * [https://leetcode.com/problems/palindrome-number/description/]
 */
namespace LeetCode
{
    public class PalindromeNumber
    {
        public PalindromeNumber() { }

        public bool Solution(int x)
        {
            if(x < 0) return false;
            if (x >= 0 && x < 10) return true;

            int number = x;
            int polindrome = 0;

            while (number > 0)
            {
                polindrome = (polindrome*10) + number%10;
                number = number/10;
            }

            return polindrome == x;
        }
    }
}
