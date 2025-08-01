class Solution:
    #Brute Force Approach
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        #O((m+n)log(m+n)) time and O(m+n) space
        res = []
        val = -1
        for i in range(len(nums1)):
            res.append(nums1[i])
        for i in range(len(nums2)):
            res.append(nums2[i])
        res.sort()
        l,r =0, len(res)-1
        mid = l+r//2
        if len(res)%2!=0:
            val= res[mid]
        else:
            val = (res[mid]+res[mid+1])/2
        return val
    

# Efficient Approach using Binary Search
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        #O(m+n) time and O(m+n) space
        res = []
        i,j = 0,0
        m,n = len(nums1),len(nums2)
        while i <  m and j < n:
            if nums1[i]<nums2[j]:
                res.append(nums1[i])
                i+=1
            else:
                res.append(nums2[j])
                j+=1
        while i<m:
            res.append(nums1[i])
            i+=1
        while j<n:
            res.append(nums2[j])
            j+=1
        total_len = len(res)
        mid = total_len//2
        if total_len%2==0:
            return (res[mid-1]+res[mid])/2
        else:
            return res[mid]
        
     

# 4. Median of Two Sorted Arrays    
#     Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

# The overall run time complexity should be O(log (m+n)).

 

# Example 1:

# Input: nums1 = [1,3], nums2 = [2]
# Output: 2.00000
# Explanation: merged array = [1,2,3] and median is 2.
# Example 2:

# Input: nums1 = [1,2], nums2 = [3,4]
# Output: 2.50000
# Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
 

# Constraints:

# nums1.length == m
# nums2.length == n
# 0 <= m <= 1000
# 0 <= n <= 1000
# 1 <= m + n <= 2000
# -106 <= nums1[i], nums2[i] <= 106