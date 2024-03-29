using System;

public class Transpose2DMatrix {
   // Time and Space ->O(r*l)
  public int[,] TransposeMatrix(int[,] matrix) {
    int rowLength = matrix.GetLength(0); 
    int colLength = matrix.GetLength(1); 
    int[,] outputMatrix = new int[colLength,rowLength];        
    for(int i=0;i<rowLength;i++)
    {
        for(int j=0;j<colLength;j++)
        {
            outputMatrix[j,i] = matrix[i,j];
        }
    }
      return outputMatrix;
  }
}
