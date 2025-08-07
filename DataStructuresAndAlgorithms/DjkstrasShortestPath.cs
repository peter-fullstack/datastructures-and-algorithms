namespace DataStructuresAndAlgorithms
{

    public class DijkstrasShortestPath
    {

        public List<int> DijkstraSearch(
            int source,
            int sink,
            List<List<WeightedEdge>> graph)
        {
            var seen = new bool[graph.Count];
            var distances = new int[graph.Count];
            var previous = new int[graph.Count];

            for (int i = 0; i < distances.Count(); i++)
            {
                distances[i] = 1_000_000_000;
            }

            for (int i = 0; i < previous.Count(); i++)
            {
                previous[i] = -1;
            }

            distances[source] = 0;

            while(HasUnvisited(seen, distances))
            {
                var current = GetLowestUnvisited(seen, distances);
                seen[current] = true;

                var adjecncies = graph[current];
                for( int i = 0; i <  adjecncies.Count(); i++) 
                { 
                    var edge = adjecncies[i];
                    if (seen[edge.To])
                    {
                        continue;
                    }

                    var distance = distances[current] + edge.Weight;
                    if(distance < distances[edge.To])
                    {
                        distances[edge.To] = distance;
                        previous[edge.To] = current;
                    }
                }
            }

            var result = new List<int>();
            var current2 = sink;

            while (previous[current2] != -1)
            {
                result.Add(current2);
                current2 = previous[current2];
            }


            return new List<int>();
        }
        private bool HasUnvisited(bool[] seen, int[] distances)
        {
            if(!seen.Any(s => s == false))
                return false;

            for (int i = 0; i < seen.Length; i++)
            {
                if (seen[i] && distances[i] > -1)
                {
                    return true;
                }
            }
                   
            return false;
        }

        private int GetLowestUnvisited(bool[] seen, int[] dsitances)
        {
            var index = -1;
            var lowestDistance = 1_000_000_000;

            for(int i = 0; i < seen.Length; i++)
            {
                if (seen[i])
                {
                    continue;
                }

                if(lowestDistance > dsitances[i])
                {
                    lowestDistance = dsitances[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
