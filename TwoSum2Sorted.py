class Solution:
    // O(n) time and O(1) space
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        i , j = 0, len(numbers)-1
        while i < j:
            numToCheck = numbers[i]+numbers[j]
            if numToCheck == target:
                return [i+1,j+1]
            elif numToCheck < target:
                i+=1
            else:
                j-=1
        return [0,0]