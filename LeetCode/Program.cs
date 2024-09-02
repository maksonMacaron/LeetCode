using LeetCode.Solutions;
using LeetCode.Solutions.Arrays;
using LeetCode.Solutions.Problems;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode
{
    public class Program
    {
        private static void Main(string[] args)
        {

            /* Solution_876.ListNode node6 = new Solution_876.ListNode()
             {
                 val = 1,
             };

             Solution_876.ListNode node5 = new Solution_876.ListNode()
             {
                 next = node6,
                 val = 1,
             };

             Solution_876.ListNode node4 = new Solution_876.ListNode()
             {
                 next = node5,
                 val = 1,
             };

             Solution_876.ListNode node3 = new Solution_876.ListNode()
             {
                 next = node4,
                 val = 1,
             };

             Solution_876.ListNode node2 = new Solution_876.ListNode()
             {
                 next = node3,
                 val = 1,
             };

             Solution_876.ListNode node1 = new Solution_876.ListNode()
             {
                 next = node2,
                 val = 1,
             };*/
            //HelperSolution.PrintArray(Solution_Array_1.Merge([0], 0, [1], 1));
            //Вывод: [1,2,2,3,5,6]
            //Console.WriteLine(Solution_Problems.Solution_9.IsPalindrome_Int(41_738));
            //HelperSolution.PrintArray(Solution_Array_1.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3));
            //HelperSolution.PrintArray(Solution_Array_1.Merge([0], 0, [1], 1));
            //Solution_Array_1.RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2);
            //HelperSolution.PrintArray(Solution_Problems.Solution_0001.TwoSum([3, 2, 4], 6));
            object result;
            result = Solution_Problems.Solution_0020.IsValid("[([]])");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
