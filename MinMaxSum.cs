using hackerrank_prepare_problemsolving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_prepare_problemsolving
{
    internal class MinMaxSum
    {
        class Result
        {

            /*
             * Complete the 'miniMaxSum' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static void miniMaxSum(List<int> arr)
            {
                long min = 0;
                long max = 0;

                bool bmin = false;
                bool bmax = false;

                foreach (int i in arr)
                {
                    if (i == arr.Max() && !bmin)
                    {
                        bmin = true;
                    } else
                    {
                        min += i;
                    }
                    if (i == arr.Min() && !bmax)
                    {
                        bmax = true;
                    } else
                    { 
                        max += i;
                    }
                }

                Console.WriteLine(min + " "+ max);
            }
        }

        public class Solution
        {
            public void Start()
            {
                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                Result.miniMaxSum(arr);
            }
        }

    }
}

//////Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

//////Example

//////The minimum sum is  and the maximum sum is . The function prints

//////16 24
//////Function Description

//////Complete the miniMaxSum function in the editor below.

//////miniMaxSum has the following parameter(s):

//////arr: an array of integers
//////Print

//////Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

//////Input Format

//////A single line of five space-separated integers.

//////Constraints


//////Output Format

//////Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

//////Sample Input

//////1 2 3 4 5
//////Sample Output

//////10 14
//////Explanation

//////The numbers are , , , , and . Calculate the following sums using four of the five integers:

//////Sum everything except , the sum is .
//////Sum everything except , the sum is .
//////Sum everything except , the sum is .
//////Sum everything except , the sum is .
//////Sum everything except , the sum is .
//////Hints: Beware of integer overflow! Use 64-bit Integer.