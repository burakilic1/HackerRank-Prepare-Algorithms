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
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
        return Math.Min(p / 2, n / 2 - p / 2);

        //if (n / 2 > p)
        //{
        //    if (n % 2 == 0)
        //    {
        //        if (p % 2 == 1)
        //        {
        //            return ((p - 1) / 2);
        //        }
        //        else
        //        {
        //            return (p / 2);
        //        }
        //    }
        //    else
        //    {
        //        if (p % 2 == 0)
        //        {
        //            return ( p  / 2);
        //        }
        //        else
        //        {
        //            return ((p - 1) / 2);
        //        }
        //    }
        //}
        //else if (n / 2 < p)
        //{
        //    if (n % 2 == 0)
        //    {
        //        if (p % 2 == 1)
        //        {
        //            return ((n - p + 1) / 2);
        //        }
        //        else
        //        {
        //            return ((n - p) / 2);
        //        }
        //    }
        //    else
        //    {
        //        if (p%2==0)
        //        {
        //            return ((n - p - 1) / 2);
        //        }
        //        else
        //        {
        //            return ((n - p) / 2);
        //        }
        //    }
        //}
        //else if(n/2==p)
        //{
        //    return (p - 1) / 2;
        //}

        //return 0;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}
