using System;
using System.Collections.Generic;

public class InvertBinaryTree {

    //O(n) time and O(n) space
  public static void InvertBinaryTreeSolution1(BinaryTree tree) {
        List<BinaryTree> queue = new List<BinaryTree>();
        queue.Add(tree);
        int index=0;
        while(index<queue.Count)
        {
            BinaryTree current = queue[index];
            index+=1;
            if(current==null)
                continue;
            SwapLeftAndRight(current);
            if(current.left!=null)
            {
                queue.Add(current.left);
            }
            if(current.right!=null)
            {
                queue.Add(current.right);
            }
        }
  }
    //O(n) time and O(d) space 
   public static void InvertBinaryTreeSolution2(BinaryTree tree) {
    if(tree==null)
        return;
      SwapLeftAndRight(tree);
      InvertBinaryTreeSolution2(tree.left);
      InvertBinaryTreeSolution2(tree.right);
  }

    private static void SwapLeftAndRight(BinaryTree tree)
      {
          var left = tree.left;
          tree.left=tree.right;
          tree.right = left;
      }

  public class BinaryTree {
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value) {
      this.value = value;
    }
  }
}

//Problem statement

//   Write a function that takes in a Binary Tree and inverts it. In other words,
//   the function should swap every left node in the tree for its corresponding
//   right node. Each binary tree node has an integer value , a "left child node" and a "right child node". 
//   Children nodes can either be binary tree themselves or none/null.


//Test cases

// Yay, your code passed all the test cases!

// 11 / 11 test cases passed.

