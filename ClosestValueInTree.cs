using System;

public class ClosestValueInTree {
  public static int FindClosestValueInBst(BST tree, int target) {
      return FindClosestValueInBst(tree,target,tree.value);
      }
 public static int FindClosestValueInBst(BST tree, int target, int closest)
    {
    var currentNode = tree;
    while(currentNode!=null)
    {
        if(Math.Abs(target-closest)>Math.Abs(target-currentNode.value))
        {
            closest = currentNode.value;
        }
        if(target<currentNode.value)
        {
            currentNode = currentNode.left;
        }
        else if(target>currentNode.value)
        {
            currentNode = currentNode.right;
        }
        else
        {
            break;
        }
    }
        return closest;
  }

  public class BST {
    public int value;
    public BST left;
    public BST right;

    public BST(int value) {
      this.value = value;
    }
  }
}
