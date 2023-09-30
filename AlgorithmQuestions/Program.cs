using System.Linq;
using System.Reflection;

namespace AlgorithmQuestions
{
    public class Program
    {
        
        public static void Main(string[] args) 
        {
            int[] arrayLsit = { 1, 23, 4,85,21,3,23,4,72,73, 56 };

            ////Biggest Number
            //Console.WriteLine(BiggestNumberİnAnArray(arrayLsit));
            int value = SeconBiggestNumberİnAnArray(arrayLsit);
            Console.WriteLine(value);
        }
        public static int BiggestNumberİnAnArray(int[] nums)
        {
            int bigger = 1;
            foreach (int num in nums) 
            {
                
                if(bigger<num)
                {
                    bigger = num;

                }
                
            }
            return bigger; ;
        }
        //buble sort


        //second biggest number in an array
        public static int SeconBiggestNumberİnAnArray(int[] nums)
        {
            int holder;
            int index = 0;
            for (int i=0; i<nums.Length; i++)
            {
               
                for (int j = 0; j < nums.Length; j++)
                {
                    
                    if (nums[index] > nums[j])
                    {
                        holder = nums[index];
                        nums[index] = nums[j];
                        nums[j] = holder;

                    }                   
                }
                index++;

            }

            return nums[1];
        }

        //leetCode Top Interview Question 1
        public int[] TwoSum(int[] nums, int target)
        {
            int x, y;
            int Target = 9;
            for (x = 0; x < nums.Length; x++)
            {
                int fistNumber = nums[x];
                for (y = x + 1; y < nums.Length; y++)
                {
                    int secondNumber = nums[y];
                    if (fistNumber + secondNumber == target)
                    {
                        return new int[] {x,y};
                    }
                   
                }
            }
            return new int[0];
            
        }
        //LeetCode Top Interview Question 2
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            int x = 0;
            int y = 0;
            int total = 0;
            ListNode outputList = new ListNode(0);
            ListNode finalOutput = outputList;
            ListNode firstList = l1;
            ListNode secondList = l2;


            while (firstList != null || secondList != null)
            {
                x = (firstList != null) ? firstList.val : 0;
                y = (secondList != null) ? secondList.val : 0;
                total = x + y + carry;

                carry = total / 10;
                outputList.next = new ListNode(total % 10);
                outputList = outputList.next;

                if (firstList != null) firstList = firstList.next;
                if (secondList != null) secondList = secondList.next;
            }
            if (carry > 0)
            {
                outputList.next = new ListNode(carry);
            }
            return finalOutput.next;
        }

        //LeetCode 13.Question 
        public static int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int result = map[s[s.Length - 1]];

            for (int index = s.Length - 2; index >= 0; index--)
            {
                if (map[s[index]] < map[s[index + 1]])
                {
                    result -= map[s[index]];
                }
                else
                {
                    result += map[s[index]];
                }
            }

            return result;
        }
    }
    
}