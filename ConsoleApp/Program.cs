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
using ConsoleApp1;

class Solution
{
    // Complete the minimumAbsoluteDifference function below.
    // Complete the whatFlavors function below.
    static void whatFlavors(int[] cost, int money)
    {
        Tuple<int, int>[] newCost = new Tuple<int, int>[cost.Length];
        for (int i = 0; i < cost.Length; i++)
        {
            newCost[i] = new Tuple<int, int>(cost[i], i);
        }

        Tuple<int, int>[] sortedCost = newCost.OrderBy(o => o.Item1).ToArray();
        int one =0;
        int two =0; 
        for (int i = 0; i < sortedCost.Length; i++)
        {
            one = i;
            two = findIndex(sortedCost, money - cost[one]);

            if (two != -1 && two != one)
                break;
        }
        
        if(one < two)
            Console.WriteLine("{0} {1}",one + 1, two +1 );
        else
            Console.WriteLine("{0} {1}",two + 1, one + 1);
    }

    static int findIndex(Tuple<int, int>[] a,int searchValue) {
        int left = 0;
        int right = a.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (a[mid].Item1 == searchValue)
            {
                return  a[mid].Item2;
            }
            else if (searchValue < a[mid].Item1)
            {
                right = mid - 1;
            }
            else {
                left = mid + 1;
            }
        }
        return -1;
    }
    static void Main(string[] args)
    {
        //Console.WriteLine(minimumAbsoluteDifference(new int[] { -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 }));

        //var a = TextFileReader.GetArray(@"C:\Temp\input.txt");
        var s = File.ReadLines(@"C:\Temp\input.txt").Select(r=>r.TrimEnd()).ToArray();

        int t = int.Parse(s[0]);

        for (int tItr = 0; tItr < t; tItr++)
        {
            int money = Convert.ToInt32(s[tItr * 3 + 1]);

            int n = Convert.ToInt32(s[tItr * 3 + 2]);

            int[] cost = s[tItr * 3 + 3].Split(' ').Select(r => int.Parse(r)).ToArray();
            ;
            whatFlavors(cost, money);
        }

      //  whatFlavors(a, 245589753);

       
    }

}
