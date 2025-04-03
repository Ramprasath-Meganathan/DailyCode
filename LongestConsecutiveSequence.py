 def longestConsecutive(self, nums: List[int]) -> int:
        if not nums:
            return 0
        numsSet = set(nums)
        longestStreak = 0
        for num in nums:
            if num-1 not in numsSet:
                currentStreak = 1
                currentValue = num
                while currentValue+1 in numsSet:
                    currentStreak+=1
                    currentValue+=1
                longestStreak = max(currentStreak,longestStreak)
        return longestStreak