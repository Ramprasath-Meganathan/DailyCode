public class LengthOfLongestSubstring
{

    // O(n) time and O(1) space
    public int LengthOfLongestSubstringMethod(string s)
    {
        HashSet<char> subStringSet = new HashSet<char>(); // O(n) time and O(1) space
        int maxLength = 0, left = 0; // O(1) ts
        for (int right = 0; right < s.Length; right++) // O(n) time
        {
            while (subStringSet.Contains(s[right])) // O(1) ts
            {
                subStringSet.Remove(s[left]); // O(1)ts
                left += 1; // O(1) ts
            }
            subStringSet.Add(s[right]); //  O(1) ts
            maxLength = Math.Max(maxLength, right - left + 1); //   O(1) ts

        }
        return maxLength;
    }
}