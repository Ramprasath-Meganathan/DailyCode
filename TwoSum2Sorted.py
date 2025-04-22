class Solution:
    # O(n) time and O(1) space
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        i , j = 0, len(numbers)-1 #O(1) time and O(1) space
        while i < j: #O(n) time and O(1) space
            numToCheck = numbers[i]+numbers[j] #O(1) time and O(1) space
            if numToCheck == target: #O(1) time and O(1) space
                return [i+1,j+1] #O(1) time and O(1) space
            elif numToCheck < target:  #O(1) time and O(1) space
            i+=1 #O(1) time and O(1) space
            else: #O(1) time and O(1) space
            j-=1 #O(1) time and O(1) space
        return [0,0] # O(n) time and O(1) space
    
    # O(n^2) time and O(1) space
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        for i in range(len(numbers)): #O(n) time and O(1) space
            for j in range(i+1,len(numbers)): #O(n) time and O(1) space
                if(numbers[i]+numbers[j]==target): #O(1) time and O(1) space
                    return [i+1,j+1] #O(1) time and O(1) space