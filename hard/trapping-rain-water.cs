// https://leetcode.com/problems/trapping-rain-water/
public class Solution {
    public int Trap(int[] height) {
        int[] maxLeft = new int[height.Length];
        int[] maxRight = new int[height.Length];
        
        var leftSoFar = 0;
        for(int i = 0; i < height.Length; i++) {
            leftSoFar = Math.Max(leftSoFar, height[i]);
            maxLeft[i] = leftSoFar;
        }
        var rightSoFar = 0;
        for(int i = height.Length-1; i >= 0; i--) {
            rightSoFar = Math.Max(rightSoFar, height[i]);
            maxRight[i] = rightSoFar;
        }
        
        //Console.WriteLine(string.Join(",", maxLeft));
        //Console.WriteLine(string.Join(",", maxRight));
        
        int total = 0;
        for(int i = 0; i < height.Length; i++) {
            total += Math.Min(maxLeft[i], maxRight[i]) - height[i];
        }
        
        return total;
    }
}