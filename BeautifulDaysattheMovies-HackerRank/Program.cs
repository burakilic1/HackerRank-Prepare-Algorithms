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
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
     */

   
        public static int beautifulDays(int i, int j, int k)
        {
            var result = 0;
            for (int l = i; l <= j; l++)
                if (Math.Abs(l - ReverseNumber(l)) % k == 0)
                    result++;
            return result;
        }

        static int ReverseNumber(int number)
        {
            var reversed = 0;
            while (number != 0)
            {
                reversed *= 10;
                reversed += number % 10;
                number /= 10;
            }
            return reversed;
        }
    

}

class Solution
{
    public static void Main(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result.beautifulDays(i, j, k);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
