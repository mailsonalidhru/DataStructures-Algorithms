using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Trees
{
    // Collection of Node<T>
    public class NodeList<T> : System.Collections.ObjectModel.Collection<Node<T>>
    {
        public NodeList() : base() { }
        public NodeList(int NumberOfNodes)
        {
            for(int i=0; i < NumberOfNodes; i++)
            {
                base.Items.Add(new Node<T>());
            }
        }
    }
    //Represents a Node for a general tree, which can have arbitary num of children
    public class Node<T>
    {
        private T _value;
        private NodeList<T> _neighbors;

        public T value {
            get{
                return this._value;
            }
            set{
                this._value = value;
            }
        }

        public NodeList<T> Neighbors
        {
            get
            {
                return this._neighbors;
            }
            set
            {
                this._neighbors = value;
            }
        }

        public Node() { }
        public Node(T data) : this(data, null) { }
        public Node(T data, NodeList<T> links)
        {
            this._value = data;
            this._neighbors = links;
        }
    }

    //Inherits from Node
    public class BinaryTreeNode<T>: Node<T>
    {
        public BinaryTreeNode(T data): base(data, null) { }
        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            base.value = data;
            NodeList<T> children = new NodeList<T>(2);
            children[0] = left;
            children[1] = right;
            base.Neighbors = children;
        }
        public BinaryTreeNode<T> Left
        {
            get {
                if (base.Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbors[0];
            }
            set {
                if (base.Neighbors == null)
                {
                    base.Neighbors = new NodeList<T>(2);
                    base.Neighbors[1] = null;
                }
                    
                base.Neighbors[0] = value;
            }
        }
        public BinaryTreeNode<T> Right
        {
            get
            {
                if (base.Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbors[1];
            }
            set
            {
                if (base.Neighbors == null)
                {
                    base.Neighbors = new NodeList<T>(2);
                    base.Neighbors[0] = null;
                }
                base.Neighbors[1] = value;
            }
        }
    }
}
