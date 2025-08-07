namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    public class InsertIntoBinaryTreeTests
    {
        [Fact]
        public void Test1()
        {
            var root = new BinaryNode<int>(20);
            var ALeft = new BinaryNode<int>(10);
            var ARight = new BinaryNode<int>(30);
            root.Left = ALeft;
            root.Right = ARight;

            var ALeftLeft = new BinaryNode<int>(5);
            var ALeftRight = new BinaryNode<int>(15);

            root.Left.Left = ALeftLeft;
            root.Left.Right = ALeftRight;

            var ARightLeft = new BinaryNode<int>(1);
            var ARightRight = new BinaryNode<int>(1);

            root.Right.Left = ARightLeft;
            root.Right.Right = ARightRight;

            InsertIntoBinaryTree.Insert(root, 17);

            Assert.Equal(17, ALeftRight?.Right?.Value);
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
