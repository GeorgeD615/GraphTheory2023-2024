using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Davlyatshin
{
    public partial class Solution
    {
        private int[] dsuTree;
        private void MakeSet(int v)
        {
            dsuTree[v] = v;
        }

        private int Find(int v)
        {
            if (dsuTree[v] == v) return v;
            return dsuTree[v] = Find(dsuTree[v]);
        }

        private void Union(int u, int v)
        {
            u = Find(u);
            v = Find(v);
            dsuTree[u] = v;
        }

        public bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
        {
            var result = new bool[queries.Length];
            dsuTree = new int[n];

            for(int i = 0; i < n; ++i)
                MakeSet(i);

            edgeList = edgeList.OrderBy(edje => edje[2]).ToArray();

            for (int i = 0; i < queries.Length; i++)
                queries[i] = [queries[i][0], queries[i][1], queries[i][2], i];

            queries = queries.OrderBy(query => query[2]).ToArray();

            int k = 0;
            for(int i = 0; i < queries.Length; ++i)
            {
                int[] query = queries[i];
                while (k < edgeList.Length && edgeList[k][2] < query[2])
                {
                    int u = edgeList[k][0];
                    int v = edgeList[k][1];
                    Union(u, v);
                    ++k;
                }
                int p = query[0];
                int q = query[1];
                int queryIndex = query[3];
                if (Find(p) == Find(q))
                {
                    result[queryIndex] = true;
                }
            }
            return result;
        }
    }
}
