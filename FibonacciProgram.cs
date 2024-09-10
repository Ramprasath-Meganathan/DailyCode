public class Fibonacci {

    //O(2N) time and O(n) space
    public int Fib(int n) {
        if(n==0)
            return 0;
        if(n==1)
            return 1;
        while(n>0)
        {
            return Fib(n-1)+Fib(n-2);
        }
        return 0;
    }
}