using System;

public class MonotonicArray {
//O(n) time and O(1) space
  public static bool IsMonotonic(int[] array) {
  int sentiment = 0;
  int? previousSentiment = null;
  if(array.Length<=2)
        return true;
  for(int i=0;i<array.Length-1;i++)
  {
      if(array[i+1]==array[i])
            continue;
      sentiment = array[i+1]>array[i]? 1 : 0;
      previousSentiment = previousSentiment??sentiment;
      if(previousSentiment!=sentiment)
          return false;
  }
      return true;
  }
}

// problem statement
//   Write a function that takes in an array of integers and returns a boolean
//   representing whether the array is monotonic.  
//   An array is said to be monotonic if its elements, from left to right, are
//   entirely non-increasing or entirely non-decreasing.
//   Non-increasing elements aren't necessarily exclusively decreasing; they simply
//   don't increase. Similarly, non-decreasing elements aren't necessarily
//   exclusively increasing; they simply don't decrease.   
//   Note that empty arrays and arrays of one element are monotonic.

//   Yay, your code passed all the test cases!

// 19 / 19 test cases passed.

// Test Case 1 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -5, -10, -1100, -1100, -1101, -1102, -9001]
// }
// Test Case 2 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": []
// }
// Test Case 3 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1]
// }
// Test Case 4 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2]
// }
// Test Case 5 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [2, 1]
// }
// Test Case 6 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 5, 10, 1100, 1101, 1102, 9001]
// }
// Test Case 7 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -5, -10, -1100, -1101, -1102, -9001]
// }
// Test Case 8 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -5, -10, -1100, -900, -1101, -1102, -9001]
// }
// Test Case 9 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 0]
// }
// Test Case 10 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 7, 9, 10, 11]
// }
// Test Case 11 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 8, 9, 10, 11]
// }
// Test Case 12 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -1, -2, -3, -4, -5, -5, -5, -6, -7, -8, -7, -9, -10, -11]
// }
// Test Case 13 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -1, -2, -3, -4, -5, -5, -5, -6, -7, -8, -8, -9, -10, -11]
// }
// Test Case 14 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -1, -1, -1, -1, -1, -1, -1]
// }
// Test Case 15 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, -1, -2, -5]
// }
// Test Case 16 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -5, 10]
// }
// Test Case 17 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [2, 2, 2, 1, 4, 5]
// }
// Test Case 18 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 1, 1, 2, 3, 4, 1]
// }
// Test Case 19 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 3, 2, 1]
// }