class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        #O(n2) time and O(n) space
        productArray = [] #O(1) time and O(n) space
        for i in range(len(nums)): #O(n) time and O(1) space
            product = 1 #O(1) time and O(1) space
            for j in range(len(nums)): #O(n) time and O(1) space
                if i != j: #O(1) time and O(1) space
                    product*=nums[j] #O(1) time and O(1) space
            productArray.append(product) #O(1) time and O(1) space
        return productArray #O(1)time and O(1) space

    def productExceptSelf(self, nums: List[int]) -> List[int]:
     #O(n) time and O(n) space
        product,zero_cnt=1,0 #O(1) time and O(1) space
        # iterate through nums to get zeroes count and product
        for num in nums: #O(n) time and O(1) space
            if num: #O(1) time and O(1) space
                product*=num #O(1) time and O(1) space
            else: #O(1) time and O(1) space
                zero_cnt+=1 #O(1) time and O(1) space
        
        #if there are zeroes, then initialize array with zeroes
        res = [] #O(1) time and O(n) space
        if zero_cnt>1: #O(1) time and O(1) space
            return [0] * len(nums) #O(n) time and O(n) space
        
        # iterate through nums to fill result array
        res = [0]*len(nums) #O(n) time and O(n) space
        for i,v in enumerate(nums): #O(n) time and O(1) space
            if zero_cnt: #O(1) time and O(1) space
                res[i] = 0 if v else product #O(1) time and O(1) space
            else: #O(1) time and O(1) space
                res[i] = product//v #O(1) time and O(1) space
        
        return res #O(1) time and O(1) space

    def productExceptSelf(self, nums: List[int]) -> List[int]:
    #O(n) time and O(n) space 
       prefix = 1 #O(1) time and O(1) space
       res=[1] * len(nums) #O(n) time and O(n) space
       for i in range(len(nums)): #O(n) time and O(1) space
            res[i] = prefix #O(1) time and O(1) space
            prefix*=nums[i] #O(1) time and O(1) space
        
       postfix = 1 #O(1) time and O(1) space
       for i in range(len(nums)-1,-1,-1): #O(n) time and O(1) space
            res[i]*=postfix #O(1) time and O(1) space
            postfix*=nums[i] #O(1) time and O(1) space
        
       return res #O(1) time and O(1) space