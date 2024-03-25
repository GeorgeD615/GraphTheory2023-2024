using Davlyatshin;

var Solution = new Solution();

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


var result5 = Solution.DistanceLimitedPathsExist(13, [[9, 1, 53], [3, 2, 66], [12, 5, 99], [9, 7, 26], [1, 4, 78], [11, 1, 62], 
                                                    [3, 10, 50], [12, 1, 71], [12, 6, 63], [1, 10, 63], [9, 10, 88], [9, 11, 59], 
                                                    [1, 4, 37], [4, 2, 63], [0, 2, 26], [6, 12, 98], [9, 11, 99], [4, 5, 40], 
                                                    [2, 8, 25], [4, 2, 35], [8, 10, 9], [11, 9, 25], [10, 11, 11], [7, 6, 89], 
                                                    [2, 4, 99], [10, 4, 63]], 
                                                    [[9, 7, 65], [9, 6, 1], [4, 5, 34], [10, 8, 43], 
                                                    [3, 7, 76], [4, 2, 15], [7, 6, 52], [2, 0, 50], [7, 6, 62], 
                                                    [1, 0, 81], [4, 5, 35], [0, 11, 86], [12, 5, 50], 
                                                    [11, 2, 2], [9, 5, 6], [12, 0, 95], [10, 6, 9], [9, 4, 73], 
                                                    [6, 10, 48], [12, 0, 91], [9, 10, 58], [9, 8, 73], [2, 3, 44], 
                                                    [7, 11, 83], [5, 3, 14], [6, 2, 33]]);
Console.WriteLine(string.Join(" ", result5));

var result6 = Solution.MaximumDetonation([[1, 2, 3], [2, 3, 1], [3, 4, 2], [4, 5, 3], [5, 6, 4]]);
Console.WriteLine(result6);