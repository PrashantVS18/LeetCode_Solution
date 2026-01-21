public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder n = new StringBuilder();

        for(int i = 0; i< s.Length; i++)
        {
            if(char.IsLetterOrDigit(s[i]))
            {
                n.Append(s[i]);
            }
        }

        string s1 = n.ToString().ToLower();
        int left = 0;
        int right = s1.Length - 1;
        while(left < right)
        {
            Console.WriteLine(s1[left]);
            Console.WriteLine(s1[right]);
            if(s1[left] != s1[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}