class Solution:
     def maxArea(self, height: List[int]) -> int:
        #O(n2)time and O(1) space
        maxArea = 0 #O(1) time and O(1) space
        for i in range(len(height)): #O(n) time and O(1) space
            for j in range(len(height)): #O(n) time and O(1) space
                maxArea = max(maxArea,min(height[i],height[j])*(j-i)) #O(1) time and O(1) space
        return maxArea #O(1) time and O(1) space
    
    # O(n) time and O(1) space
    def maxArea(self, height: List[int]) -> int:
        res = 0     # O(1) time and O(1) space
        l,r = 0, len(height) -1     # O(1) time and O(1) space
        while(l<=r):    # O(n) time and O(1) space
            area = min(height[l],height[r])*(r-l)     # O(1) time and O(1) space
            res = max(res, area)     # O(1) time and O(1) space
            if(height[l]<=height[r]):  # O(1) time and O(1) space
                l+=1  # O(1) time and O(1) space
            else: # O(1) time and O(1) space
                r-=1 # O(1) time and O(1) space
        return res # O(1) time and O(1) space

            
