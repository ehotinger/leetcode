// https://leetcode.com/problems/maximize-distance-to-closest-person/submissions/
using System;
public class Solution {
    public int MaxDistToClosest(int[] seats) {
       
        var left = new int[seats.Length];
        var right = new int[seats.Length];
        
        Array.Fill(left, seats.Length);
        Array.Fill(right, seats.Length);
        
        // [1,0,0,0,1,0,1]
        for(int i = 0; i < seats.Length; ++i ){
            if(seats[i] == 1) {
                left[i] = 0;
            } else if (i > 0) {
                left[i] = left[i-1] + 1;
            }
        }
        
        for(int i = seats.Length-1; i >= 0; --i ){
            if(seats[i] == 1) {
                right[i] = 0;
            } else if (i < seats.Length - 1) {
                right[i] = right[i+1] + 1;
            }
        }
        
        var max = 0;
        for(int i = 0; i < left.Length; i++ ) {
            if (seats[i] == 0) {
                max = Math.Max(max, Math.Min(left[i], right[i]));
            }
        }
        return max;
    }
}