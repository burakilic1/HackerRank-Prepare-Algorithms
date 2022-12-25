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
using System.Globalization;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string AmOrPm = s.Substring(8);
        string hour = s.Substring(0, 2);
        string between = s.Substring(2, 6);
        if (AmOrPm == "AM" && hour == "12")
        {
            hour = "00";
        }
        else if (AmOrPm == "PM")
        {
            int numeric = int.Parse(hour);
            if (numeric != 12)
            { hour = Convert.ToString(12 + numeric); }

        }
       Console.Write(hour + between);

        return AmOrPm;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}
