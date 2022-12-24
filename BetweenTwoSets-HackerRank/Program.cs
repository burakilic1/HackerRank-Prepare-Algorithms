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
    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;
        if (a.Max() > b.Min())
        { return 0; }

        for (int i = a.Max(); i <= b.Min(); i++)
        {
            bool result = true;
            for (int j = 0; j < a.Count; j++)
            {
                if (i % a[j] != 0)
                {
                    result = false; break;
                }
            }
            if (result)
            {
                for (int j = 0; j< b.Count ; j++)
                {
                    if (b[j] % i != 0)
                    { result = false; break; }
                }
            }
            if(result)
            {
                count ++;
            }
        }
        
        return count;

    }

}

class Solution
{
    public static void Main(string[] args)
    {


        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        Console.WriteLine(total);

        Console.ReadLine();
    }
}

