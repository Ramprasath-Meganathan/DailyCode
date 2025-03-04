public class PermutationInString {
    public bool CheckInclusion(string s1, string s2)
{
    if (s1.Length > s2.Length) return false; // Early exit if s1 is longer than s2

    int matches = 0;
    int[] s1freq = new int[26];
    int[] s2freq = new int[26];

    // Initialize frequency arrays for s1 and first window of s2
    for (int i = 0; i < s1.Length; i++)
    {
        s1freq[s1[i] - 'a']++;
        s2freq[s2[i] - 'a']++;
    }

    // Count initial matches
    for (int i = 0; i < 26; i++)
    {
        if (s1freq[i] == s2freq[i])
            matches++;
    }

    // Sliding Window
    int left = 0;
    int windowSize = s1.Length;
    for (int right = windowSize; right < s2.Length; right++)
    {
        if (matches == 26) return true; // If all character frequencies match, return true

        // Add new character from right side of the window
        int index = s2[right] - 'a';
        s2freq[index]++;

        // Update matches correctly
        if (s1freq[index] == s2freq[index])
            matches++; // Character frequency now matches
        else if (s1freq[index] + 1 == s2freq[index])
            matches--; // Character frequency exceeded, breaking a match

        // Remove old character from left side of the window
        index = s2[left] - 'a';
        s2freq[index]--;

        // Update matches correctly
        if (s1freq[index] == s2freq[index])
            matches++; // Character frequency now matches again
        else if (s1freq[index] - 1 == s2freq[index])
            matches--; // Character frequency no longer matches

        left++;
    }

    return matches == 26; // Final check after loop ends
}

}