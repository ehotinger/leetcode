// https://leetcode.com/problems/meeting-rooms/ 
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
    public bool CanAttendMeetings(Interval[] intervals) {
        if(intervals.Length<=1) return true;
        List<Interval> inter = intervals.OrderBy(x=>x.start).ToList();
        var prev = inter[0];
        for(int i = 1; i < inter.Count; i++){
            var curr = inter[i];
            if(curr.start == prev.start) return false;
            if(prev.end > curr.start) return false;
            
            prev = curr;
        }
        return true;
    }
}