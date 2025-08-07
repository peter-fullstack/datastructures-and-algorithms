namespace DataStructuresAndAlgorithms
{
    public class InsertIntoBinaryTree
    {
        /*
        Assumes 'strong ordering'

        Every value left is less than or equal to the value of its parent
        Every value right is greater than its parent
        
                                20
                         10            30
                     5       15     25      35
         
         */

        
        public static void Insert(BinaryNode<int>? node, int value)
        {
            if (node == null)
            {
                return;
            }
                                
            if (node.Value < value)
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryNode<int>(value);
                }
                else
                {
                    Insert(node.Right, value);
                }
            }
            else if (node.Value >= value)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryNode<int>(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }
        }

        /*
        When selecting a node for deletion:

        case 1) no children - delete
        case 2) one child - set parent to child

        case 3) two children
            - find largest value in left hand child by going all right
            - find smallest on right hand side by going all left 
        
        Which to choose - consider the height of each subtree and aim for 
        a condensed binary tree.

        Rotation algorithsm try to balance a tree - AVL and Black Red
        */


        public static void Delete(BinaryNode<int> node, int value)
        {


        }
    }
}
