// https://leetcode.com/problems/merge-intervals/
/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public IList<Interval> Merge(IList<Interval> intervals) {
        if(intervals == null || intervals.Count <= 1) return intervals;
        
        var ret = new List<Interval>();
        foreach(var interval in intervals.OrderBy(x => x.start)) {
            // Add the current element to the return list if its start is greater than the previous element's end
            if(ret.Count == 0 || ret[ret.Count-1].end < interval.start) {
                ret.Add(interval);
            } else { // Extend the range
                ret[ret.Count-1].end = Math.Max(interval.end, ret[ret.Count-1].end);
            }
        }
        
        return ret;
    }
}