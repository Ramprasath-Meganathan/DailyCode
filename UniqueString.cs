using System.Linq;

// O(n) time and O(1) space
public static class UniqueString {
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
}

// Find if string has unique characters