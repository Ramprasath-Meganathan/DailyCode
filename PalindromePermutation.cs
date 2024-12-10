public class PalindromeChecker
{
    // O(n*s) time and O(s) space where s is the number of unique characters in the array
    public bool CheckPalindrome(string s)
    {
        var keyValuePairs = GetCharCounter(s);
        // linq version
        // return keyValuePairs.All(x => x.Value % 2 == 0);
        // normal version O(n) time 
        foreach (var keyValue in keyValuePairs)
        {
            if (keyValue.Value % 2 != 0)
                return false;
        }
        return true;
    }


    // O(n) time and O(1) space
    public bool PalindromeChekerInMemory(string s)
    {
        int start = 0; int end = s.Length -1 ;
        while(start<end)
        {
            if(s[start] != s[end])
                return false;
            start++;
            end--;
        }
        return true;
    }

    private Dictionary<char, int> GetCharCounter(string s)
    {
        var keyValuePairs = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (keyValuePairs.ContainsKey(s[i]))
                keyValuePairs[s[i]] += 1;
            else
                keyValuePairs[s[i]] = 1;
        }
        return keyValuePairs;
    }
}
