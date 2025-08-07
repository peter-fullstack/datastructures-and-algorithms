namespace DataStructuresAndAlgorithms
{
    using System.Collections.Generic;
    public class GraphDepthFirstSearch
    {
        // 1. Previous array to store path - add parent at each recursion

        // 2. Seen array - an array of booleans - 1 per node.

        // 3. A Queue to store visited node

        public int[] Search(
            List<List<WeightedEdge>> graph,
            int source, 
            int needle)
        {
            var seen = new bool[graph.Count];
            
            Queue<int> path = new Queue<int>();

            Walk(graph, source, needle, seen, path);

            return path.ToArray();
        }

        private bool Walk(
            List<List<WeightedEdge>> adjacencyList,
            int current,
            int needle,
            bool[] seen,
            Queue<int> path)
        {

            if(current == needle)
            {
                path.Enqueue(current);
                return true;
            }

            if (seen[current])
            {
                return false;
            }

            seen[current] = true;

            //pre
            path.Enqueue(current);

            // recurse

            var currentsEdges = adjacencyList[current];

            if(currentsEdges.Count == 0)
            {
                return false;
            }

            for( int i = 0; i < currentsEdges.Count; i++)
            {
                var edge = currentsEdges[i];
                if(Walk(adjacencyList, edge.To, needle, seen, path))
                {
                    return true;
                }
            }

            // post
            path.Dequeue();

            return false;
        }
    }

    public class WeightedEdge
    {
        public int To { get; set; }
        public int Weight { get; set; }

    }
}
