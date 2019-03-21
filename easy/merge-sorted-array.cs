public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        // For a case like this:
        // [1,2,3,0,0,0]
        // [4,5,6]
        
        // We start at the 3 in the first array and the 6 in the 2nd array
        // and try to place the largest value on the right-most side of the first array.
        // We repeat this process for both arrays until their respective pointers are at 0.
        int i = m+n-1;
        int p1 = m-1;
        int p2 = n-1;
        while(p1 >= 0 && p2 >= 0) {
            if(nums1[p1] > nums2[p2]) {
                nums1[i] = nums1[p1--];
            } else {
                nums1[i] = nums2[p2--];
            }
            i--;
        }
        
        // Add any remaining elements from the second array into the first, i.e. more elements in 2 than in 1.
        while(p2 >= 0) {
            nums1[i--] = nums2[p2--];
        }
    }
}