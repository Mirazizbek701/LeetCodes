﻿namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        Solution solution = new();
        int[] sum = solution.TwoSum(nums, target);
        foreach(int x in sum)
        {
            Console.WriteLine("Result: " + x + " ");
        }
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


}
