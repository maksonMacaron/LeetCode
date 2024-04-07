using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    /// <summary>
    /// Решено. Можно оптимизировать
    /// </summary>
    public class Solution_1480
    {
        public static int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i] + sum;
                sum += nums[i];
            }
            return result;
        }
    }

    /// <summary>
    /// Решено. 
    /// </summary>
    public class Solution_1672
    {
        public static int MaximumWealth(int[][] accounts)
        {
            int max = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                int sumMoneyClient = 0;

                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sumMoneyClient += accounts[i][j];
                }

                if (sumMoneyClient > max)
                {
                    max = sumMoneyClient;
                }
            }

            return max;
        }
    }

    /// <summary>
    /// Решено. 
    /// </summary>
    public class Solution_412
    {
        public static IList<string> FizzBuzz(int n)
        {
            IList<string> answer = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    answer.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    answer.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    answer.Add("Buzz");
                }
                else
                {
                    answer.Add($"{i}");
                }
            }
            return answer;
        }
    }

    /// <summary>
    /// Решено. 
    /// </summary>
    public class Solution_1342
    {
        public static int NumberOfSteps(int num)
        {
            if (num == 0) return 0;

            int setps = 0;
            while (num > 0)
            {
                num = num % 2 == 0 ? num / 2 : num - 1;
                setps++;
            }

            return setps;
        }
    }

    /// <summary>
    /// Решено. 
    /// </summary>
    public class Solution_876
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode MiddleNode(ListNode head)
        {
            int countHeads = 1;
            ListNode currNode = head;

            while (currNode.next != null)
            {
                currNode = currNode.next;
                countHeads++;
            }

            int requiredNumber = countHeads / 2 + 1;
            currNode = head;
            int currNumber = 1;
            while (currNumber != requiredNumber)
            {
                currNumber++;
                currNode = currNode.next;
            }
            return currNode;
        }
    }

    /// <summary>
    /// Решено. 
    /// </summary>
    public class Solution_383
    {
        /// <summary>
        /// Учитывая две строки ransomNote и magazine, return true if ransomNote может быть сконструирован с использованием букв из magazine и false в противном случае.
        /// Каждая буква в magazine может быть использована только один раз в ransomNote.
        /// </summary>
        /// <param name="ransomNote">слово которое нужно составить используя словарь</param>
        /// <param name="magazine">словарь (буквы, которые есть)</param>
        /// <returns></returns>
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine.Length == 0) return false;

            List<char> listRansomNote = ransomNote.ToList();

            magazine.ToList().ForEach(charMagazine => listRansomNote.Remove(charMagazine));

            if (listRansomNote.Count == 0) return true;
            return false;
        }
    }
}
