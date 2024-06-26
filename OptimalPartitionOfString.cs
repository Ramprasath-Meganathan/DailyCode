public class OptimalPartitionOfString {
    public int PartitionString(string s) {
      Dictionary<char,int> counter = new Dictionary<char,int>();
      for(int i=0;i<s.Length;i++)
      {
        if(counter.ContainsKey(s[i]))
            counter[s[i]] +=1;
        else
            counter[s[i]] = 1;
      }
      return (counter.OrderByDescending(x=>x.Value).First()).Value;
    }
}