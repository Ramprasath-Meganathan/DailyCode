class Solution:
    #O(logn) time and O(logn) space
    def hammingWeight(self, n: int) -> int:
        onebit = 0
        for digit in bin(n):
            if digit == '1':
                onebit+=1
        return onebit