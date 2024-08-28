using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_prepare_problemsolving
{
    internal class PlusMinus
    {
        class Result
        {

            /*
             * Complete the 'plusMinus' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static void plusMinus(List<int> arr)
            {
                int poscnt = 0;
                int negcnt = 0;
                int zerocnt = 0;

                double p = 0;
                double n = 0;
                double z = 0;


                for (int i = 0; i < arr.Count; i++)
                {
                    switch (Convert.ToInt32(Math.Sign(arr[i])))
                    {
                        case -1:
                            negcnt++;
                            break;
                        case 0:
                            zerocnt++;
                            break;
                        case 1:
                            poscnt++;
                            break;
                    }
                }

                p = Convert.ToDouble(poscnt) / arr.Count;
                n = Convert.ToDouble(negcnt) / arr.Count;
                z = Convert.ToDouble(zerocnt) / arr.Count;

                Console.WriteLine(p.ToString("N6"));
                Console.WriteLine(n.ToString("N6"));
                Console.WriteLine(z.ToString("N6"));
            }

        }

        public class Solution
        {
            public void Start()
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                Result.plusMinus(arr);
            }
        }

    }
}
