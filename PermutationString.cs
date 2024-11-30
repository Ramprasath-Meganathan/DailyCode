using System.Collections.Immutable;

public static class PermutationString
{
    // O(nlogn) time
    public static bool PermutationStringSolution(string str1, string str2)
    {
        if(str1.Length != str2.Length)
            return false;
        return Sort(str1).Equals(Sort(str1));
    }

    private static string Sort(string str)
    {
        var sortedStr = str.ToCharArray();
        Array.Sort(sortedStr);
        return new string(sortedStr);
    }

    // O(n) time 
    public static bool PermutationStringSolution2(string str1, string str2)
    {
        if(str1.Length != str2.Length)
             return false;
        
        int[] letters = new int[128];
        for(int i = 0; i < str1.Length; i++)
            letters[str1[i]]++;
        for(int i = 0; i < str2.Length; i++)
        {
            letters[str2[i]] --;
            if(letters[str2[i]]<0)
                return false;
        }
            return true;
       
    }
}