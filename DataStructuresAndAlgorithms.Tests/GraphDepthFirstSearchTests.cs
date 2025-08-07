namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    public class GraphDepthFirstSearchTests
    {
        [Fact]
        public void SearchWhenNeedleInTree()
        {
            /*
            Node Graph

                  0  ->  1
                  ^\__   ^
                  |    \ | 
                  2 < -  3

            Node 0 connects to 1 and 3
            Node 1 has no outgoing connections
            Node 2 connects to 0
            Node 3 connects to 1 and 2

            Adjacensy Matrix

                   0  1  2  3  
               0  [0, 1, 0, 1]
               1  [0, 0, 0, 0]
               2  [1, 0, 0, 0]
               3  [0, 1, 1, 0]

            */

            List<List<WeightedEdge>> graph = new List<List<WeightedEdge>>
            {
                new List<WeightedEdge>
                {
                    new WeightedEdge { To = 1, Weight = 8},
                    new WeightedEdge { To = 3, Weight = 9}, // Node 0 connects to 1 and 3
                },
                new List<WeightedEdge>(), // Node 1 has no connections
                new List<WeightedEdge>
                {
                    new WeightedEdge { To = 0, Weight = 11} // Node 2 connects to 0
                },
                new List<WeightedEdge>
                {
                    new WeightedEdge { To = 1, Weight = 6 },
                    new WeightedEdge { To = 2, Weight = 7 } // Node 3 connects to 1 and 2
                }
            };

            var graphDFS = new GraphDepthFirstSearch();

            // Starting at Node 0 return the path to Node 2
            var path = graphDFS.Search(graph, 0, 2);

            Assert.Equal(4, path.Length);
            Assert.Equal([0, 1, 3, 2], path);

        }
    }
}
