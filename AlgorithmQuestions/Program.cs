using System.Linq;

namespace AlgorithmQuestions
{
    public class Program
    {
        public static void Main(string[] args) 
        {
           Console.WriteLine(RomanToInt("III"));
        }


        //LeetCode Top Interview Questions Solution List
        //LeetCode first Question TwoSum
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