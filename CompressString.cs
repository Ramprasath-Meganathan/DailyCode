public abstract class CompressString
{
    public abstract string? Compress(string chars);
}

public class CompressStringSolution1 : CompressString
{
    // O(p+k2) where p is the original string and k2 is for adding strings
    public override string? Compress(string chars)
    {
        string compressedString = "";
        int countConsecutive = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            countConsecutive++;
            if (i + 1 >= chars.Length || chars[i] != chars[i + 1])
            {
                compressedString += chars[i]+ countConsecutive.ToString();
                countConsecutive = 0;
            }
        }
        return compressedString.Length < chars.Length ? compressedString : chars.ToString();
    }
}