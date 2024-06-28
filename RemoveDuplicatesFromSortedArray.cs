namespace DailyCode;    

static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicatesFromSortedArrayFn(int[] nums)
        {
              int count= 1;
            for(int i=0;i<nums.Length-1; i++)
            {
                if(nums[i] != nums[i+1])
                {
                    count++;
                    nums[count] = nums[i];
                }
            }
         return count;
        }
    }