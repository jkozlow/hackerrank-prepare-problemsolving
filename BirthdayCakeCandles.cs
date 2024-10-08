﻿using hackerrank_prepare_problemsolving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_prepare_problemsolving
{
    internal class BirthdayCakeCandles
    {
        class Result
        {

            /*
             * Complete the 'birthdayCakeCandles' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts INTEGER_ARRAY candles as parameter.
             */

            public static int birthdayCakeCandles(List<int> candles)
            {
                Predicate<int> n = n => n == candles.Max();
                return candles.FindAll(n).Count();
            }
        }
        public class Solution
        {
            public void Start()
            {
                //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

                int result = Result.birthdayCakeCandles(candles);

                Console.WriteLine(result);

                //textWriter.WriteLine(result);

                //textWriter.Flush();
                //textWriter.Close();
            }
        }

    }
}


//////You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

//////Example


//////The maximum height candles are  units high. There are  of them, so return .

//////Function Description

//////Complete the function birthdayCakeCandles in the editor below.

//////birthdayCakeCandles has the following parameter(s):

//////int candles[n]: the candle heights
//////Returns

//////int: the number of candles that are tallest
//////Input Format

//////The first line contains a single integer, , the size of .
//////The second line contains  space-separated integers, where each integer  describes the height of .

//////Constraints

//////Sample Input 0

//////4
//////3 2 1 3
//////Sample Output 0

//////2
//////Explanation 0

//////Candle heights are . The tallest candles are  units, and there are  of them.