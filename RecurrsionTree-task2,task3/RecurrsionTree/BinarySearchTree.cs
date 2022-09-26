using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurrsionTree
{
    class BinarySearchTree
    {
        class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        // Root of BST
        Node root;

        // Constructor
        BinarySearchTree() { root = null; }
        // This method mainly calls insertRec()
        void Insert(int key) { root = InsertRec(root, key); }

        /* A recursive function to insert a new key in BST */
        Node InsertRec(Node root, int key)
        {

            /* If the tree is empty, return a new node */
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            /* Otherwise, recur down the tree */
            if (key < root.key)
                root.left = InsertRec(root.left, key);
            else if (key > root.key)
                root.right = InsertRec(root.right, key);
            /* return the (unchanged) node pointer */
            return root;

        }
        
        void Inorder() { InorderRec(root); }
       
        // inorder traversing
        void InorderRec(Node root)
        {
            if (root != null)
            {
                InorderRec(root.left);
                Console.Write(root.key + " ");
                InorderRec(root.right);
            }
            
        }
        int maxDepth(Node node)
        {
            if (node == null)
                return -1;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = maxDepth(node.left);
                int rDepth = maxDepth(node.right);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }
        public static void Main(String[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

                //tree creation 
            tree.Insert(1);
            tree.Insert(10);
            tree.Insert(2);
            tree.Insert(20);
            tree.Insert(12);
            tree.Insert(11);
            tree.Insert(18);
            tree.Insert(17);
            tree.Insert(16);
            tree.Insert(19);
            tree.Insert(30);
          /*  tree.Insert(100);
            tree.Insert(200);
            tree.Insert(150);
            tree.Insert(120);
            tree.Insert(99);
            tree.Insert(123);
            tree.Insert(199);
*/

       
           tree.Inorder();
            Console.WriteLine();
            Console.WriteLine("Max Depth of this tree is :");
            Console.WriteLine(tree.maxDepth(tree.root)-1 ); 
           

            
        }
    }

}

