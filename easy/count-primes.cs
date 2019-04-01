public class Solution {
    public int CountPrimes(int n) {
        var notPrime = new bool[n];
        int count = 0;
        for (int i = 2; i < n; i++) {
            if (!notPrime[i]) {
                count++;
                for (int j = 2; i*j < n; j++) {
                    notPrime[i*j] = true;
                }
            }
        }
        
        return count;
    }
    // public int CountPrimes(int n) {
    //     var sieve = new bool[n+1];
    //     Array.Fill(sieve, true);
        
    //     for (int p=2; p*p<=n; p++) {
    //         if (sieve[p]) { 
    //             for (int i=p*p; i<=n; i += p) 
    //                 sieve[i] = false; 
    //         }
    //     }
    
    //     var cnt = 0;
    //     for (int p=2; p<=n; p++){
    //         if (sieve[p]) cnt++;
    //     }
        
    //     return cnt;
    // }
}