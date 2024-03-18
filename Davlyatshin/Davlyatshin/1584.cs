namespace Davlyatshin
{
    public static partial class Solution
    {
        public static int MinCostConnectPoints(int[][] points)
        {
            var dist = new int[points.Length];
            for (int i = 1; i < points.Length; ++i)
                dist[i] = int.MaxValue;

            for (int i = 0; i < points.Length - 1; ++i)
            {
                for (int j = i + 1; j < points.Length; ++j)
                {
                    dist[j] = Math.Min(dist[j], Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]));
                    if (dist[j] < dist[i + 1])
                    {
                        var tempPoint = points[j];
                        points[j] = points[i + 1];
                        points[i + 1] = tempPoint;

                        int tempDist = dist[j];
                        dist[j] = dist[i + 1];
                        dist[i + 1] = tempDist;
                    }
                }
            }

            return dist.Sum();
        }
    }
}
