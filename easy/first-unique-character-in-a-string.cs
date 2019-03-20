using System;
using System.Collections;
using System.Collections.Generic;


// NB: could optimize more for memory if there are bounds on the string, i.e. string is only ASCII lowercase, you can preallocate an array of length 26.
public class Solution {
    public int FirstUniqChar(string s) {
        var dict = new Dictionary<char, int>();
        
        foreach(var c in s) {
            if(dict.ContainsKey(c)) {
                dict[c]++;
            } else {
                dict.Add(c, 1);
            }
        }
        
        for(int i=0; i < s.Length; i++ ) {
            if(dict[s[i]] == 1) {
                return i;
            }   
        }
        
        return -1;
    }
}