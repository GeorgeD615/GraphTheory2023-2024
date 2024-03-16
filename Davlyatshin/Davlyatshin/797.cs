namespace Davlyatshin
{
    public static partial class Solution
    {
        public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var ans = new List<IList<int>>();
            DFS(graph, 0, new List<int>() { 0 }, ans);
            return ans;
        }

        private static void DFS(int[][] graph, int u, List<int> path, List<IList<int>> ans)
        {
            if (u == graph.GetLength(0) - 1)
            {
                ans.Add(new List<int>(path));
                return;
            }

            for (int i = 0; i < graph[u].Length; ++i)
            {
                path.Add(graph[u][i]);
                DFS(graph, graph[u][i], path, ans);
                path.RemoveAt(path.Count - 1);
            }
        }

    }
}
