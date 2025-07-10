class solution:  
    def subsets(self, nums: List[int]) -> List[List[int]]:
            #O(n*2pown) time and O(h) space where h is the height of the stack frame
            res, sol = [],[]
            n = len(nums)
            def backtrack(i):
                if i == n:
                    res.append(sol[:])
                    return
                # don't consider val
                backtrack(i+1)
                #consider val
                sol.append(nums[i])
                backtrack(i+1)
                sol.pop()
            backtrack(0)
            return res

#iterative solution
    def subsets(self, nums: List[int]) -> List[List[int]]:
        res = [[]]
        for num in nums:
                res+=[subset+[num] for subset in res]
        return res

#Given an integer array nums of unique elements, return all possible subsets (the power set).

# The solution set must not contain duplicate subsets. Return the solution in any order.

# Example 1:

# Input: nums = [1,2,3]
# Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
# Example 2:

# Input: nums = [0]
# Output: [[],[0]]
 

# Constraints:

# 1 <= nums.length <= 10
# -10 <= nums[i] <= 10
# All the numbers of nums are unique.