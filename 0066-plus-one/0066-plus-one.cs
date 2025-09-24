
public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 0;
        int a = 1;
        for(int i = digits.Length - 1; i>= 0; i--)
        {
            int n = digits[i] + carry + a;
            if(n != 10)
            {
                digits[i] = n;
                return digits;
            }
            else
            {
                carry = 1;
                digits[i] = 0;
            }
            a = 0;
        }
        int[] arr = new int[digits.Length + 1];
        arr[0] = 1;
        for(int i = 1; i < arr.Length; i++)
        {
            arr[i] = digits[i-1];
        }
        return arr;


    }
}