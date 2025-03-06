public class Search2DMatrix {
    //O(m*n) time and O(1) space
    public bool SearchMatrix(int[][] matrix, int target) {
       foreach(var row in matrix)
       {
        foreach(var num in row) // O(m*n) time
        {
            if(num==target)
                return true;
        }
       }
       return false;
    }

    // O(log(m*n)) time and O(1) space
     public bool SearchMatrixBinarySearc(int[][] matrix, int target) {
       int row = matrix.Length, col = matrix[0].Length;
       int left = 0, right = row*col-1;
       while(left<=right)
       {
        int mid = left+(right-left)/2;
        int midValue = matrix[mid/col][mid%col];
        if(midValue==target)
            return true;
        if(midValue<target)
            left = mid+1;
        else
            right = mid-1;
       }
       return false;
    }
}
