using System;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            //first we compare the value we are searching for with the root node
            if (root == null)

                return false;

            //if the integer value of the element we are searching for and that of the node we are currently on match then our tree contains the element we are searching for 
            if (Convert.ToInt32(value) == Convert.ToInt32(root.Value))
                return true;

            //if we can't get a match we need to search the left nodes of the tree recursively until we reach the end
            if (Convert.ToInt32(value) < Convert.ToInt32(root.Value))
                return Contains(root.Left, value);

            //if we can't get a match we also need to search the right nodes of the tree recursively until we reach the end
            else
                return Contains(root.Right, value);

        }

        public static void Main(string[] args)
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(Contains(n2, 3));
        }
    }
}
