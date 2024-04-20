using System.Linq;
using System.Collections.Generic;
using System;

public class FirstNonRepeatingCharacter {
  public int FirstNonRepeatingCharacterMethod(string str) {
    char[] charArray = str.ToCharArray();
    var letterCounter = LetterCounter(charArray);
    var result = letterCounter.FirstOrDefault(x=>x.Value==1).Key;
    return Array.IndexOf(charArray,result);
  }

  public static Dictionary<char,int> LetterCounter(char[] charArray)
  {
      Dictionary<char, int> dict = new Dictionary<char, int>();
      foreach(var c in charArray)
          dict[c] = !(dict.ContainsKey(c)) ? 1 : dict[c]+1;
      return dict;
  }
}

// Problem Statement
//   Write a function that takes in a string of lowercase English-alphabet letters
//   and returns the index of the string's first non-repeating character.
//   The first non-repeating character is the first character in a string that
//   occurs only once. If the input string doesn't have any non-repeating characters, your function
//   should return -1.

// Test cases
// 15 / 15 test cases passed.

// Test Case 1 passed!
// Expected Output
// 1
// Your Code's Output
// 1
// View Outputs Side By Side
// Input(s)
// {
//   "string": "abcdcaf"
// }
// Test Case 2 passed!
// Expected Output
// 6
// Your Code's Output
// 6
// View Outputs Side By Side
// Input(s)
// {
//   "string": "faadabcbbebdf"
// }
// Test Case 3 passed!
// Expected Output
// 0
// Your Code's Output
// 0
// View Outputs Side By Side
// Input(s)
// {
//   "string": "a"
// }
// Test Case 4 passed!
// Expected Output
// 0
// Your Code's Output
// 0
// View Outputs Side By Side
// Input(s)
// {
//   "string": "ab"
// }
// Test Case 5 passed!
// Expected Output
// 0
// Your Code's Output
// 0
// View Outputs Side By Side
// Input(s)
// {
//   "string": "abc"
// }
// Test Case 6 passed!
// Expected Output
// 1
// Your Code's Output
// 1
// View Outputs Side By Side
// Input(s)
// {
//   "string": "abac"
// }
// Test Case 7 passed!
// Expected Output
// 5
// Your Code's Output
// 5
// View Outputs Side By Side
// Input(s)
// {
//   "string": "ababac"
// }
// Test Case 8 passed!
// Expected Output
// -1
// Your Code's Output
// -1
// View Outputs Side By Side
// Input(s)
// {
//   "string": "ababacc"
// }
// Test Case 9 passed!
// Expected Output
// 7
// Your Code's Output
// 7
// View Outputs Side By Side
// Input(s)
// {
//   "string": "lmnopqldsafmnopqsa"
// }
// Test Case 10 passed!
// Expected Output
// 25
// Your Code's Output
// 25
// View Outputs Side By Side
// Input(s)
// {
//   "string": "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxy"
// }
// Test Case 11 passed!
// Expected Output
// -1
// Your Code's Output
// -1
// View Outputs Side By Side
// Input(s)
// {
//   "string": "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz"
// }
// Test Case 12 passed!
// Expected Output
// -1
// Your Code's Output
// -1
// View Outputs Side By Side
// Input(s)
// {
//   "string": ""
// }
// Test Case 13 passed!
// Expected Output
// 10
// Your Code's Output
// 10
// View Outputs Side By Side
// Input(s)
// {
//   "string": "ggyllaylacrhdzedddjsc"
// }
// Test Case 14 passed!
// Expected Output
// -1
// Your Code's Output
// -1
// View Outputs Side By Side
// Input(s)
// {
//   "string": "aaaaaaaaaaaaaaaaaaaabbbbbbbbbbcccccccccccdddddddddddeeeeeeeeffghgh"
// }
// Test Case 15 passed!
// Expected Output
// -1
// Your Code's Output
// -1
// View Outputs Side By Side
// Input(s)
// {
//   "string": "aabbccddeeff"
// }