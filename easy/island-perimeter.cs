public class Solution {
    public int IslandPerimeter(int[,] grid) {
        
        var numIslands=0;
        var neighbors=0;
        var x = grid.GetLength(0);
        var y = grid.GetLength(1);
        for(int i = 0; i <x; i++){
            for(int j =0; j < y; j++){
                if(grid[i,j]==1) {
                    numIslands++;
                    if(j+1 < y && grid[i,j+1] == 1) neighbors++;
                    if(i+1 < x && grid[i+1,j]==1) neighbors++;
                }
            }
        }
        
        return numIslands*4 - neighbors*2;
    }
}