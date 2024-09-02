using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Problems
{
    public partial class Solution_Problems
    {
        public class Solution_0001
        {
            public static int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
                return [];
            }
        }

        public class Solution_0020
        {
            public static bool IsValid(string s)
            {
                Dictionary<char, char> parenthesesDictionary = new Dictionary<char, char>()
                {
                    { '(', ')' }, {'{', '}' }, { '[', ']'}
                };

                if (s.Length % 2 == 1)
                    return false;

                
                List<char> parentheses = new List<char>();
                if (parenthesesDictionary.ContainsValue(s[0]))
                    return false;
                foreach (var c in s)
                {
                    if (parenthesesDictionary.ContainsKey(c))
                    {
                        if (!s.Contains(parenthesesDictionary[c]))
                            return false;
                        parentheses.Add(c);
                    }
                    else
                    {
                        if(parentheses.Count == 0 && parenthesesDictionary.ContainsValue(c))
                            return false;

                        if (c != parenthesesDictionary[parentheses.LastOrDefault()])
                        {
                            return false;
                        }
                        else
                            parentheses.RemoveAt(parentheses.Count - 1);

                    }
                }
                if (parentheses.Count > 0) return false;

                return true;
            }
        }
    }
}
