using System;
using System.Collections.Generic;

public class ThreeNumberSum {

// O(n2) time and O(n) space
  public static List<int[]> ThreeNumberSumMethod(int[] array, int targetSum) {
    Array.Sort(array);
    List<int[]> triplets = new List<int[]>();
    for(int i=0;i<array.Length-2;i++)
    {
        int left = i+1;
        int right = array.Length-1;
        while(left<right)
        {
            int currentSum = array[i]+array[left]+array[right];
            if(currentSum==targetSum)
            {
                triplets.Add(new int[3]{array[i],array[left],array[right]});
                left++;
                right--;
            }
            else if(currentSum<targetSum)
                left++;
            else if(currentSum>targetSum)
                right--;
        }
    }
    return triplets;
  }
}

// // Problem statement
//   Write a function that takes in a non-empty array of distinct integers and an
//   integer representing a target sum. The function should find all triplets in
//   the array that sum up to the target sum and return a two-dimensional array of
//   all these triplets. The numbers in each triplet should be ordered in ascending
//   order, and the triplets themselves should be ordered in ascending order with
//   respect to the numbers they hold.

//   If no three numbers sum up to the target sum, the function should return an
//   empty array.

// // Test cases
// Yay, your code passed all the test cases!

// 11 / 11 test cases passed.

// Test Case 1 passed!
// Expected Output
// [
//   [-8, 2, 6],
//   [-8, 3, 5],
//   [-6, 1, 5]
// ]
// Your Code's Output
// [
//   [-8, 2, 6],
//   [-8, 3, 5],
//   [-6, 1, 5]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [12, 3, 1, 2, -6, 5, -8, 6],
//   "targetSum": 0
// }
// Test Case 2 passed!
// Expected Output
// [
//   [1, 2, 3]
// ]
// Your Code's Output
// [
//   [1, 2, 3]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3],
//   "targetSum": 6
// }
// Test Case 3 passed!
// Expected Output
// []
// Your Code's Output
// []
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3],
//   "targetSum": 7
// }
// Test Case 4 passed!
// Expected Output
// [
//   [-2, 10, 49]
// ]
// Your Code's Output
// [
//   [-2, 10, 49]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [8, 10, -2, 49, 14],
//   "targetSum": 57
// }
// Test Case 5 passed!
// Expected Output
// [
//   [-8, 3, 5],
//   [-6, 1, 5],
//   [-1, 0, 1]
// ]
// Your Code's Output
// [
//   [-8, 3, 5],
//   [-6, 1, 5],
//   [-1, 0, 1]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [12, 3, 1, 2, -6, 5, 0, -8, -1],
//   "targetSum": 0
// }
// Test Case 6 passed!
// Expected Output
// [
//   [-8, 2, 6],
//   [-8, 3, 5],
//   [-6, 0, 6],
//   [-6, 1, 5],
//   [-1, 0, 1]
// ]
// Your Code's Output
// [
//   [-8, 2, 6],
//   [-8, 3, 5],
//   [-6, 0, 6],
//   [-6, 1, 5],
//   [-1, 0, 1]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [12, 3, 1, 2, -6, 5, 0, -8, -1, 6],
//   "targetSum": 0
// }
// Test Case 7 passed!
// Expected Output
// [
//   [-8, 2, 6],
//   [-8, 3, 5],
//   [-6, 0, 6],
//   [-6, 1, 5],
//   [-5, -1, 6],
//   [-5, 0, 5],
//   [-5, 2, 3],
//   [-1, 0, 1]
// ]
// Your Code's Output
// [
//   [-8, 2, 6],
//   [-8, 3, 5],
//   [-6, 0, 6],
//   [-6, 1, 5],
//   [-5, -1, 6],
//   [-5, 0, 5],
//   [-5, 2, 3],
//   [-1, 0, 1]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [12, 3, 1, 2, -6, 5, 0, -8, -1, 6, -5],
//   "targetSum": 0
// }
// Test Case 8 passed!
// Expected Output
// [
//   [1, 2, 15],
//   [1, 8, 9],
//   [2, 7, 9],
//   [3, 6, 9],
//   [3, 7, 8],
//   [4, 5, 9],
//   [4, 6, 8],
//   [5, 6, 7]
// ]
// Your Code's Output
// [
//   [1, 2, 15],
//   [1, 8, 9],
//   [2, 7, 9],
//   [3, 6, 9],
//   [3, 7, 8],
//   [4, 5, 9],
//   [4, 6, 8],
//   [5, 6, 7]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 4, 5, 6, 7, 8, 9, 15],
//   "targetSum": 18
// }
// Test Case 9 passed!
// Expected Output
// [
//   [8, 9, 15]
// ]
// Your Code's Output
// [
//   [8, 9, 15]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 4, 5, 6, 7, 8, 9, 15],
//   "targetSum": 32
// }
// Test Case 10 passed!
// Expected Output
// []
// Your Code's Output
// []
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 4, 5, 6, 7, 8, 9, 15],
//   "targetSum": 33
// }
// Test Case 11 passed!
// Expected Output
// []
// Your Code's Output
// []
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 4, 5, 6, 7, 8, 9, 15],
//   "targetSum": 5
// }