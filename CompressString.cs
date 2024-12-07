using System.Text;

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
                compressedString += chars[i] + countConsecutive.ToString();
                countConsecutive = 0;
            }
        }
        return compressedString.Length < chars.Length ? compressedString : chars.ToString();
    }
}

public class CompressStringSolution2 : CompressString
{
    // O(p+k2) where p is the original string and k2 is for adding strings
    public override string? Compress(string chars)
    {
        var compressedString = new StringBuilder();
        int countConsecutive = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            countConsecutive++;
            if (i + 1 >= chars.Length || chars[i] != chars[i + 1])
            {
                compressedString.Append(chars[i]);
                compressedString.Append(countConsecutive.ToString());
                countConsecutive = 0;
            }
        }
        return compressedString.Length < chars.Length ? compressedString.ToString() : chars.ToString();
    }
}

public class CompressStringUpFront : CompressString
{
    // O(p+k2) where p is the original string and k2 is for adding strings
    public override string? Compress(string chars)
    {
        int countConsecutive = 0;
        int finalLength = CountCompression(chars);
        if (finalLength > chars.Length)
            return chars;
        var compressedString = new StringBuilder(finalLength);
        for (int i = 0; i < chars.Length; i++)
        {
            countConsecutive++;
            if (i + 1 >= chars.Length || chars[i] != chars[i + 1])
            {
                compressedString.Append(chars[i]);
                compressedString.Append(countConsecutive.ToString());
                countConsecutive = 0;
            }
        }
        return compressedString.Length < chars.Length ? compressedString.ToString() : chars.ToString();
    }

    private int CountCompression(string chars)
    {
        int compressedLength = 0, countCompression = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            countCompression++;
            if (i + 1 >= chars.Length || chars[i] != chars[i + 1])
            {
                compressedLength += countCompression;
                countCompression = 0;
            }
        }
        return compressedLength;
    }
}