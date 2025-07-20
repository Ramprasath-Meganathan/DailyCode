
class solution: 
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        #brute force solution
            res = []
            #O(n2) time and O(1) space
            for i in range(len(nums)):
                product = 1
                for j in range(len(nums)):
                    if i !=j:
                        product*=nums[j]
                res.append(product)
            return res
        
        #prefix and suffix solution
    def productExceptSelfPrefix(self, nums: List[int]) -> List[int]:
            n = len(nums)
            res = [1] * n
            
            # Calculate prefix products
            prefix = 1
            for i in range(n):
                res[i] = prefix
                prefix *= nums[i]
            
            # Calculate suffix products and multiply with prefix
            suffix = 1
            for i in range(n-1, -1, -1):
                res[i] *= suffix
                suffix *= nums[i]
            
            return res