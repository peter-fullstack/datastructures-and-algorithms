namespace DataStructuresAndAlgorithms
{
    public class BinaryTree<T> where T: new()
    {
        public static bool Compare(BinaryNode<T> A, BinaryNode<T> B)
        {
            if(A == null && B == null)
            {
                return true;
            }

            if (A == null || B == null)
            {
                return false;
            }

            if (!A!.Value.Equals(B.Value))
            {
                return false;
            }


            return Compare(A.Left, B.Left) && Compare(A.Right, B.Right);
        }
    }
}
