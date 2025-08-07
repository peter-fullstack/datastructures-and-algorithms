namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    public class BreadthFirstSearchTests
    {
        [Fact]
        public void SearchWhenNeedleInTree()
        {
            /*
             Binary Tree Depth First Pre Order Search
                     1
                2        3
             4     5   6   7

             */
            var A = new BinaryNode<int>(1);
            var ALeft = new BinaryNode<int>(2);
            var ARight = new BinaryNode<int>(3);

            var ALeftLeft = new BinaryNode<int>(4);
            var ALeftRight = new BinaryNode<int>(5);
            ALeft.Left = ALeftLeft;
            ALeft.Right = ALeftRight;

            var ARightLeft = new BinaryNode<int>(6);
            var ARightRight = new BinaryNode<int>(7);

            ARight.Left = ARightLeft;
            ARight.Right = ARightRight;

            A.Left = ALeft;
            A.Right = ARight;

            var result = BreadthFirstSearch.Search(A, 5);

            Assert.True(result);
        }

        [Fact]
        public void SearchWhenNeedleNotInTree()
        {
            /*
          Binary Tree Depth First Pre Order Search
                  1
             2        3
          4     5   6   7

          */
            var A = new BinaryNode<int>(1);
            var ALeft = new BinaryNode<int>(2);
            var ARight = new BinaryNode<int>(3);

            var ALeftLeft = new BinaryNode<int>(4);
            var ALeftRight = new BinaryNode<int>(5);
            ALeft.Left = ALeftLeft;
            ALeft.Right = ALeftRight;

            var ARightLeft = new BinaryNode<int>(6);
            var ARightRight = new BinaryNode<int>(7);

            ARight.Left = ARightLeft;
            ARight.Right = ARightRight;

            A.Left = ALeft;
            A.Right = ARight;


            var result = BreadthFirstSearch.Search(A, 9);

            Assert.False(result);
        }
    }
}
