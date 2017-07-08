using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS.Trees;

namespace Trees
{
    // Binary Search Tree(BST) efficient than non-BST tree
    public class clsBinarySearchTree<T>
    {
        BinaryTreeNode<T> _root;
 
        public clsBinarySearchTree() { _root = null; }

        public void Clear() { _root = null; }

        public BinaryTreeNode<T> Root
        {
            get { return _root; }
            set { _root = value; }
        }

        public virtual int Compare(T nodeValue, T searchValue)
        {
            return Comparer<T>.Default.Compare(nodeValue, searchValue);
        }

        public bool Contains(T data)
        {
            BinaryTreeNode<T> current = _root;
            while (current != null)
            {
                int result = Compare(current.value, data);
                if (result == 0)
                    return true; //Found
                else if (result > 0)
                {
                    //Search in Left Sub-Tree
                    current = current.Left;
                }
                else if (result < 0)
                {
                    //SErach in Right Sub-Tree
                    current = current.Right;
                }
            }
            return false; //Not found
        }

        public void Add(T data)
        {
            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>(data);
            // If Root is NULL then add Data to Root Node
            if (_root == null)
            {
                _root = newNode;
                return;
            }
            //Search exactly where it needs to be place
            BinaryTreeNode<T> current = _root;
            BinaryTreeNode<T> parent = _root;
            bool leftNode = false;
            while (current != null)
            {
                int result = Compare(current.value, data);
                if (result == 0)
                    //Duplicate Found
                    return;
                else if (result > 0)
                {
                    //Search in Left Sub-Tree
                    parent = current;
                    current = current.Left;
                    leftNode = true;
                }
                else if (result < 0)
                {
                    //SErach in Right Sub-Tree
                    parent = current;
                    current = current.Right;
                    leftNode = false;
                }
            }
            if (leftNode)
            {
                parent.Left = newNode;
            }
            else
            {
                parent.Right = newNode;
            }
        }

        //Left -> Current -> Right
        public List<T> InOrderTraversal()
        {
            //Stack is ideal here if we dont need a recursive function
            Stack<BinaryTreeNode<T>> stkNodes = new Stack<BinaryTreeNode<T>>();
            BinaryTreeNode<T> current = _root;
            List<T> lstValues = new List<T>();
            while (current != null)
            {
                stkNodes.Push(current);
                current = current.Left;
            }
            while (current == null && stkNodes.Count != 0)
            {
                current = stkNodes.Pop();
                lstValues.Add(current.value);
                current = current.Right;
                while (current != null)
                {
                    stkNodes.Push(current);
                    current = current.Left;
                }
            }
            return lstValues;
        }

        // Current -> Left -> Right
        public List<T> PreOrderTraversal()
        {
            Stack<BinaryTreeNode<T>> stkNodes = new Stack<BinaryTreeNode<T>>();
            BinaryTreeNode<T> current = _root;
            List<T> lstValues = new List<T>();
            while (current != null)
            {
                lstValues.Add(current.value);
                stkNodes.Push(current);
                current = current.Left;
            }
            while (current == null && stkNodes.Count != 0)
            {
                current = stkNodes.Pop();
                current = current.Right;
                while (current != null)
                {
                    lstValues.Add(current.value);
                    stkNodes.Push(current);
                    current = current.Left;
                }
            }
            return lstValues;
        }

        // Left -> Right -> Current
        public List<T> PostOrderTraversal()
        {
            Stack<BinaryTreeNode<T>> stkNodes = new Stack<BinaryTreeNode<T>>();
            BinaryTreeNode<T> current = _root;
            List<T> lstValues = new List<T>();

            while (true)
            {
                while (current != null)
                {
                    // Push root's right Node and then root to stack
                    if (current.Right != null)
                        stkNodes.Push(current.Right);
                    stkNodes.Push(current);
                    // Set root as root's left Node
                    current = current.Left;
                }

                //Pop an item from stack and set it as root
                current = stkNodes.Pop();

                //If the popped item has a right Node and the right Node is not processed yet, then make sure
                // right child is processed before parent
                if (current.Right != null && stkNodes.Count != 0 && stkNodes.Peek() == current.Right)
                {
                    stkNodes.Pop(); // Remove right Node from stack 
                    stkNodes.Push(current); //Push current back to stack
                    current = current.Right; // Process Right Node
                }
                else
                {
                    lstValues.Add(current.value);
                    current = null;
                }
                if(stkNodes.Count <= 0)
                {
                    break;
                }
            }
            return lstValues;
        }

    }
}