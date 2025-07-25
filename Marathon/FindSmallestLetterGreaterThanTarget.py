class Solution:
    #O(n) time and O(1) space
    def nextGreatestLetter(self, letters: List[str], target: str) -> str:
       for letter in letters:
            if ord(letter)>ord(target):
                return letter
       return letters[0]
            
    #Binary Search
    def kthSmallest(self, matrix: List[List[int]], k: int) -> int:
        #O(n2logn) time and O(n2) space
        count = 0
        flat = []
        for row in matrix:
            for el in row:
                flat.append(el)
        flat.sort()
        return flat[k-1]        

# 744. Find Smallest Letter Greater Than Target
#You are given an array of characters letters that is sorted in non-decreasing order, and a character target. There are at least two different characters in letters.

# Return the smallest character in letters that is lexicographically greater than target. If such a character does not exist, return the first character in letters.


# Example 1:

# Input: letters = ["c","f","j"], target = "a"
# Output: "c"
# Explanation: The smallest character that is lexicographically greater than 'a' in letters is 'c'.
# Example 2:

# Input: letters = ["c","f","j"], target = "c"
# Output: "f"
# Explanation: The smallest character that is lexicographically greater than 'c' in letters is 'f'.
# Example 3:

# Input: letters = ["x","x","y","y"], target = "z"
# Output: "x"
# Explanation: There are no characters in letters that is lexicographically greater than 'z' so we return letters[0].
 