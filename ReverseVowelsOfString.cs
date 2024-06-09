public class ReverseVowelsProgram {
    // O(n2) time and O(n) space
    public string ReverseVowels(string s) {
        List<char> hs = new List<char>();
        List<char> vowels = new List<char>{'a','e','i','o','u','A','E','I','O','U'};
        for(int i=0;i<s.Length;i++)
        {
            if(vowels.Contains(s[i]))
                hs.Add(s[i]);
        }
        int counter = hs.Count-1;
        string result ="";
        foreach(var c in s)
        {
            if(vowels.Contains(c))
            {
                while(counter>=0)
                {
                    result+=hs[counter];
                    counter--;
                    break;
                }
            }
            else
            {
                result+=c;
            }
        }
        return result;
    }
    // O(n) time and O(1) space
    public class ReverseVowelsOptimized {
    private List<char> vowels = new List<char>{'a','e','i','o','u','A','E','I','O','U'};
    public string ReverseVowels(string s) {
        List<char> hs = new List<char>();
        List<int> indexes = new List<int>();
        for(int i=0;i<s.Length;i++)
        {
            if(isVowel(s[i]))
            {
                hs.Add(s[i]);
                indexes.Add(i);
            }
        }
        int counter = hs.Count-1;
        char[] sArray = s.ToCharArray();
        foreach(int idx in indexes)
        {
           sArray[idx]= hs[counter];
           counter--;
        }
        return new string(sArray);
    }
    private bool isVowel(char c)
    {
        return vowels.Contains(c);
    }

    public string ReverseVowelsUsingStack(string s) {
        Stack<char> hs = new Stack<char>();
        List<int> indexes = new List<int>();
        for(int i=0;i<s.Length;i++)
        {
            if(isVowel(s[i]))
            {
                hs.Push(s[i]);
                indexes.Add(i);
            }
        }
        char[] sArray = s.ToCharArray();
        foreach(int idx in indexes)
        {
           sArray[idx]= hs.Pop();
        }
        return new string(sArray);
    }
}
}

// Given a string s, reverse only all the vowels in the string and return it.

// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

// Example 1:

// Input: s = "hello"
// Output: "holle"
// Example 2:

// Input: s = "leetcode"
// Output: "leotcede"
 

// Constraints:

// 1 <= s.length <= 3 * 105
// s consist of printable ASCII characters.