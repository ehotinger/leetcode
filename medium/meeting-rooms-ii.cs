// https://leetcode.com/problems/meeting-rooms-ii/
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
    public int MinMeetingRooms(Interval[] intervals) {
        
        int[] starts = new int[intervals.Length];
        int[] ends = new int[intervals.Length];
        
        for(int i=0; i < intervals.Length; i++)
        {
            starts[i] = intervals[i].start;
            ends[i] = intervals[i].end;
        }
        
        Array.Sort(starts);
        Array.Sort(ends);
        int rooms = 0;
        int start = 0;
        int end = 0;
        
        while(start < intervals.Length)
        {
            // [[0,30],[5,10],[15,20]]
            // 0,5,15
            // 10,20,30
            
            // If we start another meeting and it's after the first end time
            // then one of the rooms has been cleared.
            if(starts[start] >= ends[end])
            {
                rooms--;
                end++;
            }
            // Otherwise we need to keep filling more rooms.
            rooms++;
            start++;
        }
        return rooms;
    }
}