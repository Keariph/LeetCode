using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * [https://leetcode.com/problems/roman-to-integer/description/]
 */
namespace LeetCode
{
    public class RomanToInteger
    {
        public RomanToInteger() { }

        public int Solution(string s)
        {
            int result = 0;
            Dictionary<char, int> romanToInteger = new Dictionary<char, int>();
            romanToInteger['I'] = 1;
            romanToInteger['V'] = 5;
            romanToInteger['X'] = 10;
            romanToInteger['L'] = 50;
            romanToInteger['C'] = 100;
            romanToInteger['D'] = 500;
            romanToInteger['M'] = 1000;

            int now = 0;
            int next = 0;

            for(int i = 0; i < s.Length - 1;  i++)
            {
                romanToInteger.TryGetValue(s[i], out now);
                romanToInteger.TryGetValue(s[i +1 ], out next);

                if (now < next)
                {
                    result -= now;
                }
                else
                {
                    result += now;
                }
            }

            romanToInteger.TryGetValue(s[s.Length - 1], out now);
            return result + now;
        }
    }
}
