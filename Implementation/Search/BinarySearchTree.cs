using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Search
{
    public class BinarySearchTree
    {
        public static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        // Search
        public Node search(Node root, int key)
        {
            if (root == null || root.data == key)
                return root;
            if (root.data > key)
                return search(root.left, key);
            return search(root.right, key);
        }

        // Inorder traversal of BST
        public static void InorderRec(Node root)
        {
            if (root != null)
            {
                InorderRec(root.left);
                Console.WriteLine(root.data);
                InorderRec(root.right);
            }
        }

        public bool CheckIfBst(Node root)
        {
            return IsBST(root, int.MinValue, int.MaxValue);
        }

        public bool IsBST(Node node, int minKey, int maxKey)
        {
            if (node == null) return true;

            if (node.data < minKey || node.data > maxKey)
                return false;

            return IsBST(node.left, minKey, node.data - 1) &&
                IsBST(node.right, node.data + 1, maxKey);
        }

        public void DFSPreOrderTraversalRecursive(Node node)
        {
            if (node == null)
                return;
            //Visit()
            DFSPreOrderTraversalRecursive(node.left);
            DFSPreOrderTraversalRecursive(node.right);
        }

        public void DFSPreOrderTraversalIterative(Node node)
        {
            if (node == null)
                return;
            Stack<Node> s = new Stack<Node>();
            s.Push(node);

            while (s.Count != 0)
            {
                Node n = s.Pop();
                //visit
                if (node.right != null)
                {
                    s.Push(node.right);
                }
                if (node.left != null)
                {
                    s.Push(node.left);
                }
            }
        }

        public void DFSInOrderTraversalRecursive(Node node)
        {
            if (node == null)
                return;
            DFSInOrderTraversalRecursive(node.left);
            //visit(node)
            DFSInOrderTraversalRecursive(node.right);
        }

        public void DFSInOrderTraversalIterative(Node node)
        {
            if (node == null)
                return;
            Stack<Node> s = new Stack<Node>();
            Node current = node;

            while (s.Count != 0 || current != null)
            {
                if (current != null)
                {
                    s.Push(current);
                    current = current.left;
                }
                else
                {
                    current = s.Pop();
                    //Visit
                    current = current.right;
                }
            }
        }

        public void DFSPostOrderTraversalRecursive(Node node)
        {
            if (node == null)
                return;
            //visit(node)
            DFSPostOrderTraversalRecursive(node.left);
            DFSPostOrderTraversalRecursive(node.right);
        }

        public void BFSLevelOrderTraversalIterative(Node node)
        {

            //Write your code here
            if (node == null)
                return;

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);

            while (q.Count != 0)
            {
                Node n = q.Dequeue();
                Console.Write(n.data + " ");
                if (n.left != null)
                {
                    q.Enqueue(n.left);
                }
                if (n.right != null)
                {
                    q.Enqueue(n.right);
                }
            }
        }

        /// <summary>
        /// Find height or max depth of a binary tree
        /// </summary>
        public int FindHeight(Node node) {
            
                if (node == null)
                    return 0;
                else
                {
                    int lDepth = FindHeight(node.left);
                    int rDepth = FindHeight(node.right);

                    if (lDepth > rDepth)
                        return (lDepth + 1);
                    else
                        return (rDepth + 1);
                }
        }

        public Node Find(Node root, int data)
        {
            if (root == null || root.data == data)
                return root;

            if (root.data > data)
                return search(root.left, data);

            return search(root.right, data);
        }
    }
}
