public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n == 1)
        {
            return true;
        }
        if((n != 1 && n%2 == 1) || n == 0)
        {
            return false;
        }

        return IsPowerOfTwo(n/2);
        
    }
}