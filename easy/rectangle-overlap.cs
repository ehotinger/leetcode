public class Solution {
    // |--------------(x2y2)|
    // |                    |
    // |(x1y1)--------------|
    
    // |--------------(x2y2)|
    // |                    |
    // |(x1y1)--------------|
    
    
    // x1, y1, x2, y2
    
    // x1 - 0
    // y1 - 1
    // x2 - 2
    // y2 - 3
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
        int x1 = 0;
        int y1 = 1;
        int x2 = 2;
        int y2 = 3;
        
        // Solve for whether or not they "DON'T OVERLAP" instead - it's easier
        // They don't overlap if left or right or up or down is different
        
        // Right:
        // rec2[x1] >= rec1[x2]
        // Top:
        // rec2[y1] >= rec1[y2]
        // Bottom:
        // rec2[x2] <= rec1[x1]
        // Left:
        // rec2[y2] <= rec1[y1]
        
        return !(rec2[x1] >= rec1[x2] ||
                rec2[y1] >= rec1[y2] ||
                rec2[x2] <= rec1[x1] ||
                rec2[y2] <= rec1[y1]);
    }
}