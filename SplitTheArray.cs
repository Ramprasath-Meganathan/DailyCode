public class SplitTheArray
{
    // Time complexity: O(n)
    // Space complexity: O(n)
    public bool IsPossibleToSplit(int[] nums)
    {
        Dictionary<int, int> frequencyDict = new Dictionary<int, int>(nums.Length); // O(n) space
        foreach (var val in nums) // O(n) time
        {
            if (frequencyDict.ContainsKey(val)) 
                frequencyDict[val] += 1;
            else
                frequencyDict[val] = 1;
        }
        return !frequencyDict.Values.Any(kv => kv > 2); // O(n) time O(1) space
    }
}