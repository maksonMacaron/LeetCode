using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Problems
{
    public partial class Solution_Problems
    {
        public class Solution_9
        {
            public static bool IsPalindrome(int x)
            {
                string xString = x.ToString();
                string result = string.Empty;
                for (int i = xString.Length - 1; i >= 0; i--)
                {
                    result += xString[i];
                }

                if (result == x.ToString()) return true;

                return false;
            }
        }
    }
}
