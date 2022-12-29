﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int total = 0;
        int makstotal = -1;  
        Array.Sort(keyboards);
        Array.Sort(drives);
        for (int i = keyboards.Length-1; i >= 0 ; i--)
        {
            for (int j = drives.Length-1; j >=0 ; j--)
            {
                total = keyboards[i] + drives[j];
                if (total<=b && total> makstotal )
                {
                    makstotal= total;
                }
            }
        }
        return makstotal;

       

    }

    static void Main(string[] args)
    {

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        Console.WriteLine(moneySpent);
        Console.ReadLine();
    }
}
