using System;

public class ClosestValueInTreeRecursive {
  public static int FindClosestValueInBst(BST tree, int target) {
  return FindClosestValueInBst(tree,target,tree.value);
  } 
  //Average O(logn) time  and O(logn) space
  //O(n) time and O(n) space
    public static int FindClosestValueInBst(BST tree, int target, int closest) {
        if(Math.Abs(target-closest)>Math.Abs(target-tree.value))
        {
            closest = tree.value;
        }
        if(tree.left!=null&&target<tree.value)
        {
            return FindClosestValueInBst(tree.left, target, closest);
        }
        else if(target>tree.value&&tree.right!=null)
        {
            return FindClosestValueInBst(tree.right,target,closest);
        }
        else
        {
            return closest;
        }
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
