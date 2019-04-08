// https://leetcode.com/problems/product-of-array-except-self/
public int[] ProductExceptSelf(int[] nums) 
    {
        int[] arr = new int[nums.Length];
        
        // forward
        int prod = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            prod *= nums[i];
            arr[i] = prod;
        }
        
        // backwards
        prod = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            arr[i] = prod * (i > 0 ? arr[i-1] : 1);
            prod *= nums[i];
        }
        
        return arr;
    }