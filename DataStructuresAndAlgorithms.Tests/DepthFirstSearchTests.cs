namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    public class DepthFirstSearchTests
    {
        [Fact]
        public void PreOrderDFS()
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


            var result = DepthFirstSearch.PreOrderSearch(A);

            Assert.Equal([1, 2, 4, 5, 3, 6, 7], result);
        }

        [Fact]
        public void InOrderDFS()
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


            var result = DepthFirstSearch.InOrderSearch(A);

            Assert.Equal([4, 2, 5, 1, 6, 3, 7], result);
        }

        [Fact]
        public void PostOrderDFS()
        {
         /*
            Binary Tree Depth First Pre Order Search
         
                      1
                 2         3
             4      5   6     7

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


            var result = DepthFirstSearch.PostOrderSearch(A);

            Assert.Equal([4, 5, 2, 6, 7, 3, 1], result);
        }
    }
}
