using System.Text;

public class LongestCommonPrefix {
    public string LongestCommonPrefixSolution(string[] strs) {
            int n = strs.Length;
            Array.Sort(strs);
            string first = strs[0];
            string last = strs[n-1];
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < Math.Min(first.Length, last.Length);i++)
            {
                if(first[i] != last[i])
                    return str.ToString();
                
                str.Append(first[i]);
            }
            return str.ToString();
    }
}

// 14. Longest Common Prefix

// Write a function to find the longest common prefix string amongst an array of strings.

// If there is no common prefix, return an empty string "".

// Example 1:

// Input: strs = ["flower","flow","flight"]
// Output: "fl"
// Example 2:

// Input: strs = ["dog","racecar","car"]
// Output: ""
// Explanation: There is no common prefix among the input strings.
 

// Constraints:

// 1 <= strs.length <= 200
// 0 <= strs[i].length <= 200
// strs[i] consists of only lowercase English letters.