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
     * Complete the 'permutationEquation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY p as parameter.
     */

    public static List<int> permutationEquation(List<int> p)
    {
        List<int> result = new List<int>();
        for (int i = 1; i < p.Count + 1; i++)
        {
            for (int j = 0; j < p.Count; j++)
            {
                if (i == p[j])
                {
                    j++;
                    for (int x = 0; x < p.Count; x++)
                    {
                        if (p[x]==j)
                        {
                            x++;
                            result.Add(x);
                        }
                    }
                }
            }
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

        List<int> result = Result.permutationEquation(p);

        Console.WriteLine(String.Join("\n", result));
        Console.ReadLine();
    }
}
