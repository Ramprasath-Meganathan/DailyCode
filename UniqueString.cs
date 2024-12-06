using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// O(n) time and O(1) space

// solution 1
public static class UniqueString {

    // abcd
    public static bool FindUniqueString(string s) {
        Dictionary<char,int> uniqueCounter = new Dictionary<char,int>();
        for(int i = 0; i< s.Length; i++)
        {
            if(uniqueCounter.ContainsKey(s[i]))
                return false;
            else
                uniqueCounter[s[i]]=1;
        }
        return true;
    }

    // O(n) time and O(1) space
    public static bool FindUniqueStringSolution2(string s)
    {
        bool[] charSet= new bool[128]; //ASCII assumption
        for(int i=0; i< s.Length; i++)
        {
            int val = s[i];
            if(charSet[val])
                return false;
            else
                charSet[val] = true;
        }
        return true;
    }

    // O(n) time and O(1) space
    public static bool FindUniqueStringSolution3(string s)
    {
        HashSet<int> charSet= []; 
        for(int i=0; i< s.Length; i++)
        {
            int val = s[i];
            if(charSet.Contains(val))
                return false;
            charSet.Add(val);
        }
        return true;
    }
}


// Find if string has unique characters

// Testcase         string input = "abbcd";
// input = "abcd"
