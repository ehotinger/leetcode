// https://leetcode.com/problems/minimum-path-sum/
public class Solution {
    public int MinPathSum(int[][] grid) {
        // Fill out the first row
        for(int j = 1; j < grid[0].Length; j++) {
            grid[0][j] += grid[0][j-1];
        }
        
        // Fill out the first column
        for(int i = 1; i < grid.Length; i++){
            grid[i][0] += grid[i-1][0];
        }
        
        // For the remaining grid, get the minimum from the left or above.
        for(int i = 1; i < grid.Length; i++) {
            for(int j = 1; j < grid[i].Length; j++) {
                grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j-1]);
            }
        }
        
        var arr = grid[grid.Length-1];
        return arr[arr.Length - 1];
    }
}