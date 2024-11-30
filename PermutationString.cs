using System.Collections.Immutable;

public static class PermutationString
{
    public static bool PermutationStringSolution(string str1, string str2)
    {
        var sortedStr1 = str1.ToCharArray();
        Array.Sort(sortedStr1);
        var sortedStr2 = str1.ToCharArray();
        Array.Sort(sortedStr2);
        var newStr1 = new string(sortedStr1);
        var newStr2 = new string(sortedStr2);
        return newStr1.Equals(newStr2);
    }
}