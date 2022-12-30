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
using System.Runtime.Remoting.Messaging;

class Result
{

    /*
     * Complete the 'circularArrayRotation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER k
     *  3. INTEGER_ARRAY queries
     */

    public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
    {
        List<int> answers = new List<int>();
        if (k > a.Count())
        {
            k = k % a.Count();
        }
        for (int i = 0; i < queries.Count(); i++)
        {
            int pos = queries[i];
            if (pos - k < 0)
            {
                answers.Insert(i, a[(a.Count() - Math.Abs(pos - k))]);
            }
            else
            {
                answers.Insert(i, a[(pos - k)]);
            }
        }
        return answers;

    }
     

}

class Solution
{
    public static void Main(string[] args)
    {


        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int q = Convert.ToInt32(firstMultipleInput[2]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> queries = new List<int>();

        for (int i = 0; i < q; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<int> result = Result.circularArrayRotation(a, k, queries);

        Console.WriteLine(String.Join("\n", result));
        Console.ReadLine();

    }
}
