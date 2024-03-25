namespace Davlyatshin
{
    public partial class Solution
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var visited = new bool[rooms.Count];
            Queue<int> queue = new();
            queue.Enqueue(0);
            visited[0] = true;

            while (queue.Count > 0)
            {
                var currentRoom = queue.Dequeue();
                for(int i = 0; i < rooms[currentRoom].Count; ++i)
                {
                    var nextRoom = rooms[currentRoom][i];
                    if (!visited[nextRoom])
                    {
                        queue.Enqueue(nextRoom);
                        visited[nextRoom] = true;
                    }
                }
            }

            return !visited.Any(vert => vert == false);
        }
    }
}
