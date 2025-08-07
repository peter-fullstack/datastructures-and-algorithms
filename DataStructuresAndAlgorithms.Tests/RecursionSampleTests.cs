namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    using System.Drawing;

    public class TreeTraversalTests
    {
        [Fact]
        public void Test1()
        {
           string[] maze = [
                "######E#",
                "#      #",
                "#S######"
                ];

            var start = new Point(2, 1);
            var end = new Point(6, 0);

            var result = RecursionSamples.MazeSolver(maze, '#', start, end);

            Assert.Equal(end, result?.pop());
        }
     }
}
