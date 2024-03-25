namespace Davlyatshin
{
    public partial class Solution
    {
        public int MaximumDetonation(int[][] bombs)
        {
            var graph = new List<int>[bombs.Length];
            for(int i = 0; i < graph.Length; ++i)
                graph[i] = new();


            for(int i = 0; i < bombs.Length; ++i)
            {
                for(int j = 0; j < bombs.Length; ++j)
                {
                    if (i == j)
                        continue;

                    if (CheckBombDistanse(bombs[i], bombs[j]))
                        graph[i].Add(j);
                }
            }

            int maxResult = 0;

            for (int i = 0; i < graph.Length; ++i)
            {
                Queue<int> queue = new();
                queue.Enqueue(i);

                var visited = new bool[graph.Length];
                visited[i] = true;
                int countExplosion = 0;

                while (queue.Any())
                {
                    int currentIndex = queue.Dequeue();
                    ++countExplosion;

                    for (int j = 0; j < graph[currentIndex].Count; ++j)
                    {
                        var nextBomb = graph[currentIndex][j];
                        if (!visited[nextBomb])
                        {
                            visited[nextBomb] = true;
                            queue.Enqueue(nextBomb);
                        }
                    }
                }

                maxResult = Math.Max(maxResult, countExplosion);
            }

            return maxResult;
        }

        private bool CheckBombDistanse(int[] bombA, int[] bombB)
        {
            return (long)bombA[2] * bombA[2] >= (long)(bombA[0] - bombB[0]) * (bombA[0] - bombB[0]) +
                (long)(bombA[1] - bombB[1]) * (bombA[1] - bombB[1]);
        }
    }
}
