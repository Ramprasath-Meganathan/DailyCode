class Solution:
    # O(n^2) time and O(1) space
    def maxArea(self, heights: List[int]) -> int:
        res = 0
        for i in range(len(heights)):
            for j in range(i+1, len(heights)):
                res = max(res, min(heights[i], heights[j])*(j-i))
        return res
    

    # O(n) time and O(1) space
    def maxArea(self, height: List[int]) -> int:
        res = 0
        l,r = 0, len(height) -1 
        while(l<=r):
            area = min(height[l],height[r])*(r-l)
            res = max(res, area)
            if(height[l]<=height[r]):
                l+=1
            else:
                r-=1
        return res

            
