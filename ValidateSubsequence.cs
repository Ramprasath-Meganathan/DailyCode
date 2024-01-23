static class ValidateSubSequence
{
    public static bool ValidateSubSequenceFunction(List<int> array, List<int> sequence)
    {
        int existCount = 0;
        var convertedArray = array.ToArray();
        var sequenceArray = sequence.ToArray();
      if(convertedArray.Length < sequenceArray.Length)
      {
        for(int i=0; i< sequenceArray.Length; i++)
        {
            bool valueExists = false;
            for(int j=0;j< convertedArray.Length; j++)
            {
                if (sequence[i] == array[j])
                {
                        existCount++;
                        valueExists = true;
                        break;
                }
            }
            if(!valueExists)
            {
                return false;
            }

        }
        return existCount == sequenceArray.Length;
    }
    return false;
    }
}