public class RansomNote {
    public bool CanConstructSolution1(string ransomNote, string magazine) {

        // O(n+m) time and O(1) space
        Dictionary<char,int> counter = new Dictionary<char,int>();
        foreach(var x in magazine)
        {
            if(counter.ContainsKey(x))
                counter[x] += 1;
            else
                counter[x] = 1;
        }
        foreach(var ch in ransomNote)
        {
            if(!counter.ContainsKey(ch))
                  return false;
            else
                counter[ch]-=1;
        }
        return !counter.Values.Any(x=>x<0);
    }

    //O(n+m) time and O(1) space
     public bool CanConstructSolution2(string ransomNote, string magazine) {
        int[] count = new int[26];
        foreach(var x in magazine)
            ++count[x-'a'];
        foreach(var ch in ransomNote)
        {
            if(--count[ch-'a']< 0)
                return false;
        }
        return true;
    }
}



// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

// Each letter in magazine can only be used once in ransomNote.

// Example 1:

// Input: ransomNote = "a", magazine = "b"
// Output: false
// Example 2:

// Input: ransomNote = "aa", magazine = "ab"
// Output: false
// Example 3:

// Input: ransomNote = "aa", magazine = "aab"
// Output: true
 
// Constraints:

// 1 <= ransomNote.length, magazine.length <= 105
// ransomNote and magazine consist of lowercase English letters.