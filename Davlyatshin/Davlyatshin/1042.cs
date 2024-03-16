namespace Davlyatshin
{
    public static partial class Solution
    {
        public static int[] GardenNoAdj(int n, int[][] paths)
        {
            var graph = new List<int>[n];
            for (int i = 0; i < n; ++i)
                graph[i] = new List<int>();

            foreach (var path in paths)
            {
                graph[path[0] - 1].Add(path[1] - 1);
                graph[path[1] - 1].Add(path[0] - 1);
            }

            int[] result = new int[n];

            var used = new bool[4];

            for (int i = 0; i < n; ++i)
            {
                foreach (var vertex in graph[i])
                    if (result[vertex] != 0)
                        used[result[vertex] - 1] = true;
                for (int j = 0; j < 4; ++j)
                    if (!used[j])
                    {
                        result[i] = j + 1;
                        break;
                    }
                for (int k = 0; k < 4; ++k)
                    used[k] = false;
            }

            return result;
        }
    }
}
