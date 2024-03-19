using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davlyatshin
{
    public static partial class Solution
    {
        public static int EdgeScore(int[] edges)
        {
            var edgesScores = new long[edges.Length];
            for (int i = 0; i < edges.Length; ++i)
            {
                edgesScores[edges[i]] += i;
            }
            long maxScores = 0;
            int result = 0;
            for (int i = 0; i < edgesScores.Length; ++i)
            {
                if (edgesScores[i] > maxScores)
                {
                    maxScores = edgesScores[i];
                    result = i;
                }
            }
            return result;
        }
    }
}
