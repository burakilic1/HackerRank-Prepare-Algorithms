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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        int[] arrnew= new int[6];

        for (int i = 0; i<arr.Count; i++)
        {
            arrnew[arr[i]]++;
        }

        int mosttype = arrnew[1];
        int result = 1;
        for (int i = 2; i < 6; i++)
        {
            if (arrnew[i] > mosttype)
            {
                mosttype = arrnew[i];
                result = i;
            }
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        Console.WriteLine(result);
        Console.ReadLine(); 

    }
}
