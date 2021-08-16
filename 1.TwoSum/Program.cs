using System;
using System.Collections;

namespace _1.TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //change the values as you wish
            int[] nums = new int[] { 3, 2, 3 };            
            int target = 6;

            var result = CalculateTarget(nums, target);
            Console.WriteLine("Result: [" + result[0] + ", " + result[1] + "]");
            Console.ReadKey();
        }

        static int[] CalculateTarget(int[] nums, int target)
        {
            int[] arrReturn = new int[2];
            Hashtable hashNumbers = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                //to avoid wasting time when is the first iteration
                if (i == 0)
                {
                    hashNumbers.Add(0, nums[0]);
                    continue;
                }

                int number = nums[i];

                foreach (DictionaryEntry entry in hashNumbers)
                {
                    if ((int)entry.Value + number == target)
                    {
                        arrReturn = new int[] { (int)entry.Key, i };
                        break;
                    }
                }
                hashNumbers.Add(i, nums[i]);
            }

            return arrReturn;
        }
    }
}
