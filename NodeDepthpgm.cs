using System;

public class NodeDepthsPgm {
  public static int NodeDepths(BinaryTree root) {
     return NodeDepths(root, 0);
  }

  public static int NodeDepths(BinaryTree root, int depth)
  {
      if(root==null) return 0;
      return depth+ NodeDepths(root.left,depth+1) +  
          NodeDepths(root.right,depth+1);
  }

  public class BinaryTree {
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value,int nodeDepth=0) {
      this.value = value;
      left = null;
      right = null;
    }
  }
}
