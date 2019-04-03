public class Solution {
    public int NumIslands(char[,] grid) {
        int numIslands = 0;
        int maxX = grid.GetLength(0);
        int maxY = grid.GetLength(1);

        // TODO: optimization: store wiped locations to prevent looking again.
        for(int i = 0; i < maxX; i++) {
            for(int j = 0; j < maxY; j++){
                if(grid[i,j] == '1') {
                    numIslands++;
                    BFSWipe(grid, i, j, maxX, maxY);
                }
            }
        }
        
        return numIslands;
    }
        
    public void BFSWipe(char[,] grid, int i, int j, int maxX, int maxY) {
        grid[i,j] = '0';
        if(i-1 >= 0 && grid[i-1,j] == '1') {
            BFSWipe(grid, i-1, j, maxX, maxY);
        }
        if(i+1 < maxX && grid[i+1,j] == '1'){
            BFSWipe(grid, i+1, j, maxX, maxY);
        }
        if(j-1 >= 0 && grid[i, j-1] == '1'){
            BFSWipe(grid,i,j-1,maxX,maxY);
        }
        if(j+1 < maxY && grid[i,j+1] == '1'){
            BFSWipe(grid,i,j+1,maxX,maxY);
        }
        
    }
        
}