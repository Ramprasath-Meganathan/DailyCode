using System;

public class SingleCycleCheck {
  public static bool HasSingleCycle(int[] array) {
    int numberElementsVisited = 0;
    int currentIndex = 0;
      while(numberElementsVisited<array.Length)
      {
          if(numberElementsVisited >0 && currentIndex == 0)
              return false;
          numberElementsVisited++;
          currentIndex = getNextIndex(currentIndex, array);
      }
    return currentIndex==0;
  }

  public static int getNextIndex(int currentIndex, int[] array)
  {
      int jump = array[currentIndex];
      int nextIndex = (currentIndex+jump) % array.Length;
      return nextIndex >=0 ? nextIndex: nextIndex + array.Length;
  }
}

// Problem statement

//   You're given an array of integers where each integer represents a jump of its
//   value in the array. For instance, the integer 2 represents a jump
//   of two indices forward in the array; the integer 3 represents a
//   jump of three indices backward in the array.
//   If a jump spills past the array's bounds, it wraps over to the other side. For
//   instance, a jump of -1 at index 0 brings us to the last index in
//   the array. Similarly, a jump of 1  at the last index in the array brings us to
//   index 0. 
//   Write a function that returns a boolean representing whether the jumps in the
//   array form a single cycle. A single cycle occurs if, starting at any index in
//   the array and following the jumps, every element in the array is visited
//   exactly once before landing back on the starting index.

//   // Test cases

//   Yay, your code passed all the test cases!

// 16 / 16 test cases passed.

// Test Case 1 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [2, 3, 1, -4, -4, 2]
// }
// Test Case 2 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [2, 2, -1]
// }
// Test Case 3 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [2, 2, 2]
// }
// Test Case 4 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 1, 1, 1, 1]
// }
// Test Case 5 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, 2, 2]
// }
// Test Case 6 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [0, 1, 1, 1, 1]
// }
// Test Case 7 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 1, 0, 1, 1]
// }
// Test Case 8 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 1, 1, 1, 2]
// }
// Test Case 9 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [3, 5, 6, -5, -2, -5, -12, -2, -1, 2, -6, 1, 1, 2, -5, 2]
// }
// Test Case 10 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [3, 5, 5, -5, -2, -5, -12, -2, -1, 2, -6, 1, 1, 2, -5, 2]
// }
// Test Case 11 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 4, -2, 3, 7, 8, 1]
// }
// Test Case 12 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 4, -2, 3, 7, 8, -8]
// }
// Test Case 13 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 4, -2, 3, 7, 8, -26]
// }
// Test Case 14 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "array": [10, 11, -6, -23, -2, 3, 88, 908, -26]
// }
// Test Case 15 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [10, 11, -6, -23, -2, 3, 88, 909, -26]
// }
// Test Case 16 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, -1, 1, -1]
// }