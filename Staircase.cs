using hackerrank_prepare_problemsolving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_prepare_problemsolving
{
    internal class Staircase
    {
        class Result
        {

            /*
            * Complete the 'staircase' function below.
            *
            * The function accepts INTEGER n as parameter.
            */

            public static void staircase(int n)
            {
                for (int i = 1; n >= i; i++)
                {
                    StringBuilder sb = new StringBuilder();

                    for (int j = 0; j < n - i; j++)
                    {
                        sb.Append(" ");

                    }
                    for (int j = 0; i > j;  j++)
                    {
                        sb.Append("#");
                    }
                    Console.WriteLine(sb.ToString());
                }
            }

        }

        public class Solution
        {
            public void Start()
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                Result.staircase(n);
            }
        }

    }
}



//////Staircase detail

//////This is a staircase of size :

//////   #
//////  ##
////// ###
//////####
//////Its base and height are both equal to . It is drawn using # symbols and spaces. The last line is not preceded by any spaces.

//////Write a program that prints a staircase of size .

//////Function Description

//////Complete the staircase function in the editor below.

//////staircase has the following parameter(s):

//////int n: an integer
//////Print

//////Print a staircase as described above.

//////Input Format

//////A single integer, , denoting the size of the staircase.

//////Constraints

////// .

//////Output Format

//////Print a staircase of size  using # symbols and spaces.

//////Note: The last line must have  spaces in it.

//////Sample Input

//////6 
//////Sample Output

//////     #
//////    ##
//////   ###
//////  ####
////// #####
//////######
//////Explanation

//////The staircase is right-aligned, composed of # symbols and spaces, and has a height and width of .

