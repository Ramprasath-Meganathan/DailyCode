    public class AnagramSolution1 {
        //
        public bool IsAnagram(string s, string t) {
            char[] a = s.ToCharArray();
            char[] b = t.ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            if(a.Length!=b.Length)
                return false;
            for(int i=0;i<a.Length;i++)
            {
            if(a[i]!=b[i])
                    return false;
            }
            return true;
        }
    }

        public class AnagramSolution2 {
        //O(n) time and O(n) space
        public bool IsAnagram(string s, string t) {
            char[] a = s.ToCharArray();
            char[] b = t.ToCharArray();
            if(a.Length!=b.Length)
                return false;
            Array.Sort(a);
            Array.Sort(b);
           return new string(a) == new string(b);
        }
    }

        public class AnagramSolutionUsingDictionary {
        public bool IsAnagram(string s, string t) {
            char[] a = s.ToCharArray();
            char[] b = t.ToCharArray();
            if(a.Length!=b.Length)
                return false;
            var aCounter = Counter(a);
            var bCounter = Counter(b);
            foreach(var entry in aCounter)
            {
                if(!bCounter.ContainsKey(entry.Key)||bCounter[entry.Key]!=aCounter[entry.Key])
                    return false;
            }
           return true;
        }
        public static Dictionary<char,int> Counter(char[] array)
        {
             Dictionary<char,int> aCounter = new Dictionary<char,int>();
             for(int i=0;i<array.Length;i++)
            {
                if(aCounter.ContainsKey(array[i]))
                    aCounter[array[i]]+=1;
                else
                    aCounter[array[i]]=1;
            }
            return aCounter;
        }
    }
 
     // O(n) time and O(1) space
        public class Solution {
          
        public bool IsAnagram(string s, string t) {
            if(s.Length != t.Length)
                return false;
            var charCount = new int[256];
            foreach(var c in s)
                charCount[c]++;
            foreach(var c in t)
            {
                charCount[c]--;
                if(charCount[c]<0)
                    return false;
            }
            return true;
            
        }
    }

//     problem statement

// 242. Valid Anagram
// Solved
// Easy
// Topics
// Companies
// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

// Example 1:

// Input: s = "anagram", t = "nagaram"
// Output: true
// Example 2:

// Input: s = "rat", t = "car"
// Output: false
 

// Constraints:

// 1 <= s.length, t.length <= 5 * 104
// s and t consist of lowercase English letters.
 

// Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?