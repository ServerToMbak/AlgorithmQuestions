using System.Collections.Generic;
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
            //int value = SecondBiggestNumberİnAnArray(arrayLsit);
            var response = FindingRepatingNumbersWithHashSet(new int[]{ 2,3,2, 3,3 ,4,5,7,5,2 });
            //foreach (int i in response) 
            //{
            //    Console.WriteLine(i);
            //}
            //string s = "bu bir algoritma sorusu çözüm videosudur ";
            //Console.WriteLine(LengthOfLastWord(s));
            string[] s= { "ab", "a"};
            Console.WriteLine(LongestCommonPrefix(s));

        }




        //14. Longest Common Prefix
        public static string LongestCommonPrefix(string[] list)
        {
            // "flaower", "flaow", "flight", "faight"
            string result = list[0];
            string current;

            for (int i = 1; i < list.Length; i++)
            {
                current = list[i];
                if (current == "" && result == "")
                    return "";
                if(result.Length > current.Length)
                    result = result.Substring(0, current.Length);

                for (int j = 0; j < result.Length; j++)
                {

                    if (current[j] != result[j])
                    {
                        result = result.Substring(0, j);
                    }
                }
            }
            return result;
        }









        //58. Length of Last Word

        public static int LengthOfLastWord(string s){

            // " bu bir leet code algoritma sorusu çözüm videosudur   "
            int result = 0;

            if(string.IsNullOrEmpty(s))
            {
                return  0;
            }
            int index = s.Length - 1;
            while (s[index] == ' ')
            {
                index--;
            }

            while (s[index] != ' ')
            {
                result++;
                index--;
            }

            return result;
            
        }

        //zaman -- namaz
        //public static bool CheckAnagram(string a, string b)
        //{
        //    Dictionary<int,int> MapIndex =new();
        //    if(a.Length != b.Length)
        //        return false;

        //    for(int i = 0;i<a.Length; i++ )
        //    {
        //        for(int j = 0; j<a.Length; j++)
        //        {
        //            if (a[i] == a[j])
        //            {

        //            }
        //        }
        //    }

        //}




        //0,1,2,3,2 4,5,6 -> 2 aldık tüm elemanı dolaş count > 1 ise liste'ye ekle 
        //dizi sonlanınca yeni listeye ekle
        public static List<int> FindingRepatingNumbers(int[] nums)
        {
            List<int> response = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0; // her yeni dizi elenmanı kontrolünde vountu 0'a eşitler
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (i != j && nums[i] == nums[j])
                    {
                        count++;
                        break;
                    }
                }
                if (count > 0 && !response.Contains(nums[i]))
                    response.Add(nums[i]);
            }
            return response;

        }
        //its finding repeating numbers from a list with using HashSet
        public static List<int> FindingRepatingNumbersWithHashSet(int[] nums)
        {
            List<int> response = new();
            HashSet<int> set = new HashSet<int>();  
           
            foreach (int i in nums)
            {
                if(!set.Add(i) && !response.Contains(i))
                {
                    response.Add(i);
                }
            }

            return response;
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
        public static int SecondBiggestNumberİnAnArray(int[] nums)
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