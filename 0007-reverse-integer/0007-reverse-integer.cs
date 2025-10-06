public class Solution {
    public int Reverse(int x) {
        int rev = 0;

        while(x!=0)
        {
            int lastDigit = x % 10;
            x = x / 10;
            // Check overflow before multiplying
            if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && lastDigit > 7))
                return 0;
            if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && lastDigit < -8))
                return 0;
            rev = rev * 10 + lastDigit;
        }
        
        return rev;
    }
}