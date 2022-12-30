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
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        
        List<int> list = new List<int>();

        foreach (var x in player)
        {
            ranked.Add(x);
            ranked = ranked.Distinct().ToList();
            ranked.Sort();
            ranked.Reverse();

            for (int j = 0; j < ranked.Count; j++)
            {
                if (x == ranked[j])
                {
                    list.Add(j + 1);
                    ranked.Remove(x);
                    break;
                }
            }
        }
        return list;


    }
}


class Solution
{
    public static void Main(string[] args)
    {


        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result.climbingLeaderboard(ranked, player);

        Console.WriteLine(String.Join("\n", result));
        Console.ReadLine();
    }

}

