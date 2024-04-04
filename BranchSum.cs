using System;
using System.Collections.Generic;

public class BranchSumsProgram {
 // O(n) time and O(n) space
  public class BinaryTree {
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value) {
      this.value = value;
      this.left = null;
      this.right = null;
    }
  }

    public static List<int> BranchSums(BinaryTree root)
    {
        int sum =0;
        HashSet<int> visitedNodes = new HashSet<int>();
        List<int> outputSum = new List<int>();
        BranchSums(root,sum,visitedNodes,outputSum);
        return outputSum;
    }

  public static void BranchSums(BinaryTree tree,int sum,HashSet<int> visitedNodes,List<int> outputSum)
  {
    if(tree==null)
        return;
    sum+=tree.value;
        if(tree.left == null && tree.right == null)
        {
            outputSum.Add(sum);
            sum=0;
        }
            BranchSums(tree.left,sum,visitedNodes,outputSum);
            BranchSums(tree.right,sum,visitedNodes,outputSum);
      return;
  }
}