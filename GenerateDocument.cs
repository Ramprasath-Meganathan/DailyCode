using System;
using System.Collections.Generic;

//  O(n+m) time and O(1) space
public class GenerateDocument {
    
  public bool GenerateDocumentMethod(string characters, string document) {
    char[] charArray = characters.ToCharArray();
    char[] documentArray = document.ToCharArray();
    var charCount = CharacterCounter(charArray);
    var documentCount = CharacterCounter(documentArray);
    var generateDocument = false;
    if(documentCount.Count==0)
        return true;
    foreach(var entry in documentCount)
    {
        if(charCount.ContainsKey(entry.Key)&& charCount[entry.Key]>=entry.Value)
            generateDocument = true;
        else
            return false;
    }
    return generateDocument;
  }

   public static Dictionary<char,int> CharacterCounter(char[] charArray)
   {
    var dict = new Dictionary<char,int>();
    foreach(var entry in charArray)
    {
        if(!dict.ContainsKey(entry))
            dict[entry] = 1;
        else
            dict[entry]+=1;
    }
       return dict;
   }
}

//Problem Statement
//   You're given a string of available characters and a string representing a
//   document that you need to generate. Write a function that determines if you
//   can generate the document using the available characters. If you can generate
//   the document, your function should return true ; otherwise, it
//   should return false. 

//   You're only able to generate the document if the frequency of unique
//   characters in the characters string is greater than or equal to the frequency
//   of unique characters in the document string. For example, if you're given characters = "abcabc"
//   and document = "aabbccc"  you cannot  generate the document because you're missing one.
//   The document that you need to create may contain any characters, including
//   special characters, capital letters, numbers, and spaces.
//   Note: you can always generate the empty string ("")

//Test cases
// 15 / 15 test cases passed.

// Test Case 1 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "Bste!hetsi ogEAxpelrt x ",
//   "document": "AlgoExpert is the Best!"
// }
// Test Case 2 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "A",
//   "document": "a"
// }
// Test Case 3 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "a",
//   "document": "a"
// }
// Test Case 4 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "a hsgalhsa sanbjksbdkjba kjx",
//   "document": ""
// }
// Test Case 5 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "characters": " ",
//   "document": "hello"
// }
// Test Case 6 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "     ",
//   "document": "     "
// }
// Test Case 7 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "aheaollabbhb",
//   "document": "hello"
// }
// Test Case 8 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "aheaolabbhb",
//   "document": "hello"
// }
// Test Case 9 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "estssa",
//   "document": "testing"
// }
// Test Case 10 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "Bste!hetsi ogEAxpert",
//   "document": "AlgoExpert is the Best!"
// }
// Test Case 11 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "helloworld ",
//   "document": "hello wOrld"
// }
// Test Case 12 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "helloworldO",
//   "document": "hello wOrld"
// }
// Test Case 13 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "helloworldO ",
//   "document": "hello wOrld"
// }
// Test Case 14 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "&*&you^a%^&8766 _=-09     docanCMakemthisdocument",
//   "document": "Can you make this document &"
// }
// Test Case 15 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "characters": "abcabcabcacbcdaabc",
//   "document": "bacaccadac"
// }

  