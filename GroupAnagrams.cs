public class GroupAnagrams {
    
    // O(N∗MLogM) time and O(N*M) space
    public IList<IList<string>> GroupAnagramsSolution(string[] strs) {
        Dictionary<string, List<string>> anagramDict = new Dictionary<string, List<string>>();
        
        foreach (var str in strs) {
            // Sort the characters in the string to create a key
            var sortedString = new string(str.OrderBy(c => c).ToArray());
            
            // If the key doesn't exist, add it to the dictionary
            if (!anagramDict.ContainsKey(sortedString)) {
                anagramDict[sortedString] = new List<string>();
            }
            
            // Add the original string to the list corresponding to the sorted key
            anagramDict[sortedString].Add(str);
        }
        
        // Return the values of the dictionary as the final grouped anagrams
        return new List<IList<string>>(anagramDict.Values);
    }
}

// 49. Group Anagrams
// Given an array of strings strs, group the 
// anagrams
//  together. You can return the answer in any order.

 

// Example 1:

// Input: strs = ["eat","tea","tan","ate","nat","bat"]

// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

// Explanation:

// There is no string in strs that can be rearranged to form "bat".
// The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
// The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
// Example 2:

// Input: strs = [""]

// Output: [[""]]

// Example 3:

// Input: strs = ["a"]

// Output: [["a"]]

 

// Constraints:

// 1 <= strs.length <= 104
// 0 <= strs[i].length <= 100
// strs[i] consists of lowercase English letters.