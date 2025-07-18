class Solution:
    #O(n2) time and O(n) space
    def findDisappearedNumbers(self, nums: List[int]) -> List[int]:
        res = []
        for i in range(1,len(nums)+1):
            if i not in nums:
                res.append(i)
        return res