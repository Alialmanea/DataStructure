using System;

namespace Binary_Search_Tree_Deletion
{
    class BinarySearchTree
    {
        //create Node
        class Node
        {
            public int data;
            public Node left;
            public Node right;
            
            public Node(int value)
            {
                data = value;
                left = null;
                right = null;
            }
        }
        //the root of  bst
        Node root;
        BinarySearchTree()
        {
            root = null; //root of the node will be Empty
        }
        
        //** This method calls insertRec()
        void insert(int key)
        {
            root = insertRec(root, key);
        }
        
        
        
        /* A recursive function to insert a new key in BST */
        
        Node insertRec(Node root, int key)
        {
            /* If the tree is empty, return a new node */
            
            if (root == null)
            {
                root = new Node(key);
                
                return root;
                
            }
            /* Otherwise, recur down the tree */
            if (key < root.data)
            root.left = insertRec(root.left, key);
            else if (key > root.data)
            root.right = insertRec(root.right, key);
            /* return the (unchanged) node pointer */
            
            return root;
        }
        
        /* Given a binary tree, print
         
         its nodes in Postorder*/
        
        void printPostorder(Node node)            //left,right,root
        {
            
            if (node == null)
            return;
            
            // first recur on left subtree
            printPostorder(node.left);
            // then recur on right subtree
            
            printPostorder(node.right);
            
            // now deal with the node
            
            Console.Write(node.data + " ");
        }
        /* Given a binary tree, print
         its nodes in inorder*/
        void printInorder(Node node)            //left,root,right
        {
            
            if (node == null)
            return;
            /* first recur on left child */
            
            printInorder(node.left);
            
            /* then print the data of node */
            
            Console.Write(node.data + " ");
            
            /* now recur on right child */
            
            printInorder(node.right);
        }
        
        /* Given a binary tree, print
         
         its nodes in preorder*/
        
        
        
        void printPreorder(Node node)            //root,lrft,right
        {
            
            if (node == null)
            
            return;
            
            
            
            /* first print data of node */
            
            Console.Write(node.data + " ");
            
            
            
            /* then recur on left sutree */
            
            printPreorder(node.left);
            /* now recur on right subtree */
            
            printPreorder(node.right);
        }
        
        
        
        // Wrappers over above recursive functions
        
        
        
        // This method mainly calls Postorder()
        
        void printPostorder()
        {
            
            printPostorder(root);
            
        }
        
        // This method mainly calls InorderRec()
        
        void printInorder()
        
        {
            
            printInorder(root);
            
        }
        
        // This method mainly calls Preorder()
        
        void printPreorder()
        
        {
            
            printPreorder(root);
            
        }
        
        
        
        // This method mainly calls deleteRec()
        void delete(int data)
        {
            root = deleteRec(root, data);
        }
        
        /* A recursive function to insert a new key in BST */
        Node deleteRec(Node root, int data)
        {
            /* Base Case: If the tree is empty */
            if (root == null)
            return root;
            
            /* Otherwise, recur down the tree */
            if (data < root.data)
            root.left = deleteRec(root.left, data);
            else if (data > root.data)
            root.right = deleteRec(root.right, data);
            
            // if key is same as root's key, then This is the node
            // to be deleted
            else
            {
                // node with only one child or no child
                if (root.left == null)
                return root.right;
                else if (root.right == null)
                return root.left;
                
                // node with two children: Get the inorder successor (smallest
                // in the right subtree)
                root.data = FindMin(root.right);
                
                // Delete the inorder successor
                root.right = deleteRec(root.right, root.data);
            }
            
            return root;
        }
        
        
        
        
        int FindMin(Node root)
        {
            
            if (root == null)
            {
                Console.WriteLine("Error !>>>>The tree is Empty");
                return -1;
            }
            
            while (root.left != null)
            {
                
                root = root.left;
                
            }
            return root.data;
        }
        
        
        
        int FindMax(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Error !>>>>The tree is Empty");
                return -1;
            }
            
            while (root.right != null)
            {
                root = root.right;
            }
            return root.data;
        }
        
        
        
        int Max()
        {
            
            return FindMax(root);
        }
        
        int Min()
        {
            return FindMin(root);
        }
        
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            
            /* Let us create following BST
                  50
               /     \
              30      70
             /  \    /  \
            20   40 60   80 */
            
            tree.insert(50);
            tree.insert(30);
            tree.insert(20);
            tree.insert(40);
            tree.insert(70);
            tree.insert(60);
            tree.insert(80);
            
            System.Console.WriteLine("Inorder traversal of the given tree");
            tree.printInorder();
            
            System.Console.WriteLine("\nDelete 20");
            tree.delete(20);
            System.Console.WriteLine("Inorder traversal of the modified tree");
            tree.printInorder();
            
            System.Console.WriteLine("\nDelete 30");
            tree.delete(30);
            System.Console.WriteLine("Inorder traversal of the modified tree");
            tree.printInorder();
            
            System.Console.WriteLine("\nDelete 50");
            tree.delete(50);
            System.Console.WriteLine("Inorder traversal of the modified tree");
            tree.printInorder();
            Console.WriteLine("\n===========================================");
            Console.WriteLine("Max Number in Tree is : " + tree.Max());
            Console.WriteLine("Min Number in Tree is : " + tree.Min());
            Console.ReadLine();
        }
    }
}
