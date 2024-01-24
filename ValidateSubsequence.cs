static class ValidateSubSequence
{
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
}