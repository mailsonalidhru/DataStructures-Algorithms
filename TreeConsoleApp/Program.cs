using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS.Trees;
using Trees;

namespace TreeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Tree Example where Nodes are added manually and there is a pointer to ROOT
            clsBinaryTree<int> binTree = new clsBinaryTree<int>();
            BinaryTreeNode<int> left = new BinaryTreeNode<int>(5);
            BinaryTreeNode<int> right = new BinaryTreeNode<int>(7);
            binTree.Root = new BinaryTreeNode<int>(6);
            binTree.Root.Left = new BinaryTreeNode<int>(5);
            binTree.Root.Right = new BinaryTreeNode<int>(7);

            //Binary Search Tree Example
            clsBinarySearchTree<int> bstTree = new clsBinarySearchTree<int>();
            bstTree.Add(90);
            bstTree.Add(50);
            bstTree.Add(150);
            bstTree.Add(20);
            bstTree.Add(75);
            bstTree.Add(95);
            bstTree.Add(175);
            bstTree.Add(5);
            bstTree.Add(25);
            bstTree.Add(66);
            bstTree.Add(80);
            bstTree.Add(92);
            bstTree.Add(111);
            bstTree.Add(166);
            bstTree.Add(200);

            List<int> lst = bstTree.InOrderTraversal();
            Console.WriteLine("Inorder Traversal\n");
            lst.ForEach(Console.WriteLine);

            List<int> lstPreOrder = bstTree.PreOrderTraversal();
            Console.WriteLine("Pre-Order Traversal\n");
            lstPreOrder.ForEach(Console.WriteLine);

            List<int> lstPostOrder = bstTree.PostOrderTraversal();
            Console.WriteLine("Post-Order Traversal\n");
            lstPostOrder.ForEach(Console.WriteLine);

            Console.ReadLine();

        }
    }
}
