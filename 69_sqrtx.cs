public class Solution {
    public int MySqrt(int x) {
    if (x == 0) return 0;
    
    int left = 1, right = x;
    
    while (left <= right) {
        int mid = left + (right - left) / 2;
        long midsq = (long)mid * mid;
        
        if (midsq == x) {
            return mid;
        } else if (midsq < x) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }
    
    return right;
}
}