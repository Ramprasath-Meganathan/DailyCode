public class MergeStringsAlternately {

    // O(n) time and O(n+m) space
    public string MergeAlternately(string word1, string word2) {
        string s="";
        bool word1Smaller = word1.Length<word2.Length;
        int wordLength = word2.Length;
        int remainingCounter = 0;
        if(word1Smaller)
          wordLength = word1.Length;
        for(int i=0;i<wordLength;i++)
        {
            s+=word1[i];
            s+=word2[i];
            remainingCounter++;
        }
        string word = word1Smaller ? word2 : word1;
        for(int j=remainingCounter;j<word.Length;j++)
            s+=word[j];
        return s;
    }
}

// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

// Return the merged string.

 

// Example 1:

// Input: word1 = "abc", word2 = "pqr"
// Output: "apbqcr"
// Explanation: The merged string will be merged as so:
// word1:  a   b   c
// word2:    p   q   r
// merged: a p b q c r
// Example 2:

// Input: word1 = "ab", word2 = "pqrs"
// Output: "apbqrs"
// Explanation: Notice that as word2 is longer, "rs" is appended to the end.
// word1:  a   b 
// word2:    p   q   r   s
// merged: a p b q   r   s
// Example 3:

// Input: word1 = "abcd", word2 = "pq"
// Output: "apbqcd"
// Explanation: Notice that as word1 is longer, "cd" is appended to the end.
// word1:  a   b   c   d
// word2:    p   q 
// merged: a p b q c   d
 

// Constraints:

// 1 <= word1.length, word2.length <= 100
// word1 and word2 consist of lowercase English letters.
