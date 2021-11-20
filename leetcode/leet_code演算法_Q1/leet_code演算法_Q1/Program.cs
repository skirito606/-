using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code演算法_Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = new int []{ 3, 3};
            int target = 6;
            Solution a=new Solution();
            int [] output=a.TwoSum(input,target);
            Console.WriteLine("{0},{1}",output[0],output[1]);
            Console.ReadKey();
            

        } 
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            /*
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target&& i!=j)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }
            return result;*/
            Dictionary<int, int> cache = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var pair = target - nums[i];

                if (cache.ContainsKey(pair))
                {
                    return new int[] { cache[pair], i };
                }

                //cache.TryAdd(nums[i], i);
            }

            return null;
        }
    }
}
