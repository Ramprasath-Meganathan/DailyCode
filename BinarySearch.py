class BinarysearchPython:
    // O(log n) time and O(1) spaceß
    def search(self, nums: List[int], target: int) -> int:
        min, max = 0, len(nums) -1
        while min<=max:
            mid = int(min+(max-min)/2)
            if target==nums[mid]:
                return mid
            elif target<nums[mid]:
                max=mid-1
            else:
                min = mid+1
        return -1


            