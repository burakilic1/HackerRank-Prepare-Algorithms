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
using System.Runtime.InteropServices.WindowsRuntime;

class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int level = 0; 
        int valleyCount= 0;

        foreach(var x in path)
        {
            if (x=='D')
            {
                level--;
            }
            if (x=='U')
            {
                level++;
                if (level == 0)
                {
                    valleyCount++;
                }
            }
        }
        return valleyCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
