
public class FindFirstIndexOccurrence    {

    // solution 1
    // O(m*n) time and O(1) space
    public int StrStrSolution1(string haystack, string needle) {
        if(haystack.Contains(needle))
            return haystack.IndexOf(needle);
        return -1;
    }

    // solution 2 

   // O((M−N)N) time and O(1) space
    public int StrStrSolution2(string haystack, string needle) {
        if(needle=="")
            return 0;
        for(int i=0;i<haystack.Length+1-needle.Length;i++){
            for(int j=0;j<needle.Length;j++){
                if(haystack[i+j]!=needle[j])
                    break;
                if(j==needle.Length-1)
                    return i;
            }
        }
    return -1;
    }
}

// 28. Find the Index of the First Occurrence in a String
// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

// Example 1:

// Input: haystack = "sadbutsad", needle = "sad"
// Output: 0
// Explanation: "sad" occurs at index 0 and 6.
// The first occurrence is at index 0, so we return 0.
// Example 2:

// Input: haystack = "leetcode", needle = "leeto"
// Output: -1
// Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

// Constraints:

// 1 <= haystack.length, needle.length <= 104
// haystack and needle consist of only lowercase English characters.