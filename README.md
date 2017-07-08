# DataStructures-Algorithms
C# Data Structures and Algorithms. More Coming Soon....
 
1) Trees
  - clsBinaryTreeNode: 
      - Creates Node class: A generic class that could be used for tree with a nodelist that could store N number of child objects
      - Creates NodeList class: A class that could store list of Nodes
      - Creates BinaryTreeNode class: 
          - A binary tree is a special kind of tree, one that limits each node to no more than two children. 
          - A class that defines the structure of Binary Tree Node. Inherits from Node class. 
  - clsBinarySearchTree: (BST)
       - A binary search tree, or BST, is a binary tree whose nodes are arranged such that for every node n, all of the nodes in n's               left subtree have a value less than n, and all nodes in n's right subtree have a value greater than n.
      - Actual BST class with BinaryTreeNode created
      - Properties: Root
      - Methods: Compare, Contains, Add, Inorder, Preorder, PostOrder traversal (non-recursive)

Best Case: O(log N) 
Worst Case: O(n)
