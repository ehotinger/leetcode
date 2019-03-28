public class Solution {
    // Start: 8:53pm
    // End: 9:12pm
    public int MinCost(int[,] costs) {
        var r = costs.GetLength(0);
        
        // The idea here is that you pay some cost X to paint a house.
        // We compute the cost of painting each house based on previous decisions.
        
        // Then we minimum cost of painting the final house in the row.
        
        // red blue green
        // costs[0,0,1,2] => original cost
        // costs[1,0] => Math.Min(costs[0,1], costs[0,2])
        // costs[1,1] => Math.Min(costs[0,0], costs[0,2])
        // costs[1,2] => Math.Min(costs[0,0], costs[0,1])
        
        for(int i = 1; i < r; i++) {
            costs[i,0] += Math.Min(costs[i-1, 1], costs[i-1, 2]);
            costs[i,1] += Math.Min(costs[i-1, 0], costs[i-1, 2]);
            costs[i,2] += Math.Min(costs[i-1, 1], costs[i-1, 0]);
        }
        
        return Math.Min(Math.Min(costs[r-1,0], costs[r-1,1]), costs[r-1, 2]);
    }
}