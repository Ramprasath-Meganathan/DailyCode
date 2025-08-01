class solution:    
    def spiralOrder(self, matrix: List[List[int]]) -> List[int]:
            #O(m*n) time and O(1) space
            res = []
            left, right = 0, len(matrix[0])
            top,bottom = 0, len(matrix)

            while left<right and top<bottom:
                #go left to right
                for i in range(left,right):
                    res.append(matrix[top][i])
                top+=1
                
                #get every i in the right most column
                for i in range(top,bottom):
                    res.append(matrix[i][right-1])
                right-=1
                
                if not (left<right and top < bottom):
                    break

                #get every i in the bottom row
                for i in range(right-1,left-1,-1):
                    res.append(matrix[bottom-1][i])
                bottom-=1

                #get the inner square
                for i in range(bottom-1,top-1,-1):
                    res.append(matrix[i][left])
                left+=1
            return res