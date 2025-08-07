namespace DataStructuresAndAlgorithms
{
    public class BinaryNode<T>
    {
        public T Value { get; set; }

        public BinaryNode<T>? Left { get; set; }
        public BinaryNode<T>? Right { get; set; }

        public BinaryNode(T value)
        {
            Value = value;
        }

        public BinaryNode()
        {
        }
    }
}
