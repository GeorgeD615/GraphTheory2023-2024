// See https://aka.ms/new-console-template for more information
using Davlyatshin;


var result = Solution.GardenNoAdj(4, [[1, 2], [3, 4]]);
Console.WriteLine(string.Join(" ", result));

var result2 = Solution.AllPathsSourceTarget([[1, 2], [3], [3], []]);
for (int i = 0; i < result2.Count; i++)
{
    for (int j = 0; j < result2[i].Count; j++)
    {
        Console.Write(result2[i][j] + " ");
    }
    Console.WriteLine();
}

var result3 = Solution.MinCostConnectPoints([[0, 0], [2, 2], [3, 10], [5, 2], [7, 0]]);
Console.WriteLine(result3);

var result4 = Solution.EdgeScore([1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]);
Console.WriteLine(result4);