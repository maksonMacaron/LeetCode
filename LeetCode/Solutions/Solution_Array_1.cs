using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    public class Solution_Array_1
    {
        /// <summary>
        /// Решено. 
        /// </summary>
        public class Solution_Introduction
        {
            public static int FindMaxConsecutiveOnes(int[] nums)
            {
                int maxConsecutiveOnes = 0;
                int currConsecutiveOnes = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 1) currConsecutiveOnes++;
                    else currConsecutiveOnes = 0;
                    if (currConsecutiveOnes > maxConsecutiveOnes) maxConsecutiveOnes = currConsecutiveOnes;
                }

                return maxConsecutiveOnes;
            }

            public static int FindNumbers(int[] nums)
            {
                int count = 0;
                if (nums.Length == 0)
                    return count;

                foreach (var number in nums)
                {
                    List<char> numberChars = number.ToString().ToList();
                    if (numberChars.Count % 2 == 0) count++;
                }

                return count;
            }

            public static int[] SortedSquares(int[] nums)
            {
                int[] sortSquares = new int[nums.Length];



                return sortSquares;

            }
        }
    }
}
