using System;
using System.Collections;
using System.Collections.Generic;

// NB: could optimize for space better here and create just one dictionary for counting each key and value.
// The trick is just to inc/dec the value instead.
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var numAndCount1 = new Dictionary<int, int>();
        var numAndCount2 = new Dictionary<int, int>();
        foreach (var num in nums1) {
            if (numAndCount1.ContainsKey(num)) {
                numAndCount1[num]++;
            } else {
                numAndCount1.Add(num, 1);
            }
        }
        
        foreach (var num in nums2) {
            if (numAndCount2.ContainsKey(num)) {
                numAndCount2[num]++;
            } else {
                numAndCount2.Add(num, 1);
            }
        }
        
        var ret = new List<int>();
        foreach(var key in numAndCount1.Keys){
            if(numAndCount2.ContainsKey(key)) {
                var min = Math.Min(numAndCount2[key], numAndCount1[key]);
                for(int i = 0; i < min; i++ ) {
                    ret.Add(key);
                }
            }
        }
        
        return ret.ToArray();
    }
}