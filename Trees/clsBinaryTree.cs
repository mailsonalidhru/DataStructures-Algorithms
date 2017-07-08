using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS.Trees;

namespace Trees
{
    public class clsBinaryTree<T>
    {
        private BinaryTreeNode<T> _root;
        public clsBinaryTree()
        {
            _root = null;
        }
        public virtual void Clear()
        {
            _root = null;
        }
        
        public BinaryTreeNode<T> Root
        {
            get { return _root; }
            set { _root = value; }
        }
    }

}
