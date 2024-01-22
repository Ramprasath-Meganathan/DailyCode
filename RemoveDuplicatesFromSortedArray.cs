namespace DailyCode;    

static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicatesFromSortedArrayFn(int[] nums)
        {
            HashSet<int> result = [];
            var dupes = 0;
            for(int i=0;i<nums.Length; i++)
            {
                if(result.Count == 0)
                {
                    result.Add(nums[i]);
                    continue;
                }
                else if(result.Contains(nums[i]))
                {
                    dupes++;
                    continue;
                }
                result.Add(nums[i]);
            }
            for(int j=result.Count; j<= nums.Length; j++)
                result.Add(-101);
            nums = [.. result];
            return nums.Length;
        }
    }