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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        string ddmm1 = "12.09.";
        string ddmm2 = "13.09.";
        if (year == 1918)
            return "26.09.1918";
        if (year<1918)
        {
            if (year % 4 == 0)
            {
                return ddmm1 + year.ToString();
            }
                return ddmm2 + year.ToString();
        }
        else
        {
            if ((year%4==0 && year%100!=0) || (year%100==0 && year%400==0))
            {
                return ddmm1 + year.ToString();
            }
        }
        return ddmm2 + year.ToString();


    }

}

class Solution
{
    public static void Main(string[] args)
    {
     
        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        Console.WriteLine(result);

        Console.ReadLine();

    }
}

