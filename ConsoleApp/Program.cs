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
using Implementation.Search;

class Solution
{
  
    static void Main(string[] args)
    {
        //Console.WriteLine(minimumAbsoluteDifference(new int[] { -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 }));

        //var s = File.ReadLines(@"C:\Temp\input.txt").Select(r=>r.TrimEnd()).ToArray();

        //int t = int.Parse(s[0]);

        //for (int tItr = 0; tItr < t; tItr++)
        //{
        //    int money = Convert.ToInt32(s[tItr * 3 + 1]);

        //    int n = Convert.ToInt32(s[tItr * 3 + 2]);

        //    int[] cost = s[tItr * 3 + 3].Split(' ').Select(r => int.Parse(r)).ToArray();
            
        //    //whatFlavors(cost, money);
        //}

        Console.WriteLine(BinarySearch.BinarySearchRecursive(new int[] { 3,3,4,2, 2, 5, 1 }, 5,-1,0,6));

       
    }

}
