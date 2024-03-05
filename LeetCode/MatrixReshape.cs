using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MatrixReshape
    {
        public MatrixReshape() { }

        public int[][] Solution(int[][] mat, int r, int c)
        {
            int rows = 0;
            int columns = 0;
            int[][] result = new int[r][];
            result[rows] = new int[c];

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    result[rows][columns] = mat[i][j];
                    columns++;

                    if (columns == c)
                    {
                        rows++;
                        columns = 0;
                    }
                }
            }

            return result;
        }
    }
}
