public class TopKFrequentElements {

    // O(n
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(var value in nums)
        {
            if(!dict.ContainsKey(value))
                dict[value] =1 ;
            else
                dict[value]+=1;
        }
        return [.. dict.OrderByDescending(x=>x.Value).Select(x=>x.Key).Take(k)]; 
    }

     public int[] TopKFrequentOptimized(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(var value in nums)
        {
            if(!dict.ContainsKey(value))
                dict[value] =1 ;
            else
                dict[value]+=1;
        }
        KeyValuePair<int,int>[] freqArray = new KeyValuePair<int,int>[dict.Count];
        int index = 0;
        foreach(var kv in dict)
        {
            freqArray[index++] = kv;
        }

        SortByFrequency(freqArray);
        int[] result = new int[k];
        for(int i =0 ; i<k; i++)
        {
            result[i] = freqArray[i].Key;
        }
        return result;
    }

    private void SortByFrequency(KeyValuePair<int, int>[] arr)
    {
        for(int i = 0; i < arr.Length -1 ; i++)
        {
            for(int j = i+1; j < arr.Length; j++)
            {
                if(arr[i].Value<arr[j].Value)
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    // using priority Queue
    public int[] TopKFrequentOptimized1(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(var value in nums)
        {
            if(!dict.ContainsKey(value))
                dict[value] =1 ;
            else
                dict[value]+=1;
        }
       var pq = new PriorityQueue<int, int>();
       foreach(var kv in dict)
       {
        pq.Enqueue(kv.Key, kv.Value);
        if(pq.Count>k)
            pq.Dequeue();
       }
        int[] result = new int[k];
       for(int i = 0; i<k; i++)
       {
        result[i]= pq.Dequeue();
       }
       return result;
    }

}
