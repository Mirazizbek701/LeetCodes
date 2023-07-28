namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new();

        #region TwoSum

        //int[] nums = { 2, 7, 11, 15 };
        //int target = 9;
        //int[] sum = solution.TwoSum(nums, target);
        //foreach(int x in sum)
        //{
        //    Console.WriteLine("Result: " + x + " ");
        //}

        #endregion

        #region IsPalindrome

        //int x = 121;
        //Console.WriteLine(solution.IsPalindrome(x));

        #endregion
    }
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }
        return result;
    }
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
    public int RomanToInt(string s)
    {

    }


}
