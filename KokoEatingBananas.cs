
public class KokoEatingBananas {
    // O(n(max(piles))) time and O(1) space
    public int MinEatingSpeed(int[] piles, int h) {
        if(piles == null|| piles.Length == 0) // O(1) time
            return -1; // O(1) time
        int maxSpeed = piles.Max(); // O(n) time
        for(int i = 1; i<=maxSpeed; i++) // O(max(piles)) time
        {
            int totalHours = 0;  // O(1) time
            foreach(var pile in piles) // O(n) time
                totalHours += (int)Math.Ceiling((double)pile/i); // O(1) time
            if(totalHours<=h)   // O(1) time
                return i; // O(1) time
        }
        return maxSpeed; // O(1) time
    }

    // O(nlog(max(piles))) time and O(1) space
     public int MinEatingSpeedBinarySearch(int[] piles, int h) {
        if(piles == null|| piles.Length == 0 || h<piles.Length) // O(1) timespace
            return -1; // O(1 timespace
        int maxSpeed = piles.Max(); // O(n) time O(1) space
        int left = 1, right = maxSpeed; //O(1) time O(1) space
        int result = right; //O(1) time O(1) space
        while(left<=right) //O(log(max(piles))) time O(1) space
        {
            int mid = left+(right-left)/2; //O(1) time O(1) space
            long totalHours = 0; //O(1) time O(1) space
            foreach(var pile in piles) //O(n) time O(1) space
                totalHours+=(int)Math.Ceiling((double)pile/mid); //O(1) time O(1) space
            if(totalHours<=h) //O(1) time O(1) space
            {
                result = mid; //O(1) time O(1) space
                right = mid-1; //O(1) time O(1) space
            }
            else
                left = mid+1; //O(1) time O(1) space
        }
        return result; //O(1) time O(1) space
    }
}