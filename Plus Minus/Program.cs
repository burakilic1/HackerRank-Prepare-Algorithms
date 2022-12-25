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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int n = arr.Count;
        decimal sump = 0;
        decimal sumn = 0;
        decimal sumz = 0;
        foreach (var x in arr)
        {
            if(x>0)
                sump++;
            else if(x<0)
                sumn++;
            else
                sumz++;
        }

        Console.WriteLine($"{sump / n:0.000000}");
        Console.WriteLine($"{sumn / n:0.000000}");
        Console.WriteLine($"{sumz / n:0.000000}");
        Console.ReadLine();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
