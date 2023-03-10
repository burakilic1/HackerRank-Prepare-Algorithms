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
using System.Runtime.Serialization.Formatters;

class Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int count = 0;
        int sum = 0;
    
        if(s.Count>1)
        { 
        for (int i = 0; i <= s.Count-m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sum = sum + s[i + j];
            }
           if (sum == d)
            {
                count++;
            }
            sum = 0;
        }
        }
        else if (s.Count==1)
        {
            if(s.First()==d) 
            { count++; }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthday(s, d, m);

       Console.WriteLine(result);
       Console.Read();  
    }
}
