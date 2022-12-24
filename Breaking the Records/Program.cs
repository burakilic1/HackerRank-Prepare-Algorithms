using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Security.Cryptography.X509Certificates;

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> result = new List<int>();
        int high = 0;
        int sumhigh = 0;
        int low = 0;
        int sumlow = 0;


        for (int i = 0; i < scores.Count; i++)
        {
            if(i==0)
            {
                high = scores[0];
                low = scores[0];
            }
            else
            {
                if (scores[i] > high)
                {
                    high = scores[i];
                    sumhigh++;
                }
                else if (scores[i] < low)
                {
                    low = scores[i];
                    sumlow++;
                }
            }

        }

        result.Add(sumhigh);
        result.Add(sumlow);

        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {


        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));

        Console.ReadLine();
    }
}
