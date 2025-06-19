    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        #O(n^2) time and O(1) space
        if not nums or k < 0:
            return False
        # Brute Force Approach
        for i in range(len(nums)-1):
            for j in range(i+1,len(nums)):
                if nums[i]==nums[j]:
                    if abs(i-j)<=k:
                        return True
        return False
    
    #Dictionary Approach 
        def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        #O(n) time and O(min(n,k)) space
        dupSet = {}
        for i,num in enumerate(nums): #O(n) time and O(1) space
            if num in dupSet and abs(dupSet[num]-i)<=k: 
                return True
            dupSet[num] = i #O(k) space where k is the number of unique elements 
        return False
    
    #Sliding Window Approach
    #O(n) time and O(min(k,n)) space
      seen = set()
      for i, num in enumerate(nums):
        if num in seen:
            return True
        seen.add(num)
        if len(seen)>k:
            seen.remove(nums[i-k])
      return False

         
    
