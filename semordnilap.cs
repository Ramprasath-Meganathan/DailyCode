using System.Collections.Generic;
using System;
using System.Linq;

public class Semordnilap {
  public List<List<string> > SemordnilapMethod(string[] words) {
    List<string> wordList = [];
    List<List<string>> finalList = [];
    foreach(var word in words)
    {
        var wordToReverseArray = word.ToCharArray();
        Array.Reverse(wordToReverseArray);
        if(!wordList.Contains(word))
        {
            wordList.Add(word);
            wordList.Add(new string(wordToReverseArray));
        }
        else
        {
            var result = new List<string>{word, new(wordToReverseArray)};
            finalList.Add(result);
        }
    }
    return finalList;
  }
}

// Problem statement
//   Write a function that takes in a list of unique strings and returns a list of
//   semordnilap pairs.
//   A semordnilap pair is defined as a set of different strings where the reverse
//   of one word is the same as the forward version of the other. For example the
//   words "diaper" and "repaid" are a semordnilap pair, as are the words
//   "palindromes" and "semordnilap".
//   The order of the returned pairs and the order of the strings within each pair
//   does not matter.

// Test cases
// Yay, your code passed all the test cases!

// 10 / 10 test cases passed.

// Test Case 1 passed!
// Expected Output
// []
// Your Code's Output
// []
// View Outputs Side By Side
// Input(s)
// {
//   "words": []
// }
// Test Case 2 passed!
// Expected Output
// []
// Your Code's Output
// []
// View Outputs Side By Side
// Input(s)
// {
//   "words": ["aaa", "bbbb"]
// }
// Test Case 3 passed!
// Expected Output
// [
//   ["dog", "god"]
// ]
// Your Code's Output
// [
//   ["dog", "god"]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "words": ["dog", "god"]
// }
// Test Case 4 passed!
// Expected Output
// [
//   ["dog", "god"]
// ]
// Your Code's Output
// [
//   ["dog", "god"]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "words": ["dog", "hello", "god"]
// }
// Test Case 5 passed!
// Expected Output
// [
//   ["dog", "god"],
//   ["desserts", "stressed"]
// ]
// Your Code's Output
// [
//   ["dog", "god"],
//   ["desserts", "stressed"]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "words": ["dog", "desserts", "god", "stressed"]
// }
// Test Case 6 passed!
// Expected Output
// [
//   ["dog", "god"],
//   ["desserts", "stressed"]
// ]
// Your Code's Output
// [
//   ["dog", "god"],
//   ["desserts", "stressed"]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "words": ["dog", "hello", "desserts", "test", "god", "stressed"]
// }
// Test Case 7 passed!
// Expected Output
// [
//   ["abcde", "edcba"],
//   ["cbde", "edbc"]
// ]
// Your Code's Output
// [
//   ["abcde", "edcba"],
//   ["cbde", "edbc"]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "words": ["abcde", "edcba", "edbc", "edb", "cbde", "abc"]
// }
// Test Case 8 passed!
// This test case passed even though your code's output is different from the expected output. This means that this test case has at least 2 different acceptable answers.

// Expected Output
// [
//   ["abcde", "edcba"],
//   ["bcd", "dcb"]
// ]
// Your Code's Output
// [
//   ["bcd", "dcb"],
//   ["abcde", "edcba"]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "words": ["abcde", "bcd", "dcb", "edcba", "aaa"]
// }
// Test Case 9 passed!
// Expected Output
// [
//   ["abcdefghijk", "kjihgfedcba"]
// ]
// Your Code's Output
// [
//   ["abcdefghijk", "kjihgfedcba"]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "words": ["abcdefghijk", "aaa", "hello", "racecar", "kjihgfedcba"]
// }
// Test Case 10 passed!
// This test case passed even though your code's output is different from the expected output. This means that this test case has at least 2 different acceptable answers.

// Expected Output
// [
//   ["dog", "god"],
//   ["desserts", "stressed"],
//   ["evil", "live"],
//   ["palindromes", "semordnilap"]
// ]
// Your Code's Output
// [
//   ["dog", "god"],
//   ["desserts", "stressed"],
//   ["palindromes", "semordnilap"],
//   ["evil", "live"]
// ]
// View Outputs Side By Side
// Input(s)
// {
//   "words": ["liver", "dog", "hello", "desserts", "evil", "test", "god", "stressed", "racecar", "palindromes", "semordnilap", "abcd", "live"]
// }
