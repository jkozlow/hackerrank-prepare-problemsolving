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
    internal class TimeConversion
    {
        class Result
        {

            /*
             * Complete the 'timeConversion' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts STRING s as parameter.
             */

            public static string timeConversion(string s)
            {
                DateTime dt = DateTime.Parse(s);
                return dt.ToString("HH:mm:ss");
            }
        }
        public class Solution
        {
            public void Start()
            {
                //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                string s = Console.ReadLine();

                string result = Result.timeConversion(s);

                Console.WriteLine(result);

                //textWriter.WriteLine(result);

                //textWriter.Flush();
                //textWriter.Close();
            }
        }

    }
}


//////Given a time in -hour AM/PM format, convert it to military (24-hour) time.

//////Note: -12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
//////- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

//////Example


//////Return '12:01:00'.


//////Return '00:01:00'.

//////Function Description

//////Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

//////timeConversion has the following parameter(s):

//////string s: a time in  hour format
//////Returns

//////string: the time in  hour format
//////Input Format

//////A single string  that represents a time in -hour clock format (i.e.:  or ).

//////Constraints

//////All input times are valid
//////Sample Input 0

//////07:05:45PM
//////Sample Output 0

//////19:05:45