using System;
using System.Collections.Generic;

//O(logn) best case worst case - O(n) and O(1) space
public class MoveElementToEnd{
  public static List<int> MoveElementToEndMethod(List<int> array, int toMove) {
    int length = array.Count-1;
    for(int i=0;i<=length;i++)
    {
        if(array[i]==toMove)
        {
            while(array[length]==toMove&&length>i)
                length--;
            Swap(array,i,length);
            length--;
        }
    }
    return array;
  }
    public static List<int> Swap(List<int> array, int i, int length)
    {
        var temp = array[i];
        array[i] = array[length];
        array[length] = temp;
    return array;
    }
}

// Problem statement

//   You're given an array of integers and an integer. Write a function that moves
//   all instances of that integer in the array to the end of the array and returns
//   the array.

//   The function should perform this in place (i.e., it should mutate the input
//   array) and doesn't need to maintain the order of the other integers.

//   Yay, your code passed all the test cases!

// 11 / 11 test cases passed.

// Test Case 1 passed!
// Expected Output
// [4, 1, 3, 2, 2, 2, 2, 2]
// Your Code's Output
// [4, 1, 3, 2, 2, 2, 2, 2]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [2, 1, 2, 2, 2, 3, 4, 2],
//   "toMove": 2
// }
// Test Case 2 passed!
// Expected Output
// []
// Your Code's Output
// []
// View Outputs Side By Side
// Input(s)
// {
//   "array": [],
//   "toMove": 3
// }
// Test Case 3 passed!
// Expected Output
// [1, 2, 4, 5, 6]
// Your Code's Output
// [1, 2, 4, 5, 6]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 4, 5, 6],
//   "toMove": 3
// }
// Test Case 4 passed!
// Expected Output
// [3, 3, 3, 3, 3]
// Your Code's Output
// [3, 3, 3, 3, 3]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [3, 3, 3, 3, 3],
//   "toMove": 3
// }
// Test Case 5 passed!
// Expected Output
// [5, 1, 2, 4, 3]
// Your Code's Output
// [5, 1, 2, 4, 3]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [3, 1, 2, 4, 5],
//   "toMove": 3
// }
// Test Case 6 passed!
// Expected Output
// [1, 2, 4, 5, 3]
// Your Code's Output
// [1, 2, 4, 5, 3]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 4, 5, 3],
//   "toMove": 3
// }
// Test Case 7 passed!
// Expected Output
// [1, 2, 5, 4, 3]
// Your Code's Output
// [1, 2, 5, 4, 3]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 4, 5],
//   "toMove": 3
// }
// Test Case 8 passed!
// Expected Output
// [6, 4, 5, 2, 2, 2, 2]
// Your Code's Output
// [6, 4, 5, 2, 2, 2, 2]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [2, 4, 2, 5, 6, 2, 2],
//   "toMove": 2
// }
// Test Case 9 passed!
// Expected Output
// [12, 11, 10, 9, 8, 7, 1, 2, 3, 4, 6, 5, 5, 5, 5, 5, 5]
// Your Code's Output
// [12, 11, 10, 9, 8, 7, 1, 2, 3, 4, 6, 5, 5, 5, 5, 5, 5]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [5, 5, 5, 5, 5, 5, 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12],
//   "toMove": 5
// }
// Test Case 10 passed!
// Expected Output
// [1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 5, 5, 5, 5, 5, 5]
// Your Code's Output
// [1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 5, 5, 5, 5, 5, 5]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 5, 5, 5, 5, 5, 5],
//   "toMove": 5
// }
// Test Case 11 passed!
// Expected Output
// [12, 1, 2, 11, 10, 3, 4, 6, 7, 9, 8, 5, 5, 5, 5, 5, 5]
// Your Code's Output
// [12, 1, 2, 11, 10, 3, 4, 6, 7, 9, 8, 5, 5, 5, 5, 5, 5]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [5, 1, 2, 5, 5, 3, 4, 6, 7, 5, 8, 9, 10, 11, 5, 5, 12],
//   "toMove": 5
// }