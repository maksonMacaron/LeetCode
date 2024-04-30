using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Arrays
{
    public class Solution_Array_1
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

        /// <summary>
        /// *
        /// </summary>
        public static int[] SortedSquares(int[] nums)
        {
            int lengthNums = nums.Length;
            int[] result = new int[lengthNums];

            int indexStart = 0;
            int indexFinish = lengthNums - 1;
            //начиная с последнего элемента, самого большого
            for (int indexNums = lengthNums - 1; indexNums >= 0; indexNums--)
            {
                if (Math.Abs(nums[indexStart]) > Math.Abs(nums[indexFinish]))
                {
                    result[indexNums] = nums[indexStart] * nums[indexStart];
                    indexStart++;
                }
                else
                {
                    result[indexNums] = nums[indexFinish] * nums[indexFinish];
                    indexFinish--;
                }
            }
            return result;
        }


        public static int[] DuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != 0) continue;
                for (int j = arr.Length - 1; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[i + 1] = 0;
                i++;
            }
            return arr;
        }

        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            while(m > 0 && n > 0)
            {
                if (nums1[m - 1] >= nums2[n - 1])
                {
                    nums1[m + n - 1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[m + n - 1] = nums2[n - 1];
                    n--;
                }
            }
            if (m == 0 && n != 0)
            {
                nums1 = [..nums2];
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
            }

            return nums1;
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int countNotEqualVal = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        nums[j - 1] = nums[j];
                    }
                }
                else countNotEqualVal++;
            }

            return countNotEqualVal;
        }


    }
}
