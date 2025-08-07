namespace DataStructuresAndAlgorithms
{
    public class DepthFirstSearch
    {

        public static bool Search(BinaryNode<int>? node, int needle)
        {
            if (node == null) return false;

            if (node.Value == needle) return true;

            if(node.Value < needle)
            {
                return Search(node.Right, needle);
            }

            return Search(node.Left, needle);
        }


        /*
        Traversing a binary tree
        */

        public static List<int> PostOrderSearch(BinaryNode<int>? node)
        {
            var path = new List<int>();
            return PostOrderWalk(node, path);
        }

        private static List<int> PostOrderWalk(BinaryNode<int>? node, List<int> path)
        {
            // base case
            if (node == null)
            {
                return path;
            }

            //pre
            //path.Add(node.Value);

            //recurse
            PostOrderWalk(node.Left, path);
            PostOrderWalk(node.Right, path);
            path.Add(node.Value);

            //post
            return path;
        }

        public static List<int> InOrderSearch(BinaryNode<int>? node)
        {
            var path = new List<int>();
            return InOrderWalk(node, path);
        }

        private static List<int> InOrderWalk(BinaryNode<int>? node, List<int> path)
        {
            // base case
            if (node == null)
            {
                return path;
            }

            //pre
            //path.Add(node.Value);

            //recurse
            InOrderWalk(node.Left, path);
            path.Add(node.Value);
            InOrderWalk(node.Right, path);

            //post
            return path;
        }

        public static List<int> PreOrderSearch(BinaryNode<int>? node)
        {
            var path = new List<int>();
            return PreOrderWalk(node, path);
        }

        private static List<int> PreOrderWalk(BinaryNode<int>? node, List<int> path)
        {
            // base case
            if (node == null)
            {
                return path;
            }

            //pre
            path.Add(node.Value);

            //recurse
            PreOrderWalk(node.Left, path);
            PreOrderWalk(node.Right, path);

            //post
            return path;
        }
    }
}
