class Solution:
    # O(n) time and O(n) space
    def isPalindrome(self, s: str) -> bool:
        cleanedText = ''.join(char.lower() for char in s if char.isalnum() and char !=' ')
        return cleanedText == cleanedText[::-1]
    
    # O(n) time and O(1) space
    def isPalindrome(self, s: str) -> bool:
        cleanedText = ''.join(char.lower() for char in s if char.isalnum() and char !=' ')
        i, j = 0, len(cleanedText)-1
        while i < j:
            if cleanedText[i] != cleanedText[j]:
                return False
            i+=1
            j-=1
        return True

        