class Solution:
    def isHappy(self, n: int) -> bool:
       happySet = set()
       while n != 1:
            if n in happySet:
                return False
            happySet.add(n)
            n = sum(int(digit)**2 for digit in str(n))
       return True
            


            