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

            //58. Length of Last Word
            //string s = "bu bir algoritma sorusu çözüm videosudur ";
            //Console.WriteLine(LengthOfLastWord(s));


            //14. Longest Common Prefix
            //string[] s= { "fa", "fa", "falight", "faight"  };
            //Console.WriteLine(LongestCommonPrefix(s));

            ////88 Merge Sorted Array
            //int[] nums1 = {0, 0, 0}; // 1, 2, 2, 3, 5, 6
            //int[] nums2 = {2, 5, 6 };
            //int m = 0;
            //int n = 3; 

            //var resultList = MergeSortedArray(nums1, m, nums2, n);

            // foreach(int i in resultList) { Console.Write(i); }


            //151.Reverse Words in a String
            //string s = " the sky is blue  ";
            //Console.WriteLine(ReverseWords2(s));

            //189
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 7 };
            //int k = 3;
            //Console.WriteLine(RemoveElement(nums,k));
            //int[] array = new int[5];
            //string[] stringArray ;
            //string[] stringArray2 = { "ad" };
            //stringArray =  new string[5];

            //Console.Write(string.Join(" ", stringArray2[0].ToArray()));



            //string[] renkDizisi = { "yeşil", "yeşil", "kırmızı", "kırmızı", "kırmızı", "kırmızı", "pembe", "mavi", "mavi" };
            //int ciftCorapSayisi = SayiCiftCorap(renkDizisi);
            //Console.WriteLine("Toplam çift çorap sayısı: " + ciftCorapSayisi);
            //string word = "The cat sat on the mat, with another cat s ";
            //Console.WriteLine(KelimeSayısıHesapla(word));


            Console.WriteLine(RemoveDuplicates(nums));
        }

        
        public static int KelimeSayısıHesapla(string inputString)
        {
            int index = 0;
            int result = 0;

            while(index< inputString.Length)
            {
                // "  The cat sat on the mat, with another cat"
                if (inputString[index] == ' ')
                {
                    index++;
                }
                else
                {
                    while (index<inputString.Length &&  inputString[index] != ' ')
                    {
                        index++;
                    }
                    result++;
                }
            }

            return result;

        }







        public static int SayiCiftCorap(string[] arr)
        {
            Dictionary<string, int> corapSayilari = new Dictionary<string, int>();
            int ciftCorapSayisi = 0;

            foreach (var renk in arr)
            {
                if (corapSayilari.ContainsKey(renk))
                {
                    corapSayilari[renk]++;
                }
                else
                {
                    corapSayilari.Add(renk, 1);
                }
            }

            foreach (var sayi in corapSayilari.Values)
            {
                if (sayi % 2 == 0)
                {
                    ciftCorapSayisi += sayi / 2;
                }
                else
                {
                    ciftCorapSayisi += (sayi - 1) / 2;
                }

            }

            return ciftCorapSayisi;
        }
        // LeetCode26. Remove Duplicates from Sorted Array
        public int RemoveDuplicates1(int[] nums)
        {
            int i = 0;
            int index = 0;

            while (i < nums.Length)
            {
                while (i < nums.Count() - 1 && nums[i] == nums[i + 1])
                {
                    i++;
                }
                nums[index] = nums[i];
                i++;
                index++;
            }

            return index;

        }
        //LeetCode 80. Remove Duplicates from Sorted Array II
        public static int RemoveDuplicates2(int[] nums)
        {

            int i = 0;
            int index = 0;

            while (i < nums.Length)
            {
                int counted = 1;
                // [1,1,1,2,2,3] // --> [1,1,2,2,3] returns 5

                while ((i < nums.Length - 1) && nums[i] == nums[i + 1])
                {
                    counted++;
                    if (counted <= 2)
                    {
                        nums[index] = nums[i];
                        index++;
                        i++;
                    }
                    else
                    {
                        i++;
                    }

                }
                nums[index] = nums[i];
                index++;
                i++;
            }

            return index;
        }



        //26. Remove Duplicates from Sorted Array
        public static int RemoveDuplicates(int[] nums)
        {
            // { 1,1, 2, 2,3, 3, 4, 5, 6, 7 };

            int i = 0;
            int index=0;
            while(i < nums.Length)
            {
                while ( (i<nums.Length-1) && nums[i] == nums[i + 1])
                {
                    i++;
                }
                nums[index] = nums[i];
                index++;
                i++;
            }
           

           return index;    
        }


        //LeetCode 27
        public static int RemoveElement(int[] nums, int val)
        {
            int result = 0;
           
            for (int i = 0; i<nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[result] = nums[i];
                    result++;
                }
            }
         
            return result;
        }

        //LeetCode-189
        public static int[] Rotate(int[] nums, int k)
        {
            //nums = 6[b],1,2,3,4,95,
            int a=0;
            int b = nums.Length - 1;
            int[] result = new int[nums.Length];
            while (k > 0 && b >= 0)
            {
                result[a] = nums[b];
                result = nums.Take<int>(5).ToArray();
                b--;
                k--;
                a++;
            }
            return result;
        }

        public static int[] MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            //LeetCode 88.soru çözümü --> Problemns --> Top Interview 150 --> 88.soru

            //nums1 => {0,0[k],6}; --> 4
            //nums2 => {4,5[j],};
 
            int i = m - 1;
            int j = n - 1; //-->2
            int k = m + n - 1; 


            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                k--;
                j--;
            }
            return nums1;
        }


        public static string ReverseWords(string s)
        {
            // "The sky is blue "

            // string --> Join, Array.Reverse(liste), string --> split 

            var list = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(list); // string [] = {blue, is, sky, the

            string result = string.Join(" ",list);

            return result;

        }

        public static string ReverseWords2(string s)
        {
            // "the sky is blue  "
            string reverse = "";

            for (int i = s.Length-1; i >= 0; i--)
            {
                string current = "";
                while (i >= 0 && s[i] == ' ')
                {
                    i--;
                }
                while ( i>=0 && s[i] != ' ')
                {
                    //blue
                    current = s[i] + current  ;
                    i--;
                }
                if(current.Length > 0)
                    if(reverse.Length > 0) 
                        reverse = reverse + " " + current;
                    else
                        reverse = reverse+ current; 
            }
            return reverse;
        }



        //14. Longest Common Prefix
        public static string LongestCommonPrefix(string[] list)
        {
            // ["flower","flow","fight", ....]
            string result = list[0];
            string current;

            for (int i = 1; i < list.Length; i++)
            {
                current = list[i];
                if (current == "" || result == "")
                    return "";

                if (result.Length > current.Length)
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