
public class Solution {
    public int[] PlusOne(int[] digits) {
        int Carry = 0;
        int a = 1;
        Stack<int> myStack = new Stack<int>();
        int count = 0;
        for(int i = 0; i < digits.Length; i++)
        {
            if(digits[i] == 9)
            {
                count++;
            }
            myStack.Push(digits[i]);
        }

                int[] num = new int[count == digits.Length? digits.Length + 1 : digits.Length];

        for(int i = num.Length - 1; i>=0; i--)
        {
             int n = 0;
            if(myStack.Count != 0)
            {
                n = myStack.Pop();
            }
            n += Carry + a;
            num[i] = n % 10;
            Carry = n / 10;
            a = 0;
        }
        
        return num;
    }
}