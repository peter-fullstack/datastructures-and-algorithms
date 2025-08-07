namespace DataStructuresAndAlgorithms
{
    public class BreadthFirstSearch
    {
        public static bool Search(BinaryNode<int>? node, int needle)
        {
            var queue = new System.Collections.Generic.Queue<BinaryNode<int>>();
            queue.Enqueue(node);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
          
                if(current?.Value == needle)
                {
                    return true;
                }

                if(current?.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current?.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return false;
        }
    }
}
