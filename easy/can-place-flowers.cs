public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for(int i = 0; i < flowerbed.Length; i++){
            int prev = i-1;
            int next = i+1;
            if(flowerbed[i] == 1) continue; // Flower in current spot
            else if(prev >= 0 && flowerbed[prev] == 1) continue; // Flower to the left
            else if(next < flowerbed.Length && flowerbed[next] == 1) continue; // Flower to the right
            else {
                flowerbed[i] = 1;
                n--;
            }
        }
        
        return n <= 0;
    }
}