// Test Case 1 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": "9", "right": "8", "value": 4},
//     {"id": "8", "left": null, "right": null, "value": 8},
//     {"id": "9", "left": null, "right": null, "value": 9},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6},
//     {"id": "7", "left": null, "right": null, "value": 7}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": "9", "right": "8", "value": 4},
//     {"id": "8", "left": null, "right": null, "value": 8},
//     {"id": "9", "left": null, "right": null, "value": 9},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6},
//     {"id": "7", "left": null, "right": null, "value": 7}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "2", "left": "4", "right": "5", "value": 2},
//       {"id": "3", "left": "6", "right": "7", "value": 3},
//       {"id": "4", "left": "8", "right": "9", "value": 4},
//       {"id": "5", "left": null, "right": null, "value": 5},
//       {"id": "6", "left": null, "right": null, "value": 6},
//       {"id": "7", "left": null, "right": null, "value": 7},
//       {"id": "8", "left": null, "right": null, "value": 8},
//       {"id": "9", "left": null, "right": null, "value": 9}
//     ],
//     "root": "1"
//   }
// }
// Test Case 2 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": null, "right": null, "value": 1}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": null, "right": null, "value": 1}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": null, "right": null, "value": 1}
//     ],
//     "root": "1"
//   }
// }
// Test Case 3 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": null, "right": "2", "value": 1},
//     {"id": "2", "left": null, "right": null, "value": 2}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": null, "right": "2", "value": 1},
//     {"id": "2", "left": null, "right": null, "value": 2}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": null, "value": 1},
//       {"id": "2", "left": null, "right": null, "value": 2}
//     ],
//     "root": "1"
//   }
// }
// Test Case 4 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": null, "right": null, "value": 2},
//     {"id": "3", "left": null, "right": null, "value": 3}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": null, "right": null, "value": 2},
//     {"id": "3", "left": null, "right": null, "value": 3}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "2", "left": null, "right": null, "value": 2},
//       {"id": "3", "left": null, "right": null, "value": 3}
//     ],
//     "root": "1"
//   }
// }
// Test Case 5 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": null, "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": null, "value": 4},
//     {"id": "3", "left": null, "right": null, "value": 3}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": null, "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": null, "value": 4},
//     {"id": "3", "left": null, "right": null, "value": 3}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "2", "left": "4", "right": null, "value": 2},
//       {"id": "3", "left": null, "right": null, "value": 3},
//       {"id": "4", "left": null, "right": null, "value": 4}
//     ],
//     "root": "1"
//   }
// }
// Test Case 6 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": null, "value": 4},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": null, "right": null, "value": 3}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": null, "value": 4},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": null, "right": null, "value": 3}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "2", "left": "4", "right": "5", "value": 2},
//       {"id": "3", "left": null, "right": null, "value": 3},
//       {"id": "4", "left": null, "right": null, "value": 4},
//       {"id": "5", "left": null, "right": null, "value": 5}
//     ],
//     "root": "1"
//   }
// }
// Test Case 7 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": null, "value": 4},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": null, "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": null, "value": 4},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": null, "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "2", "left": "4", "right": "5", "value": 2},
//       {"id": "3", "left": "6", "right": null, "value": 3},
//       {"id": "4", "left": null, "right": null, "value": 4},
//       {"id": "5", "left": null, "right": null, "value": 5},
//       {"id": "6", "left": null, "right": null, "value": 6}
//     ],
//     "root": "1"
//   }
// }
// Test Case 8 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": null, "value": 4},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6},
//     {"id": "7", "left": null, "right": null, "value": 7}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": null, "value": 4},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6},
//     {"id": "7", "left": null, "right": null, "value": 7}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "2", "left": "4", "right": "5", "value": 2},
//       {"id": "3", "left": "6", "right": "7", "value": 3},
//       {"id": "4", "left": null, "right": null, "value": 4},
//       {"id": "5", "left": null, "right": null, "value": 5},
//       {"id": "6", "left": null, "right": null, "value": 6},
//       {"id": "7", "left": null, "right": null, "value": 7}
//     ],
//     "root": "1"
//   }
// }
// Test Case 9 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": "8", "value": 4},
//     {"id": "8", "left": null, "right": null, "value": 8},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6},
//     {"id": "7", "left": null, "right": null, "value": 7}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": null, "right": "8", "value": 4},
//     {"id": "8", "left": null, "right": null, "value": 8},
//     {"id": "5", "left": null, "right": null, "value": 5},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6},
//     {"id": "7", "left": null, "right": null, "value": 7}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "2", "left": "4", "right": "5", "value": 2},
//       {"id": "3", "left": "6", "right": "7", "value": 3},
//       {"id": "4", "left": "8", "right": null, "value": 4},
//       {"id": "5", "left": null, "right": null, "value": 5},
//       {"id": "6", "left": null, "right": null, "value": 6},
//       {"id": "7", "left": null, "right": null, "value": 7},
//       {"id": "8", "left": null, "right": null, "value": 8}
//     ],
//     "root": "1"
//   }
// }
// Test Case 10 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": "9", "right": "8", "value": 4},
//     {"id": "8", "left": null, "right": null, "value": 8},
//     {"id": "9", "left": null, "right": null, "value": 9},
//     {"id": "5", "left": null, "right": "10", "value": 5},
//     {"id": "10", "left": null, "right": null, "value": 10},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6},
//     {"id": "7", "left": null, "right": null, "value": 7}
//   ],
//   "root": "1"
// }
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": "9", "right": "8", "value": 4},
//     {"id": "8", "left": null, "right": null, "value": 8},
//     {"id": "9", "left": null, "right": null, "value": 9},
//     {"id": "5", "left": null, "right": "10", "value": 5},
//     {"id": "10", "left": null, "right": null, "value": 10},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": null, "right": null, "value": 6},
//     {"id": "7", "left": null, "right": null, "value": 7}
//   ],
//   "root": "1"
// }
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "2", "left": "4", "right": "5", "value": 2},
//       {"id": "3", "left": "6", "right": "7", "value": 3},
//       {"id": "4", "left": "8", "right": "9", "value": 4},
//       {"id": "5", "left": "10", "right": null, "value": 5},
//       {"id": "6", "left": null, "right": null, "value": 6},
//       {"id": "7", "left": null, "right": null, "value": 7},
//       {"id": "8", "left": null, "right": null, "value": 8},
//       {"id": "9", "left": null, "right": null, "value": 9},
//       {"id": "10", "left": null, "right": null, "value": 10}
//     ],
//     "root": "1"
//   }
// }
// Test Case 11 passed!
// Expected Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": "9", "right": "8", "value": 4},
//     {"id": "8", "left": "12", "right": null, "value": 8},
//     {"id": "12", "left": null, "right": null, "value": 12},
//     {"id": "9", "left": "14", "right": "13", "value": 9},
//     {"id": "13", "left": null, "right": null, "value": 13},
//     {"id": "14", "left": null, "right": null, "value": 14},
//     {"id": "5", "left": null, "right": "10", "value": 5},
//     {"id": "10", "left": null, "right": null, "value": 10},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": "11", "right": null, "value": 6},
//     {"id": "11", "left": "16", "right": "15", "value": 11},
//     {"id": "15", "left": "17", "right": null, "value": 15},
//     {"id": "17", "left": "18", "right": null, "value": 17},
//     {"id": "18", "left": "19", "right": null, "value": 18},
//     {"id": "19", "left": null, "right": "20", "va... 
// Your Code's Output
// {
//   "nodes": [
//     {"id": "1", "left": "3", "right": "2", "value": 1},
//     {"id": "2", "left": "5", "right": "4", "value": 2},
//     {"id": "4", "left": "9", "right": "8", "value": 4},
//     {"id": "8", "left": "12", "right": null, "value": 8},
//     {"id": "12", "left": null, "right": null, "value": 12},
//     {"id": "9", "left": "14", "right": "13", "value": 9},
//     {"id": "13", "left": null, "right": null, "value": 13},
//     {"id": "14", "left": null, "right": null, "value": 14},
//     {"id": "5", "left": null, "right": "10", "value": 5},
//     {"id": "10", "left": null, "right": null, "value": 10},
//     {"id": "3", "left": "7", "right": "6", "value": 3},
//     {"id": "6", "left": "11", "right": null, "value": 6},
//     {"id": "11", "left": "16", "right": "15", "value": 11},
//     {"id": "15", "left": "17", "right": null, "value": 15},
//     {"id": "17", "left": "18", "right": null, "value": 17},
//     {"id": "18", "left": "19", "right": null, "value": 18},
//     {"id": "19", "left": null, "right": "20", "va... 
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "2", "left": "4", "right": "5", "value": 2},
//       {"id": "3", "left": "6", "right": "7", "value": 3},
//       {"id": "4", "left": "8", "right": "9", "value": 4},
//       {"id": "5", "left": "10", "right": null, "value": 5},
//       {"id": "6", "left": null, "right": "11", "value": 6},
//       {"id": "7", "left": null, "right": null, "value": 7},
//       {"id": "8", "left": null, "right": "12", "value": 8},
//       {"id": "9", "left": "13", "right": "14", "value": 9},
//       {"id": "10", "left": null, "right": null, "value": 10},
//       {"id": "11", "left": "15", "right": "16", "value": 11},
//       {"id": "12", "left": null, "right": null, "value": 12},
//       {"id": "13", "left": null, "right": null, "value": 13},
//       {"id": "14", "left": null, "right": null, "value": 14},
//       {"id": "15", "left": null, "right": "17", "value": 15},
//       {"id": "16", "left": null, "right": null, "value": 16},
//       {"id": "17", "left": null, "right": "18", "value": 17},
//       {"id": "18", "left": null, "right": "19", "value": 18},
//       {"id": "19", "left": "20", "right": null, "value": 19},
//       {"id": "20", "left": "21", "right": null, "value": 20},
//       {"id": "21", "left": null, "right": null, "value": 21}
//     ],
//     "root": "1"
//   }
// }
