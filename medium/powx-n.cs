// https://leetcode.com/problems/powx-n/submissions/
public class Solution {
    public double MyPow(double x, int n) {
        if(n == 0) return 1;
        if(n == 1) return x;
        if(n == -1) return 1/x;
        
        var a = MyPow(x, n/2);
        return a * a * MyPow(x, n % 2);
    }
}





// Java iterative
public double myPow(double x, int n) {
    double result = 1;
    
    if(x == 1 || n == 0)
        return 1;
    if(x == -1)
        return n % 2 == 0 ? 1 : -1;
    if(n == Integer.MIN_VALUE)
        return 0;
    
    if(n < 0)
    {
        n = -n;
        x = 1 / x;
    }

    while(n > 0)
    {
        if(n % 2 == 1) 
            result *= x;
        
        x = x * x;
        n = n >> 1;
    }
    return result;
}