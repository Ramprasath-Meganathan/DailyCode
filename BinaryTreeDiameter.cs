using System;

//O(n) time and O(h) space - h is the height of the binary tree
public class BinaryTreeDiameter {

  public int BinaryTreeDiameterSoln(BinaryTree tree)
  {
      return getTreeInfo(tree).diameter;
  }

    public TreeInfo getTreeInfo(BinaryTree tree) {
     if(tree==null)
         return new TreeInfo(0,0);
     TreeInfo leftTreeInfo = getTreeInfo(tree.left);
     TreeInfo rightTreeInfo = getTreeInfo(tree.right);
     int longestPathThroughRoot = leftTreeInfo.height +rightTreeInfo.height;
     int maxDiameterSoFar = Math.Max(leftTreeInfo.diameter, rightTreeInfo.diameter);
     int currentDiameter = Math.Max(longestPathThroughRoot,maxDiameterSoFar);
     int currentHeight = 1+Math.Max(leftTreeInfo.height, rightTreeInfo.height);
     return new TreeInfo(currentDiameter, currentHeight);
  }

  public class TreeInfo{
      public int diameter;
      public int height;
      public TreeInfo(int diameter, int height)
      {
          this.diameter = diameter;
          this.height = height;
      }
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

// //Program
//   Write a function that takes in a Binary Tree and returns its diameter. The
//   diameter of a binary tree is defined as the length of its longest path, even
//   if that path doesn't pass through the root of the tree.

//   A path is a collection of connected nodes in a tree, where no node is
//   connected to more than two other nodes. The length of a path is the number of
//   edges between the path's first node and its last node.
//   Each BinaryTree node has an integer value, a "left child node" and a "right  child node. Children
//   nodes can either be Binary tree nodes themselves  or none/null.

//   //Test cases

//   Yay, your code passed all the test cases!

// 15 / 15 test cases passed.

// Test Case 1 passed!
// Expected Output
// 6
// Your Code's Output
// 6
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "3", "right": "2", "value": 1},
//       {"id": "3", "left": "7", "right": "4", "value": 3},
//       {"id": "7", "left": "8", "right": null, "value": 7},
//       {"id": "8", "left": "9", "right": null, "value": 8},
//       {"id": "9", "left": null, "right": null, "value": 9},
//       {"id": "4", "left": null, "right": "5", "value": 4},
//       {"id": "5", "left": null, "right": "6", "value": 5},
//       {"id": "6", "left": null, "right": null, "value": 6},
//       {"id": "2", "left": null, "right": null, "value": 2}
//     ],
//     "root": "1"
//   }
// }
// Test Case 2 passed!
// Expected Output
// 4
// Your Code's Output
// 4
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "3", "left": "6", "right": "7", "value": 3},
//       {"id": "7", "left": null, "right": null, "value": 7},
//       {"id": "6", "left": null, "right": null, "value": 6},
//       {"id": "2", "left": "4", "right": "5", "value": 2},
//       {"id": "5", "left": null, "right": null, "value": 5},
//       {"id": "4", "left": null, "right": null, "value": 4}
//     ],
//     "root": "1"
//   }
// }
// Test Case 3 passed!
// Expected Output
// 2
// Your Code's Output
// 2
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "3", "value": 1},
//       {"id": "3", "left": null, "right": null, "value": 3},
//       {"id": "2", "left": null, "right": null, "value": 2}
//     ],
//     "root": "1"
//   }
// }
// Test Case 4 passed!
// Expected Output
// 2
// Your Code's Output
// 2
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "2", "right": "-1", "value": 1},
//       {"id": "-1", "left": null, "right": null, "value": -1},
//       {"id": "2", "left": null, "right": null, "value": 2}
//     ],
//     "root": "1"
//   }
// }
// Test Case 5 passed!
// Expected Output
// 3
// Your Code's Output
// 3
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "-5", "right": "3", "value": 1},
//       {"id": "3", "left": null, "right": null, "value": 3},
//       {"id": "-5", "left": "6", "right": null, "value": -5},
//       {"id": "6", "left": null, "right": null, "value": 6}
//     ],
//     "root": "1"
//   }
// }
// Test Case 6 passed!
// Expected Output
// 7
// Your Code's Output
// 7
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "3", "right": "9", "value": 1},
//       {"id": "3", "left": null, "right": null, "value": 3},
//       {"id": "9", "left": "14", "right": "10", "value": 9},
//       {"id": "10", "left": null, "right": "11", "value": 10},
//       {"id": "11", "left": null, "right": "12", "value": 11},
//       {"id": "12", "left": null, "right": "17", "value": 12},
//       {"id": "17", "left": null, "right": null, "value": 17},
//       {"id": "14", "left": null, "right": "19", "value": 14},
//       {"id": "19", "left": "25", "right": null, "value": 19},
//       {"id": "25", "left": null, "right": null, "value": 25}
//     ],
//     "root": "1"
//   }
// }
// Test Case 7 passed!
// Expected Output
// 2
// Your Code's Output
// 2
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "3", "right": "5", "value": 1},
//       {"id": "3", "left": null, "right": null, "value": 3},
//       {"id": "5", "left": null, "right": null, "value": 5}
//     ],
//     "root": "1"
//   }
// }
// Test Case 8 passed!
// Expected Output
// 4
// Your Code's Output
// 4
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "1", "left": "5", "right": null, "value": 1},
//       {"id": "5", "left": "7", "right": "9", "value": 5},
//       {"id": "9", "left": null, "right": "12", "value": 9},
//       {"id": "12", "left": null, "right": null, "value": 12},
//       {"id": "7", "left": "8", "right": null, "value": 7},
//       {"id": "8", "left": null, "right": null, "value": 8}
//     ],
//     "root": "1"
//   }
// }
// Test Case 9 passed!
// Expected Output
// 0
// Your Code's Output
// 0
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
// Test Case 10 passed!
// Expected Output
// 1
// Your Code's Output
// 1
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "4", "left": "2", "right": null, "value": 4},
//       {"id": "2", "left": null, "right": null, "value": 2}
//     ],
//     "root": "4"
//   }
// }
// Test Case 11 passed!
// Expected Output
// 2
// Your Code's Output
// 2
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "4", "left": "2", "right": null, "value": 4},
//       {"id": "2", "left": "1", "right": null, "value": 2},
//       {"id": "1", "left": null, "right": null, "value": 1}
//     ],
//     "root": "4"
//   }
// }
// Test Case 12 passed!
// Expected Output
// 4
// Your Code's Output
// 4
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "4", "left": "2", "right": null, "value": 4},
//       {"id": "2", "left": "1", "right": null, "value": 2},
//       {"id": "1", "left": null, "right": "3", "value": 1},
//       {"id": "3", "left": "19", "right": null, "value": 3},
//       {"id": "19", "left": null, "right": null, "value": 19}
//     ],
//     "root": "4"
//   }
// }
// Test Case 13 passed!
// Expected Output
// 1
// Your Code's Output
// 1
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "6", "left": null, "right": "1", "value": 6},
//       {"id": "1", "left": null, "right": null, "value": 1}
//     ],
//     "root": "6"
//   }
// }
// Test Case 14 passed!
// Expected Output
// 2
// Your Code's Output
// 2
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "3", "left": null, "right": "10", "value": 3},
//       {"id": "10", "left": "1", "right": null, "value": 10},
//       {"id": "1", "left": null, "right": null, "value": 1}
//     ],
//     "root": "3"
//   }
// }
// Test Case 15 passed!
// Expected Output
// 4
// Your Code's Output
// 4
// View Outputs Side By Side
// Input(s)
// {
//   "tree": {
//     "nodes": [
//       {"id": "2", "left": "1", "right": null, "value": 2},
//       {"id": "1", "left": "3", "right": null, "value": 1},
//       {"id": "3", "left": null, "right": "5", "value": 3},
//       {"id": "5", "left": null, "right": "10", "value": 5},
//       {"id": "10", "left": null, "right": null, "value": 10}
//     ],
//     "root": "2"
//   }
// }