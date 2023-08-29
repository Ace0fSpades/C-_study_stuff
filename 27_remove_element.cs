public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int pos = 0;
        foreach( int n in nums){
            if (n != val){
                nums[pos] = n;
                pos++;
            }
        }
        return pos;
    }
}