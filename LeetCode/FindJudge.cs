using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /**
     * [Задача на leetcode](https://leetcode.com/problems/find-the-town-judge/description/)
     */
namespace LeetCode
{
    public class FindJudge
    {
        public FindJudge() { }

        public int Solution(int n, int[][] trust)
        {
            int judge = 0;
            int[] principal = new int[n];//доверительное лицо
            int[] trusted = new int[n];//доверенное лицо

            for (int i = 0; i < trust.Length; i++)
            {
                principal[trust[i][0] - 1]++;
                trusted[trust[i][1] - 1]++;
            }

            for (int i = 0; i < n; i++)
            {
                if (trusted[i] == n - 1 && principal[i] == 0)
                {
                    judge = i + 1;
                    return judge;
                }
            }

            return -1;
        }
    }
}
