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

        string s = "LVIII";
        Console.WriteLine(solution.RomanToInt(s));
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
        Dictionary<char, int> romanValues = new()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0, previousValue = 0;
        

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int currentValue = romanValues[s[i]];
            if(currentValue >= previousValue)
            {
                result += currentValue;
            }
            else
            {
                result -= currentValue;
            }
            previousValue = currentValue;
        }
        return result;

    }
}