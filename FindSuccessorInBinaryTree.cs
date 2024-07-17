
using System;
using System.Collections.Generic;


// O(n) time and O(n) space
public class FindSuccessorInBinaryTree {
  // This is an input class. Do not edit.
  public class BinaryTree {
    public int value;
    public BinaryTree left = null;
    public BinaryTree right = null;
    public BinaryTree parent = null;

    public BinaryTree(int value) {
      this.value = value;
    }
  }

  public BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node) {
    List<BinaryTree> inorderTraversalOrder = new List<BinaryTree>();
    getInOrderTraversalOrder(tree, inorderTraversalOrder);
    for(int i = 0; i < inorderTraversalOrder.Count; i++)
    {
        BinaryTree currentNode = inorderTraversalOrder[i];

        if(currentNode != node)
        {
            continue;
        }

        if( i == inorderTraversalOrder.Count - 1)
        {
            return null;
        }
        return inorderTraversalOrder[i+1];
    }
    return null;
  }

    void getInOrderTraversalOrder(BinaryTree node, List<BinaryTree> order){
        if(node == null)
        {
            return;
        }

        getInOrderTraversalOrder(node.left, order);
        order.Add(node);
        getInOrderTraversalOrder(node.right, order);
    }
}


// Problem statement
//   Write a function that takes in a Binary Tree (where nodes have an additional
//   pointer to their parent node) as well as a node contained in that tree and
//   returns the given node's successor.

//   A node's successor is the next node to be visited (immediately after the given
//   node) when traversing its tree using the in-order tree-traversal technique. A
//   node has no successor if it's the last node to be visited in the in-order
//   traversal.

//   If a node has no successor, your function should return None /null.

//   Each BinaryTree  node has an integer value, a parent node, a left child node, and a right child node.
//   children nodes can either be Binary Tree  nodes themselves or None/null

  
