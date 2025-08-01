class KthLargest:
    def __init__(self, k: int, nums: List[int]):
        self.k = k
        self.arr = nums
    def add(self, val: int) -> int:
        self.arr.append(val)
        self.arr.sort()
        return self.arr[len(self.arr)-self.k]

        #O(mlogk time for add and O(k) space
    def __init__(self, k: int, nums: List[int]):
        self.k = k
        self.min_heap =nums
        heapq.heapify(self.min_heap)
        while len(self.min_heap)>k:
            heapq.heappop(self.min_heap)

    def add(self, val: int) -> int:
        heapq.heappush(self.min_heap,val)
        if len(self.min_heap)>self.k:
            heapq.heappop(self.min_heap)
        return self.min_heap[0]
