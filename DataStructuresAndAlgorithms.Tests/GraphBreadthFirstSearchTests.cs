namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    public class GraphBreadthFirstSearchTests
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

            int[][] graph =
            [
                [0, 1, 0, 1],
                [0, 0, 0, 0],
                [1, 0, 0, 0],
                [0, 1, 1, 0]
            ];

            var graphDFS = new GraphBreadthFirstSearch();

            // Starting at Node 0 return the path to Node 2
            var path = graphDFS.Search(graph, 0, 2);

            Assert.Equal(3, path.Length);
            Assert.Equal([0, 3, 2], path);

        }
    }
}
