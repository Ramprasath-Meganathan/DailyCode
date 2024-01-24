static class ValidateSubSequence
{
    //Time complexity = O(N2), 
    public static bool ValidateSubSequenceFunction(List<int> array, List<int> sequence)
    {
       var convertedArray = array.ToArray();
      var sequenceArray = sequence.ToArray();
      int offset = 0;
      int count = 0;
      if(sequenceArray.Length <= convertedArray.Length)
      {
      for(int i=0;i<sequenceArray.Length; i++)
      {
          for(int j=offset; j<convertedArray.Length; j++)
          {
              if(sequenceArray[i] == convertedArray[j])
              {
                  offset = offset< convertedArray.Length -1 ? j+1: j;
                  count++;
                  break;
              }
          }
      }
    }
    return sequenceArray.Length == count;
}

//Time complexity - O(N)
public static bool ValidateSubSequenceOptimized(List<int> array, List<int> sequence)
{
     int pivot = 0;
    var convertedArray = array.ToArray();
    var sequenceArray = sequence.ToArray();
    if(sequenceArray.Length <= convertedArray.Length)
    {
    for(int i=0; i < convertedArray.Length; i++)
    {
        if(pivot < sequenceArray.Length)
        {
        if(convertedArray[i] == sequenceArray[pivot])
        {
            pivot++;
        }
        }
    }
    }
    return pivot == sequenceArray.Length;
  }
}