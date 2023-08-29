public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int key = 1;
        int prev = nums[0];
        for (int i = 1; i < nums.Length; i++){
            if (nums[i] != prev){
                nums[key] = nums[i];
                key++;
            }
            prev = nums[i];
        }
        return key;
    }
}