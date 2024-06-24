public class KthFactor {
    public int KthFactorMethod(int n, int k) {
        List<int> factList = new List<int>();
        if(n>0&&n>k)
        {
            factList.Add(1);
            for(int i=2;i<=k;i++)
            {
                if(n%i==0)
                    factList.Add(i);
            }
        }
        int[] array = factList.ToArray();
        return array[k-1];
    }
}