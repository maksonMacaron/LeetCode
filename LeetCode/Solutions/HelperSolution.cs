using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    public class HelperSolution
    {
        public static void PrintArray(int[] nums)
        {
            foreach (int i in nums) 
                Console.Write(i + " ");
        }

        public static void PrintArray(int[][] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write(nums[i][j] + "\t");
                }
                Console.WriteLine(string.Empty);
            }
        }
    }
}
