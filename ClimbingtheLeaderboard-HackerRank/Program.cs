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
        for (int i = 0; i < player.Count; i++)
        {
            int count = 0;
            ranked.Add(player[i]);
            ranked.Sort();
            for (int j = 1; j < ranked.Count; j++)
            {
                if (ranked[j - 1] != ranked[j])
                {
                    count++;
                }
                if (player[i] == ranked[j])
                {
                    list.Add(count);
                }

            }
            ranked.Remove(player[i]);
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
