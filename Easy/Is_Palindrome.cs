namespace LeetCode.Easy
{
    public class Is_Palindrome
    {
        public bool IsPalindrome(int x)
        {
            string str = x.ToString();

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
