namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    public class TreeCompareTests
    {
        [Fact]
        public void Test1()
        {
            var A = new BinaryNode<int>(1);
            var ALeft = new BinaryNode<int>(2);
            var ARight = new BinaryNode<int>(3);
            A.Left = ALeft;
            A.Right = ARight;

            var B = new BinaryNode<int>(1);
            var BLeft = new BinaryNode<int>(2);
            var BRight = new BinaryNode<int>(3);
            B.Left = BLeft;
            B.Right = BRight;

            var result = BinaryTree<int>.Compare(A, B);

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var A = new BinaryNode<int>(1);
            var ALeft = new BinaryNode<int>(2);
            var ARight = new BinaryNode<int>(3);
            A.Left = ALeft;
            A.Right = ARight;

            var B = new BinaryNode<int>(1);
            var BLeft = new BinaryNode<int>(6);
            var BRight = new BinaryNode<int>(7);
            B.Left = BLeft;
            B.Right = BRight;

            var result = BinaryTree<int>.Compare(A, B);

            Assert.False(result);
        }
    }
}
