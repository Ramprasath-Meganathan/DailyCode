class Solution:
    #O(n^2) time and O(1) space
    #Rotate by four cells
    def rotate(self, matrix: List[List[int]]) -> None:
        """
        Do not return anything, modify matrix in-place instead.
        """
        left,right = 0,len(matrix)-1

        while left<right:
            for i in range(right-left):
                top,bottom =left,right

                #save the topleft
                topLeft = matrix[top][left+i]

                #move bottom Left into topLeft
                matrix[top][left+i] = matrix[bottom-i][left]

                #move bottom right into bottom left
                matrix[bottom-i][left] = matrix[bottom][right-i]

                #move top right into bottom right
                matrix[bottom][right-i] = matrix[top+i][right]

                #move top left to top right
                matrix[top+i][right] = topLeft
            left+=1
            right-=1

    #O(n^2) time and O(n2) space
    def rotate(self, matrix: List[List[int]]) -> None:
        n = len(matrix)
        rotated = [[0] * n for _ in range(n)]
        
        for i in range(n):
            for j in range(n):
                rotated[j][n - 1 - i] = matrix[i][j]
        
        for i in range(n):
            for j in range(n):
                matrix[i][j] = rotated[i][j]       

    #O(n^2) time and O(1) space
    #Reverse And Transpose
    def rotate(self, matrix: List[List[int]]) -> None:
        # Reverse the matrix vertically
        matrix.reverse()

        # Transpose the matrix
        for i in range(len(matrix)):
            for j in range(i + 1, len(matrix)):
                matrix[i][j], matrix[j][i] = matrix[j][i], matrix[i][j]
