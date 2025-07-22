class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        #O(n) time and O(1) space
        for num in nums:
            index = abs(num) - 1
            if nums[index]<0:
                return abs(num)
            nums[index]=nums[index]*-1
        return -1
    
    #O(n) time and O(1) space
    #Floyd's Tortoise and Hare (Cycle Detection)
    #This approach uses the fact that the array can be treated as a linked list where each
    #element points to the next index, and since there is a duplicate, there will be a cycle.
    #We use two pointers, one moving twice as fast as the other, to find the intersection point.
    #Once we find the intersection, we reset one pointer to the start and move both pointers at the same speed until they meet again,
    #which will be the duplicate
    def findDuplicate(self, nums: List[int]) -> int:
       fast,slow = 0,0
       while True:
        fast = nums[nums[fast]]
        slow = nums[slow]
        if slow == fast:
            break
       slow2 = 0
       while True:
            slow = nums[slow]
            slow2 = nums[slow2]
            if(slow==slow2):
                return slow
# 287. Find the Duplicate Number
# Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.

# There is only one repeated number in nums, return this repeated number.

# You must solve the problem without modifying the array nums and using only constant extra space.

 

# Example 1:

# Input: nums = [1,3,4,2,2]
# Output: 2
# Example 2:

# Input: nums = [3,1,3,4,2]
# Output: 3
# Example 3:

# Input: nums = [3,3,3,3,3]
# Output: 3
 

# Constraints:

# 1 <= n <= 105
# nums.length == n + 1
# 1 <= nums[i] <= n
# All the integers in nums appear only once except for precisely one integer which appears two or more times.
 

# Follow up:

# How can we prove that at least one duplicate number must exist in nums?
# Can you solve the problem in linear runtime complexity?
            
       
        