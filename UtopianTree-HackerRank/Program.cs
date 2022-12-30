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

class Result
{

    /*
     * Complete the 'utopianTree' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int utopianTree(int n)
    {
        int sum = 0;
        for (int i = 0; i < 61; i++)
        {
            if (i % 2 == 0)
            {
                sum++;
            }
            else
            {
                sum = (sum * 2);
            }
            if (i == n)
            {
                return sum;
            }
        }
        return 0;


    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.utopianTree(n);

            Console.WriteLine(result);
        }

        Console.ReadLine();
    }
}
