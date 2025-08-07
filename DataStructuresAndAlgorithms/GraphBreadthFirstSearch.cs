namespace DataStructuresAndAlgorithms
{
    using System.Collections.Generic;
    public class GraphBreadthFirstSearch
    {
        // 1. Previous array to store path - add parent at each recursion

        // 2. Seen array - an array of booleans - 1 per node.

        // 3. A Queue to store visited node

        private System.Collections.Generic.Queue<int> _queue = new System.Collections.Generic.Queue<int>();

        public int[] Search(
            int[][] graph,
            int source, 
            int needle)
        {
            var seen = new bool[graph.Length];
            seen[0] = true;

            _queue.Enqueue(source);

            var previous = new int[graph.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                previous[i] = -1;
            }

            do
            {
                var current = _queue.Dequeue();

                if(current == needle)
                {
                    break;
                }

                var adjacentNodes = graph[current];

                for(int i = 0; i < adjacentNodes.Length; i++)
                {
                    if (adjacentNodes[i] == 0)
                    {
                        continue;
                    }

                    if (seen[i])
                    {
                        continue;
                    }

                    seen[i] = true;
                    previous[i] = current;
                    _queue.Enqueue(i);
                }
            }

            while (_queue.Count > 0);

            // Build it backwards

            var start = needle;
            var path = new List<int>();

            while (previous[start] != -1) 
            { 
                path.Add(start);
                start = previous[start];
            }

            if(path.Count == 0)
            {
                return [];
            }

            var reversed = path.OrderBy(i => i).Reverse().ToList();
            reversed.Insert(0, source);

            return reversed.ToArray();
        }
    }
}
