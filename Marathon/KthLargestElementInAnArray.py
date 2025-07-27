class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:
        #O(k*n) times and O(1) space
        for _ in range(1,k):
            nums.remove(max(nums)) #O(n) time
        return max(nums) #O(n) time 
            
    def findKthLargest(self, nums: List[int], k: int) -> int:
        #O(nlogk) time and O(k) space
        min_heap = []
        for num in nums: 
            heapq.heappush(min_heap,num) #O(logk) time 
            if len(min_heap)>k:
                heapq.heappop(min_heap) #O(logk) time 
        return min_heap[0]
                     