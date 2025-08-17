using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    internal class DepthFirstInOrderTraversal
    {
        public IList<int> InorderTraversal(BinaryNode<int> root)
        {
            var path = new List<int>();
            InOrderWalk(root, path);

            return path;
        }

        private IList<int> InOrderWalk(BinaryNode<int>? currentNode, List<int> path)
        {
            // base case
            if (currentNode == null)
            {
                return path;
            }

            InOrderWalk(currentNode.Left, path);
            path.Add(currentNode.Value);
            InOrderWalk(currentNode.Right, path);

            return path;
        }
    }
}
