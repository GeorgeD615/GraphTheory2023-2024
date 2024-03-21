namespace Davlyatshin
{
    public partial class Solution
    {
        public int EdgeScore(int[] edges)
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
