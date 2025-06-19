    def containsDuplicate(self, nums: List[int]) -> bool:
        # Brute Force Approach
  #O(n2) time and O(1) space
        if not nums:
            return False
        for i in range(len(nums)-1):
            for j in range(i+1,len(nums)):
                if nums[i] == nums[j]:
                    return True
        return False

        #Contains Duplicate - Sorting solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        #O(nlogn) time and O(1) space
        nums.sort()
        for i in range(len(nums)-1): #O(n) time and O(1) space
            if nums[i]==nums[i+1]:
                return True
        return False

    #Contains Duplicate - HashSet solution
    def containsDuplicate(self, nums: List[int]) -> bool:
        #O(n) time and O(n) space
        if not nums:
            return False
        dupSet = set() 
        for num in nums: #O(n) time and O(1) space
            if num in dupSet:
                return True
            dupSet.add(num) #O(n) space
        return False
    
   # HashSet Length solution 
#O(n) time and O(n) space
    def containsDuplicate(self, nums: List[int]) -> bool:
        return len(set(nums)) < len(nums)
