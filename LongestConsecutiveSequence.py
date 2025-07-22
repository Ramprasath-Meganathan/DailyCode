class Solution:
    #O(n2) time and O(n) space - Brute force solution
    def longestConsecutive(self, nums: List[int]) -> int:
        maxStreak = 0 #O(1) time and O(1) space
        sequenceSet = set(nums) #O(n) time and O(n) space
        for num in nums: #O(n) time and O(1) space
                currentNumber, currentStreak = num, 0 #O(1) time and O(1) space
                while currentNumber in sequenceSet: #O(n) time and O(1) space
                    currentNumber+=1 #O(1) time and O(1) space
                    currentStreak+=1 #O(1) time and O(1) space
                maxStreak = max(currentStreak, maxStreak) #O(1) time and O(1) space
        return maxStreak #O(1) time and O(1) space


    #O(n) time and O(n) space 
    def longestConsecutive(self, nums: List[int]) -> int:
        maxStreak = 0 #O(1) time and O(1) space
        sequenceSet = set(nums) #O(n) time and O(n) space
        for num in nums: #O(n) time and O(1) space
            if num-1 not in sequenceSet:
                currentNumber, currentStreak = num, 1 #O(1) time and O(1) space
                while currentNumber+1 in sequenceSet: #O(n) time and O(1) space
                    currentNumber+=1 #O(1) time and O(1) space
                    currentStreak+=1 #O(1) time and O(1) space
                maxStreak = max(currentStreak, maxStreak) #O(1) time and O(1) space
        return maxStreak #O(1) time and O(1) space
 
 
    def longestConsecutive(self, nums: List[int]) -> int:
            if not nums: #O(1) time and O(1) space
                return 0 #O(1) time and O(1) space
            maxStreak = 0 #O(1) time and O(1) space
            i = 0 #O(1) time and O(1) space
            nums.sort() #O(nlogn) time and O(n) space
            currentNumber,currentStreak = nums[i],0 #O(1) time and O(1) space
            while i < len(nums): #O(n) time and O(1) space
                if currentNumber != nums[i]: #O(1) time and O(1) space
                    currentStreak = 0 #O(1) time and O(1) space
                    currentNumber = nums[i] #O(1) time and O(1) space
                while i<len(nums) and currentNumber == nums[i]: #O(1) time and O(1) space
                    i+=1 #O(1) time and O(1) space
                currentStreak+=1 #O(1) time and O(1) space
                currentNumber+=1 #O(1) time and O(1) space
                maxStreak = max(currentStreak,maxStreak) #O(1) time and O(1) space
            return maxStreak #O(1) time and O(1) space
        