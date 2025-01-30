class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        hash_map = {}
        for i, v in enumerate(nums):
            if target-v in hash_map:
                return i, hash_map[target-v]
            else:
                hash_map[v] = i
                     

    def twoSumn2(self, nums: List[int], target: int) -> List[int]:
        for i in range(len(nums)):
            for j in range(i+1, len(nums)):
                if nums[i] + nums[j] == target:
                    return i,j
            
        

        