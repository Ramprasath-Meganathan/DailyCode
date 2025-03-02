public class LongestRepeatingCharacterReplacement {
    // O(n) time and O(1) space
    public int CharacterReplacement(string s, int k) {
        int left = 0, maxCount = 0, maxLength = 0;
        int[] freq = new int[26];
        for(int right = 0; right < s.Length; right++)
        {
            freq[s[right]-'A']++;
            maxCount = Math.Max(maxCount, freq[s[right]-'A']);

            while((right-left+1)-maxCount > k)
            {
                freq[s[left] - 'A']--;
                left++;
            }
            maxLength = Math.Max(maxLength, right - left+1);
        }
        return maxLength;
    }
}